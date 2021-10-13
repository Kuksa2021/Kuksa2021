using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{

    /// <summary>
    /// Интерфес БД для категорий
    /// </summary>

    public interface IModelCategories
    {
        /// <summary>
        /// Возвращает список категорий из БД
        /// </summary>
        /// <returns></returns>
        List<Category> GetCategories();


        /// <summary>
        /// Добавить название новой категории в БД
        /// </summary>
        /// <param name="categoryName">Название добавляемой категории</param>
        void AddNewCategory(string categoryName);

        /// <summary>
        /// Удалить категорию из БД
        /// </summary>
        /// <param name="category">Удаляемая категория</param>
        void DeleteCategory(Category category);

        /// <summary>
        /// Обновить категорию в БД
        /// </summary>
        /// <param name="category">Обновляемая категория</param>
        void UpdateCategory(Category category);

        /// <summary>
        /// Событие, сообщающее что записи в БД о Категориях Изменились 
        /// </summary>
        event EventHandler<EventArgs> ModelCategoryUpdated;
    }


}
