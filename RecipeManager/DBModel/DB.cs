using CommonClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModelDB
{

    //public class DB : DbContext, IModelCategories, IModelProducts, IModelRecipies
    public class DB : DbContext
    {
        /// <summary>
        /// Событие. Список категорий изменился.
        /// </summary>
        public event EventHandler<EventArgs> DBCategoryUpdated;

        /// <summary>
        /// Событие. Список продуктов изменился.
        /// </summary>
        public event EventHandler<EventArgs> DBProductsUpdated;

        /// <summary>
        /// Событие. Список рецептов изменился.
        /// </summary>
        public event EventHandler<EventArgs> DBRecipeUpdated;


        private static DB instance;

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipies { get; set; }

        private DB()
        {
        }


        /// <summary>
        /// Метод гарантирует, что для класса DB будет создан только один объект
        /// </summary>
        /// <returns>Возвращает объект DB</returns>
        public static DB GetInstance()
        {
            if (instance == null)
            {
                instance = new DB();

                if( instance.Database.EnsureCreated()) SaveDatesToNullDB.SaveDatesToDB(instance);
                
                //instance.Database.EnsureDeleted();
                //instance.Database.EnsureCreated();
                //SaveDatesToNullDB.SaveDatesToDB(instance);
            }
            return instance;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string onString = "Filename=myDb.db3";
                optionsBuilder.UseSqlite(onString, null);
            }
        }

        /// <summary>
        /// Информируем подписчиков на событие, что список категорий изменился
        /// </summary>
        public void OnCategoryUpdated()
        {
            DBCategoryUpdated?.Invoke(null, EventArgs.Empty);
        }

        /// <summary>
        /// Информируем подписчиков на событие, что список продуктов изменился
        /// </summary>
        public void OnProductUpdated()
        {
            DBProductsUpdated?.Invoke(null, EventArgs.Empty);
        }

        /// <summary>
        /// Информируем подписчиков на событие, что список рецептов изменился
        /// </summary>
        public void OnRecipeUpdated()
        {
            DBRecipeUpdated?.Invoke(null, EventArgs.Empty);
        }

        
    }
}
