using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    
    /// <summary>
    /// Интерфес БД для рецептов
    /// </summary>
    public interface IModelRecipies //: IModelCategories, IModelProducts
    {
        /// <summary>
        /// Метод возвращает список рецептов
        /// </summary>
        /// <returns></returns>
        List<Recipe> GetRecipies();


        /// <summary>
        /// Метод добавляет рецепт в БД
        /// </summary>
        /// <param name="recipe"></param>
        void AddRecipe(Recipe recipe);


        /// <summary>
        /// Метод изменяет рецепт в БД
        /// </summary>
        /// <param name="recipe"></param>
        void UpdateRecipe(Recipe recipe);



        /// <summary>
        /// Метод удаляет рецепт из БД
        /// </summary>
        /// <param name="recipe"></param>
        void DelRecipe(Recipe recipe);






        /// <summary>
        /// Метод сохраняет список рецептов в файле
        /// </summary>
        /// <param name="recipies">Список рецептов</param>
        void SaveRecipiesInNewFile(List<Recipe> recipies, string fileName, ISaveAndLoadRecipies save);


        /// <summary>
        /// Метод загружает рецепты из файле
        /// </summary>
        /// <param name="recipies">Список рецептов</param>
        void LoadRecipiesFromFile(string fileName, ISaveAndLoadRecipies load,
            out List<Recipe> addedRecipies,
            out List<Recipe> notAddedRecipies,
            out List<Product> addedProducts,
            out List<Category> addedCategory);

        /// <summary>
        /// Событие. Обновления БД
        /// </summary>
        event EventHandler<EventArgs> ModelRecipeUpdated;


        /// <summary>
        /// Ссылка на класс для работающий с категориями
        /// </summary>
        public IModelCategories Categories { get; set; }

        /// <summary>
        /// Ссылка на класс работающий с продуктами
        /// </summary>
        public IModelProducts Products { get; set; }

    }
}
