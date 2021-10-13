using CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewerRecipeManager
{
    public partial class FormProductChange : Form
    {


        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="product">Редактируемый продукт</param>
        /// <param name="list">Списко продуктов в БД</param>
        /// <param name="checkName">Метод, проверяющий правильность ввода имени продукта</param>
        
        public FormProductChange(Product product, List<Product> list)
        {
            InitializeComponent();
            this.Product = product;
            textBox1Name.Text = product.Name;
            pictureBox1Picture.Image = product.Image;
            this.list = list;
        }



        /// <summary>
        /// Список продуктов
        /// </summary>
        List<Product> list;

        /// <summary>
        /// Текущий продукт
        /// </summary>
        internal Product Product { get; }
        
       

        //Нажатие кнопки "Выбрать изображение"
        private void button1SelectPicture_Click(object sender, EventArgs e)
        {
           FormProducts.LoadImage(pictureBox1Picture);
        }

        private void button2Save_Click(object sender, EventArgs e)
        {
            SaveNewDateToProduct();
        }


        /// <summary>
        /// Внести изменения в Product
        /// </summary>
        private void SaveNewDateToProduct()
        {
            if (textBox1Name.Text.Trim().ToUpper() != Product.Name.Trim().ToUpper())
            {

                string name = FormProducts.CheckProductName(textBox1Name, list);
                if (String.IsNullOrEmpty(name))
                {
                    DialogResult = DialogResult.Cancel;
                    return;
                }
                Product.Name = name;
            }
            Product.Image = pictureBox1Picture.Image;
            DialogResult = DialogResult.OK;
        }
    }
}
