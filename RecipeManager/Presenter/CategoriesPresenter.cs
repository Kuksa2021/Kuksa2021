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
    /// Класс обеспечивает взаимодействие м/у БД и классом, обеспечивабщим взаимодействие пользователя с категориями
    /// </summary>
    public class CategoriesPresenter
    {
        ICategoriesView view; 
        IModelCategories model;

        public CategoriesPresenter(ICategoriesView view)
        {
            this.view = view;
            this.view.AddingCategoryName += AddNewCategoryToDB;
            this.view.DeletingCategory += DelCategoryInDB;
            this.view.UpdatingCategory += UpdateCategoryInDB;

            model = DbCategory.GetInstance();
            model.ModelCategoryUpdated += RefreshViewer;
        }

        /// <summary>
        /// Получение данных о категориях из БД
        /// </summary>
        public void LoadCategories()
        {
            List<Category> categories = model.GetCategories();
            view.ShowCathegories(categories);
        }

        /// <summary>
        /// Добавить новую категорию в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="categoryName">Название новой, добавляемой категории</param>
        public void AddNewCategoryToDB(object sender, string categoryName)
        {
            model.AddNewCategory(categoryName);
        }


        /// <summary>
        /// Удалить категорию из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="category">Удаляемая категория</param>
        public void DelCategoryInDB(object sender, Category category)
        {
            model. DeleteCategory(category);
        }

        /// <summary>
        /// Изменить категорию в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="category">Категоря, которую надо изменить</param>
        public void UpdateCategoryInDB(object sender, Category category)
        {
            model.UpdateCategory(category);
        }

        /// <summary>
        /// Обновить форму пользоваетля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RefreshViewer(object sender, object e)
        {
            LoadCategories();
        }


    }
}
