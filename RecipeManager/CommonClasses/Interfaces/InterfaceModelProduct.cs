using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CommonClasses
{

    /// <summary>
    /// Интерфес БД для продуктов
    /// </summary>

    public interface IModelProducts
    {
        /// <summary>
        /// Возвращает список продуктов из БД
        /// </summary>
        /// <returns></returns>
        List<Product> GetProducts();

        /// <summary>
        /// Добавить новы продукт в БД
        /// </summary>
        /// <param name="categoryName">Название добавляемой категории</param>
        void AddNewProduct(String Name, Image picture);


        /// <summary>
        /// Удалить продукт в БД
        /// </summary>
        /// <param name="id">id удаляемого продукта</param>
        void DeleteProduct(int id);

        /// <summary>
        /// Обновить продукт в БД
        /// </summary>
        /// <param name="product">Обновляемый продукт</param>
        void UpdateProduct(Product product);


        /// <summary>
        /// Событие, сообщающее что записи в БД о Продуктах Изменились 
        /// </summary>
        event EventHandler<EventArgs> ModelProductsUpdated;

    }

}
