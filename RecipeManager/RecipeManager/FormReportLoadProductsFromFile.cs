using CommonClasses;
using RecipeManager;
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
    public partial class FormReportLoadProductsFromFile : Form
    {
        public FormReportLoadProductsFromFile(List<Recipe> addedRecipies,List<Recipe> notAddedRecipies,
            List<Product> addedProducts,List<Category> addedCategories)
        {
            InitializeComponent();
            ShowAll(addedRecipies, notAddedRecipies, addedProducts, addedCategories);
        }


        void ShowAll(List<Recipe> addedRecipies, List<Recipe> notAddedRecipies, List<Product> addedProducts, List<Category> addedCategories)
        {
            FormCategories.ShowCathegoriesInListBox(addedCategories, listBox1Categories);
            if (listBox1Categories.Items.Count>0) listBox1Categories.SelectedIndex = 0; //Выделить/выбрать первую строчку


            FormProducts.ShowProductsInListView(addedProducts, listView1);
            if(listView1.Items.Count>0) listView1.Items[0].Selected = true; //Выделить/выбрать первую строчку


            //Выводим список добавленных рецептов в БД
            listBox1Recipies.DataSource = addedRecipies;
            listBox1Recipies.DisplayMember = "Name";
            listBox1Recipies.ValueMember = "Id";

            //Выводим список недобавленных рецептов в БД, т.к. рецепты с такими названиюями уже есть в БД
            listBox1notAddedRecipies.DataSource = notAddedRecipies;
            listBox1notAddedRecipies.DisplayMember = "Name";
            listBox1notAddedRecipies.ValueMember = "Id";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
