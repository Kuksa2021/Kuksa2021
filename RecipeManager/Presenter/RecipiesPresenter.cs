using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;
using ModelDB;


namespace Presenter
{
    /// <summary>
    /// Класс обеспечивает взаимодействие м/у БД и классом, обеспечивабщим взаимодействие пользователя с рецептами
    /// </summary>
    public class RecipiesPresenter
    {
        IRecipesViewer viewer;
        IModelRecipies model;

        public RecipiesPresenter(IRecipesViewer viewer)
        {
            this.viewer = viewer;
            this.viewer.AddingRecipy += AddRecipieInDB;
            this.viewer.DeletingRecipy += DelRecipieInDB;
            this.viewer.UpdatingRecipy += UpdateRecipieInDB;
            this.viewer.SaveRecipiesToFile += SavelRecipiesInFile;
            this.viewer.LoadRecipiesFromFile += LoadRecipiesFromFile;

            model = DbRecipe.GetInstance();
            model.ModelRecipeUpdated += RefreshRecipiesBecauseDbUpdated;

            model.Products.ModelProductsUpdated += RefreshRecipiesBecauseDbUpdated;
            model.Categories.ModelCategoryUpdated += RefreshRecipiesBecauseDbUpdated;
        }



        /// <summary>
        /// Получить данные из БД
        /// </summary>
        public void GetRecipeisFromDB()
        {
            var recipies = model.GetRecipies();

            var categories = model.Categories.GetCategories();
            var products = model.Products.GetProducts();

            viewer.ShowRecipies(recipies, categories, products);
        }



        /// <summary>
        /// Обновить форму пользоваетля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RefreshRecipiesBecauseDbUpdated(object sender, object e)
        {
            GetRecipeisFromDB();
        }




        /// <summary>
        /// Удалить рецепт из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="recipe">Удаляемый рецепт</param>
        void DelRecipieInDB(object sender, Recipe recipe)
        {
            model.DelRecipe(recipe);
        }




        /// <summary>
        /// Добавить рецепт в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="recipe">Добавляемый рецепт</param>
        void AddRecipieInDB(object sender, Recipe recipe)
        {
            model.AddRecipe(recipe);
        }


        /// <summary>
        /// Изменить рецепт в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="recipe">Изменённый рецепт</param>
        void UpdateRecipieInDB(object sender, Recipe recipe)
        {
            model.UpdateRecipe(recipe);
        }


        /// <summary>
        /// Сохранить рецепты в файле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="recipies"></param>
        void SavelRecipiesInFile(List<Recipe> recipies, string fileName)
        {
            model.SaveRecipiesInNewFile(recipies, fileName, new XMLFile());
        }


        /// <summary>
        /// Добавить рецепты из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="recipies"></param>
        void LoadRecipiesFromFile(string fileName)
        {
            model.LoadRecipiesFromFile(fileName, new XMLFile(),
            out List<Recipe> addedRecipies,
            out List<Recipe> notAddedRecipies,
            out List<Product> addedProducts,
            out List<Category> addedCategory);


            viewer.ShowRezultLoadingRecipiesFromFile(
           in addedRecipies,
           in notAddedRecipies,
           in addedProducts,
           in addedCategory);
        }
    }

}

