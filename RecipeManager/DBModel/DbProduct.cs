using CommonClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDB
{
   public class DbProduct: IModelProducts
    {
        DB context;
        private static DbProduct instance;

        public event EventHandler<EventArgs> ModelProductsUpdated;


        /// <summary>
        /// Конструктор
        /// </summary>
        DbProduct()
        {
            this.context = DB.GetInstance();
            this.context.DBProductsUpdated += ProductUpdated;
        }

        /// <summary>
        /// Метод возвращает экземпляр класса DbProduct
        /// </summary>
        /// <returns></returns>
        public static DbProduct GetInstance()
        {
            if (instance == null)
            {
                instance = new DbProduct();
            }
            return instance;
        }

        /// <summary>
        /// Метод вызывается при обновлении списка продуктов в БД
        /// </summary>
        void ProductUpdated(object obj, EventArgs er)
        {
            ModelProductsUpdated?.Invoke(null, EventArgs.Empty);
        }

        public List<Product> GetProducts()
        {
            return context.Products.Include(x => x.Ingredient).ToList<Product>();
        }
        public void AddNewProduct(String Name, Image picture)
        {
            Product product = new Product { Name = Name, Image = picture };
            context.Products.Add(product);
            if (context.SaveChanges() > 0) context.OnProductUpdated(); 
        }

        public void DeleteProduct(int id)
        {
            Product product = context.Products.First(x => x.Id == id);
            context.Products.Remove(product);
            if (context.SaveChanges() > 0) context.OnProductUpdated();
        }


        public void UpdateProduct(Product product)
        {
            context.Products.Update(product);
            if (context.SaveChanges() > 0) context.OnProductUpdated();
        }


    }
}
