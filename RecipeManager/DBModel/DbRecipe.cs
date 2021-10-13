using CommonClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDB
{
    public class DbRecipe: IModelRecipies
    {
        DB context;
        private static DbRecipe instance;

        public IModelCategories Categories { get; set; }  = DbCategory.GetInstance();
        public IModelProducts Products { get; set; } = DbProduct.GetInstance();

        public event EventHandler<EventArgs> ModelRecipeUpdated;

        /// <summary>
        /// Конструктор
        /// </summary>
        DbRecipe()
        {
            this.context = DB.GetInstance();
            this.context.DBRecipeUpdated += RecipeUpdated;
        }


        /// <summary>
        /// Метод возвращает экземпляр класса DbRecipe
        /// </summary>
        /// <returns></returns>
        public static DbRecipe GetInstance()
        {
            if (instance == null)
            {
                instance = new DbRecipe();
            }
            return instance;
        }

        /// <summary>
        /// Метод вызывается при обновлении списка рецептов в БД
        /// </summary>
        void RecipeUpdated(object obj, EventArgs er)
        {
            ModelRecipeUpdated?.Invoke(null, EventArgs.Empty);
        }






        public List<Recipe> GetRecipies()
        {
            return context.Recipies.ToList<Recipe>();
        }

        public void DelRecipe(Recipe recipe)
        {
            context.Recipies.Remove(recipe);
            if (context.SaveChanges() > 0) context.OnRecipeUpdated();
        }

        public void AddRecipe(Recipe recipe)
        {
            context.Recipies.Add(recipe);
            if (context.SaveChanges() > 0) context.OnRecipeUpdated();
        }

        public void UpdateRecipe(Recipe recipe)
        {
            Recipe finedRecipe = context.Recipies.FirstOrDefault(x => x.Id == recipe.Id);
            if (finedRecipe == null) return;
            if (context.SaveChanges() > 0) context.OnRecipeUpdated();
        }




        public void  GetCategories()
        {

        }

        public void GetProducts()
        {

        }



        public void SaveRecipiesInNewFile(List<Recipe> recipies, string fileName, ISaveAndLoadRecipies save)
        {
            save.SaveRecipies(recipies, fileName);
        }

        public void LoadRecipiesFromFile(string fileName, ISaveAndLoadRecipies load,
            out List<Recipe> addedRecipies,
            out List<Recipe> notAddedRecipies,
            out List<Product> addedProducts,
            out List<Category> addedCategories)
        {

            List<Recipe> recipes = load.LoadRecipies(fileName);

            var locarRecipies = context.Recipies.Local.ToList();

            //получаем рецепты, с названиями НЕ совпадающими с рецептами в БД
            var notFineddRecipiesInDB = recipes.Where(x => locarRecipies.FirstOrDefault(y => y.Name == x.Name) == null);
            //получаем рецепты, с названиями совпадающими с рецептами в БД
            var fineddRecipiesInDB = recipes.Where(x => locarRecipies.FirstOrDefault(y => y.Name == x.Name) != null);

            addedRecipies = notFineddRecipiesInDB.ToList<Recipe>();//будем возыращать этот список новых рецептов, котрых нет в БД
            notAddedRecipies = fineddRecipiesInDB.ToList<Recipe>();


            var localCategories = context.Categories.Local.ToList();
            // Добавляем новые категории, которые всречаются в фалй и их нет в БД
            //Выбираем все новые категории, которые встречаются в добавляемых рецептах из файла
            var newListCategories = from recipe in notFineddRecipiesInDB
                                    where localCategories.FirstOrDefault(x => x.Name == recipe.Category.Name) == null
                                    select recipe.Category;

            addedCategories = newListCategories.ToList<Category>();//будем возыращать этот список новых категорий, котрых нет в БД

            foreach (var item in newListCategories) //добавляем новые Категории в БД
                context.Categories.Add(item);


            // Добавляем новые продукты, которые всречаются в фалй и их нет в БД
            var localProducts = context.Products.Local.ToList();
            //Выбираем все продукты в новых рецептах из файла, которых нет в БД
            var newListProducts = from recipe in notFineddRecipiesInDB
                                  from ingradient in recipe.Ingradients
                                  where localProducts.FirstOrDefault(x => x.Name == ingradient.Product.Name) == null
                                  select ingradient.Product;

            addedProducts = newListProducts.ToList<Product>(); //будем возыращать этот список новых продуктов, котрых нет в БД

            foreach (var item in newListProducts) //добавляем новые продукты в БД
                context.Products.Add(item);

            context.SaveChanges();
            localProducts = context.Products.Local.ToList();
            localCategories = context.Categories.Local.ToList();


            foreach (var item in notFineddRecipiesInDB)
            {
                Recipe newRecipe = new Recipe();
                newRecipe.Name = item.Name;
                newRecipe.Description = item.Description;
                newRecipe.Category = localCategories.First(x => x.Name == item.Category.Name);
                foreach (var ingredient in item.Ingradients)
                {
                    Product product = localProducts.First(x => x.Name == ingredient.Product.Name);
                    newRecipe.Ingradients.Add(new Ingredient { Product = product, Weight = ingredient.Weight, MeasurementUnit = ingredient.MeasurementUnit });
                }

                context.Recipies.Add(newRecipe);
            }
            context.SaveChanges();

            InformSubscribers();
        }

        /// <summary>
        /// Проинформировать подписчиков, что данные измениплись
        /// </summary>
        void InformSubscribers()
        {
            //Заставляем обновиться подписчиков, т.е. уведомляем их, что БД обновлена

            context.OnCategoryUpdated();
            context.OnProductUpdated();
            context.OnRecipeUpdated();

            //DBCategoryUpdated?.Invoke(this, EventArgs.Empty);
            //DBProductsUpdated?.Invoke(this, EventArgs.Empty);
            //DBRecipeUpdated?.Invoke(this, EventArgs.Empty);
        }


    }
}
