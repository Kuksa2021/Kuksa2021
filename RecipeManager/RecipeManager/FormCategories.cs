using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonClasses;
using Presenter;
using ViewerRecipeManager;

namespace RecipeManager
{

    /// <summary>
    /// Интерфейс для окна
    /// </summary>
    

    public partial class FormCategories : Form , ICategoriesView
    {
        public FormCategories()
        {
            InitializeComponent();

            button1AddNewCategory.Click += AddNewCategoryToDB; //обработчик нажатия кнопки Добавить
            button2DelCategory.Click += DeleteCategoryFromDB;  //обработчик нажатия кнопки Удалить

            presenter = new CategoriesPresenter(this);
            LoadCategoriesListFromPresentr();
        }

        CategoriesPresenter presenter;
        List<Category> listCategories = new List<Category>();
        public string CategoryName { get; }
        public event EventHandler<string> AddingCategoryName;
        public event EventHandler<Category> DeletingCategory;
        public event EventHandler<Category> UpdatingCategory;



        //метод реализации интерфейса
        public void ShowCathegories(List<Category> categiries)
        {
            listCategories = categiries;
            ShowCathegoriesInListBox(listCategories, listBox1Categories);
        }

        public static void ShowCathegoriesInListBox(List<Category> categories, ListBox listBoxCategories)
        {
            listBoxCategories.DataSource = categories;
            listBoxCategories.DisplayMember = "Name";
            listBoxCategories.ValueMember = "Id";
        }


        void LoadCategoriesListFromPresentr()
        {
            presenter.LoadCategories();
        }


        string CheckCategoryName( TextBox textBoxCategoryName, List<Category> list)
        {
            string name = textBoxCategoryName.Text.Trim();
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Вы не ввели название категории!");
                textBoxCategoryName.Focus();
                return null;
            }
            

            if (list.FindIndex(x => x.Name.ToLower() == name.ToLower()) >= 0)
            {
                MessageBox.Show("Категория с таким названием уже существует!");
                textBoxCategoryName.Focus();
                return null;
            }

            return name;
        }





        /// <summary>
        /// Добавить новую категорию в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewCategoryToDB(object sender, EventArgs e)
        {
            string name=CheckCategoryName(textBox1NewCategory, listCategories);

            if (String.IsNullOrEmpty(name)) return;

            if (AddingCategoryName == null)
            {
                MessageBox.Show("В программе нет возможности добавить категорию!");
                return;
            }

            AddingCategoryName(this, name);
            textBox1NewCategory.Clear();
        }


        /// <summary>
        /// Проверяем выбрана ли категория в списке
        /// </summary>
        /// <returns></returns>
        bool CheckSelectedCategory()
        {
            if (listBox1Categories.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбрана ни одна категория в списке категорий!");
                return false;
            }
            return true;
        }


        /// <summary>
        /// Удалить категорию из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCategoryFromDB(object sender, EventArgs e)
        {
            if (!CheckSelectedCategory()) return;
            
            if (DeletingCategory==null)
            {
                MessageBox.Show("В программе нет возможности удалять категории!");
                return;
            }

            // получаем выделенную категорию
            Category category = (Category)listBox1Categories.SelectedItem;
            //int indexFilterCategory = category.Id;
            DeletingCategory?.Invoke(this, category);
        }

        /// <summary>
        /// Изменит название категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (!CheckSelectedCategory()) return;

            if (UpdatingCategory == null)
            {
                MessageBox.Show("В программе нет возможности изменить название категории!");
                return;
            }

            // получаем выделенную категорию
            Category category = (Category)listBox1Categories.SelectedItem;

            FormCategoryChange form = new FormCategoryChange(category, listCategories, CheckCategoryName);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel) return;

            UpdatingCategory?.Invoke(this, form.Category);
        }

        private void button1AddNewCategory_Click(object sender, EventArgs e)
        {

        }
    }








    
}
