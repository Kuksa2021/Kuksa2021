using CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDB
{
    public class DbCategory: IModelCategories
    {
        DB context;
        private static DbCategory instance;

        /// <summary>
        /// Конструктор
        /// </summary>
        DbCategory()
        {
            this.context = DB.GetInstance();
            this.context.DBCategoryUpdated += CategoryUpdated;
        }

        /// <summary>
        /// Метод возвращает экземпляр класса DbCategory
        /// </summary>
        public static DbCategory GetInstance()
        {
            if (instance == null)
            {
                instance = new DbCategory();
            }
            return instance;
        }

        /// <summary>
        /// Метод вызывается при обновлении списка категорий в БД
        /// </summary>
        void CategoryUpdated(object obj, EventArgs er)
        {
            ModelCategoryUpdated?.Invoke(null, EventArgs.Empty);
        }


        public event EventHandler<EventArgs> ModelCategoryUpdated;
        public List<Category> GetCategories()
        {
            return context.Categories.ToList<Category>();
        }

        public void AddNewCategory(string categoryName)
        {
            Category cat = new Category { Name = categoryName };
            context.Categories.Add(cat);
            if (context.SaveChanges() > 0) context.OnCategoryUpdated();
            
        }

        public void DeleteCategory(Category category)
        {
            context.Categories.Remove(category);
            if (context.SaveChanges() > 0) context.OnCategoryUpdated(); 
            
        }

        public void UpdateCategory(Category category)
        {
            context.Categories.Update(category);
            if (context.SaveChanges() > 0) context.OnCategoryUpdated();
        }


    }
}
