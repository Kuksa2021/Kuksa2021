using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    /// <summary>
    /// Интерфейс класса, обеспечивающего вывод информации о категориях на экран и взаимодействие с пользователем
    /// </summary>

    public interface ICategoriesView
    {
        /// <summary>
        /// Вывод категорий на экран
        /// </summary>
        /// <param name="list">Список категорий</param>
        void ShowCathegories(List<Category> listCategories);


        /// <summary>
        /// Событие.Ввод нового значения Категории в БД
        /// </summary>
        event EventHandler<string> AddingCategoryName;

        /// <summary>
        /// Событие. Удаление категории из БД
        /// </summary>
        public event EventHandler<Category> DeletingCategory;

        /// <summary>
        /// Событие. Изменеие категории из БД
        /// </summary>
        public event EventHandler<Category> UpdatingCategory;
    }

}
