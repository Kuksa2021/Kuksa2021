using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{

    /// <summary>
    /// Интерфейс класса, обеспечивающего вывод рецептов на экран и взаимодействие с пользователем
    /// </summary>
    public interface IRecipesViewer
    {
        /// <summary>
        /// Удалить рецепт
        /// </summary>
        event EventHandler<Recipe> DeletingRecipy;

        /// <summary>
        /// Добавить рецепт
        /// </summary>
        event EventHandler<Recipe> AddingRecipy;

        /// <summary>
        /// Изменить рецепт
        /// </summary>
        event EventHandler<Recipe> UpdatingRecipy;
        
        /// <summary>
        /// Запись рецептов в БД
        /// </summary>
        event Action<List<Recipe>, string> SaveRecipiesToFile;
        /// <summary>
        /// Чтение рецептов из БД
        /// </summary>
        event Action<string> LoadRecipiesFromFile;
        

        /// <summary>
        /// Вывод рецептов на экран
        /// </summary>
        /// <param name="recipes">Список рецептов</param>
        /// <param name="categories">Список категорий</param>
        /// <param name="products">Список продуктов</param>
        void ShowRecipies(List<Recipe> recipes, List<Category> categories, List<Product> products);

        /// <summary>
        /// Выводим отчёт о загруженных рецептах из файла
        /// </summary>
        void ShowRezultLoadingRecipiesFromFile(
            in List<Recipe> addedRecipies,
            in List<Recipe> notAddedRecipies,
            in List<Product> addedProducts,
            in List<Category> addedCategory);




    }
}
