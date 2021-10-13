using CommonClasses;
using Presenter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace ViewerRecipeManager
{
    public partial class FormProducts : Form, IProductsViewer
    {

        ProductsPresenter presenter;
        public event Action<string, Image> AddingNewProduct;
        public event EventHandler<int> DeletingProduct;
        public event EventHandler<Product> UpdatingProduct;

        /// <summary>
        /// Список продуктоа
        /// </summary>
        List<Product> products;


        /// <summary>
        /// Конструктоп
        /// </summary>
        public FormProducts()
        {
            InitializeComponent();
            presenter = new ProductsPresenter(this);
            LoadProductsListFromPresenter();
        }

        /// <summary>
        /// Загрузка файла, содержащего картинку
        /// </summary>
        /// <returns>Картинка</returns>
        protected static Image LoadFileFromDisk()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "";
            openFileDialog.Filter = "Image files (*.jpg,*.png,*.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return null;

            // получаем выбранный файл
            string filename = openFileDialog.FileName;

            return Image.FromFile(filename);
        }


        /// <summary>
        /// Загрузка картинки в PictueBox
        /// </summary>
        internal static void LoadImage(PictureBox pictureBox)
        {
            Image image = LoadFileFromDisk();
            if (image == null) return;
            pictureBox.Image = image; //Выводим картинку на экран
        }

        private void button3SelectPicture_Click(object sender, EventArgs e)
        {
            LoadImage(pictureBox1);
        }



        /// <summary>
        /// Проверка имени продукта
        /// </summary>
        /// <param name="textBoxProductyName">TextBox содержащий имя продукта</param>
        /// <param name="productList">Список продуктов</param>
        /// <returns></returns>
        internal static string CheckProductName(TextBox textBoxProductyName, List<Product> productList)
        {
            string name = textBoxProductyName.Text.Trim();
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Вы не ввели название продукта!");
                textBoxProductyName.Focus();
                return null;
            }


            if (productList.FindIndex(x => x.Name.ToLower() == name.ToLower()) >= 0)
            {
                MessageBox.Show("Продукт с таким названием уже существует!");
                textBoxProductyName.Focus();
                return null;
            }

            return name;
        }




        // Нажатие кнопки Добавить продукт
        private void button1AddNewProduct_Click(object sender, EventArgs e)
        {
            AddNewProduct();
        }


        /// <summary>
        /// Добавить новый продукт в БД
        /// </summary>
            private void AddNewProduct()
        { 
            string name = CheckProductName(textBox1ProductName, products);

            if (String.IsNullOrEmpty(name)) return;

            if (AddingNewProduct == null)
            {
                MessageBox.Show("В программе нет возможности добавить продукт!");
                return;
            }

            AddingNewProduct(textBox1ProductName.Text, pictureBox1.Image);
            
            textBox1ProductName.Clear(); //Очистили поля
            pictureBox1.Image = null;
        }



        /// <summary>
        /// Вывод списка продутов в ListView
        /// </summary>
        public static void ShowProductsInListView(List<Product> products, ListView listView)
        {

            listView.Clear();

            if (products == null) return;

            ImageList imageList = new ImageList(); //Создаём список картинок
            listView.SmallImageList = imageList;
            listView.LargeImageList = imageList;
            listView.StateImageList = imageList;

            imageList.ImageSize = new Size(64, 64); //размер картинок

            if (listView.Columns.Count == 0) listView.Columns.Add("Таблица продуктов:");
            listView.Columns[0].Width = listView.Width - 25; //ширина столбца


            for (int i = 0; i < products.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(); //Создаём объект для строки
                listViewItem.Text = products[i].Name;
                listViewItem.Tag = products[i].Id;//В тэге будем хранить ID продукта

                if (products[i].Image != null)                //если есть картинка
                {
                    imageList.Images.Add(products[i].Id.ToString(), products[i].Image);
                    listViewItem.ImageKey = products[i].Id.ToString();
                }

                listView.Items.Add(listViewItem);//добавить строку
            }
        }

        /// <summary>
        /// Загрузка списка продуктов из БД
        /// </summary>
        private void LoadProductsListFromPresenter()
        {
            presenter.LoadProducts();
        }

        /// <summary>
        /// Вывести на экран список продуктов
        /// </summary>
        /// <param name="products">Список продуктов</param>
        public void ShowProducts(List<Product> products)
        {
            this.products = products;
            ShowProductsInListView(products, listView1);
        }




        /// <summary>
        /// Проверяем выбран ли продукт в списке
        /// </summary>
        /// <returns></returns>
        int CheckSelectedProduct()
        {
            if (listView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Не выбрана ни один продукт в списке продуктов!");
                return -1;
            }
            return (int)listView1.SelectedItems[0].Tag; ;
        }


        //удалить
        private void button2_Click(object sender, EventArgs e)
        {
            DelProductFromDB();
        }

        /// <summary>
        /// Удалить продукт из БД
        /// </summary>
        void DelProductFromDB()
        { 
            int index = CheckSelectedProduct();
            if (index < 0) return;

            if (DeletingProduct == null)
            {
                MessageBox.Show("В программе нет возможности удалять продукты!");
                return;
            }

            DeletingProduct?.Invoke(this, index);
        }



        /// <summary>
        /// Нажатие кнопки "Изменить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            int id = CheckSelectedProduct();
            if (id < 0) return;

            if (UpdatingProduct == null)
            {
                MessageBox.Show("В программе нет возможности изменять продукты!");
                return;
            }

            Product product = products.First(x => x.Id == id);

            if (product == null) return;

            FormProductChange form = new FormProductChange(product, products);

            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel) return;

            UpdatingProduct?.Invoke(this, form.Product);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

