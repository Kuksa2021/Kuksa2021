using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;
using ModelDB;
using System.Drawing;


namespace Presenter
{

    /// <summary>
    /// Класс обеспечивает взаимодействие м/у БД и классом, обеспечивабщим взаимодействие пользователя с продуктами
    /// </summary>
    public class ProductsPresenter
    {
        IProductsViewer viewer;
        IModelProducts model;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="viewer"></param>
        public ProductsPresenter(IProductsViewer viewer)
        {
            this.viewer = viewer;
            this.viewer.AddingNewProduct += SaveNewProductToDB; //подписываемся на события
            this.viewer.DeletingProduct += DelDroductInDB;
            this.viewer.UpdatingProduct += UpdateProductInDB;

            model = DbProduct.GetInstance();
            model.ModelProductsUpdated += RefreshViewer;
        }


        /// <summary>
        /// Получение данных о продуктах из БД
        /// </summary>
        public void LoadProducts()
        {
            var list = model.GetProducts();
            viewer.ShowProducts(list);
        }


        //Action<string, Image> SetNewProduct;
        public void SaveNewProductToDB(string productName, Image image)
        {
            model.AddNewProduct(productName, image);
        }


        /// <summary>
        /// Удалить продукт из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="category">Удаляемая категория</param>
        public void DelDroductInDB(object sender, int id)
        {
            model.DeleteProduct(id);
        }


        /// <summary>
        /// Изменить продукт в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="product">Продукт, которую надо изменить</param>
        public void UpdateProductInDB(object sender, Product product)
        {
            model.UpdateProduct(product);
        }



        /// <summary>
        /// Обновить форму пользоваетля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RefreshViewer(object sender, object e)
        {
            LoadProducts();
        }
    }

}
