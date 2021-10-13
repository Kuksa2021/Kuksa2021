using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CommonClasses
{
    /// <summary>
    /// Интерфейс класса, обеспечивающего вывод информации о продуктах на экран и взаимодействие с пользователем
    /// </summary>
    public interface IProductsViewer
    {
        /// <summary>
        /// Выводод списка продуктов на экран
        /// </summary>
        /// <param name="products"></param>
        void ShowProducts(List<Product> products);


        /// <summary>
        /// Событие. Ввод нового Продукта
        /// </summary>
        event Action<string, Image> AddingNewProduct;

        /// <summary>
        /// Событие. Удаление продукта с ID
        /// </summary>
        event EventHandler<int> DeletingProduct;

        /// <summary>
        /// Событие. Обновление продукта
        /// </summary>
        public event EventHandler<Product> UpdatingProduct;
    }
}
