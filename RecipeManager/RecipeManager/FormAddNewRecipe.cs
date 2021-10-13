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
using ViewerRecipeManager;

namespace RecipeManager
{
    public partial class FormAddNewRecipe : Form
    {

        List<Category> categories;
        List<Product> products;
        public Recipe NewRecipe { get; protected set; }

        public FormAddNewRecipe(List<Category> categories, List<Product> products, Recipe reciveRecipe)
        {
            InitializeComponent();
            
            this.categories = categories;
            this.products = products;

            ShowMeasurementUnit(comboBox2MeasurementUnit);
            ShowCategories(this.categories, comboBox1Group);

            FormProducts.ShowProductsInListView(this.products, listView1Ingredients);
            listView1Ingredients.Items[0].Selected = true; //Выделить/выбрать первую строчку

            SetNewRecipe(reciveRecipe);
        }


        void SetNewRecipe(Recipe reciveRecipe)
        {
            if (reciveRecipe is null)
            {
                NewRecipe = new Recipe();
                return;
            }

            textBox1RecipeName.Text = reciveRecipe.Name;
            NewRecipe = reciveRecipe;
            RefreshDateGrid(NewRecipe, dataGridView1);
        }



        /// <summary>
        /// Выводит список единиц измерения
        /// </summary>
        /// <param name="comboBox">ComboBox в который будет выводится список единиц измерения</param>
        void ShowMeasurementUnit(ComboBox comboBox)
        {
            foreach (string name in Enum.GetNames(typeof(MeasurementUnit)))
            {
                comboBox.Items.Add(name);
            }
        }


        /// <summary>
        /// Выводит список категорий в ComboBox
        /// </summary>
        /// <param name="categories">Список категорий</param>
        /// <param name="comboBox"></param>
        void ShowCategories( List<Category> categories, ComboBox comboBox)
        {
            comboBox.DataSource = categories;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
            comboBox.SelectedIndex = 0; //Выделить/выбрать первую строчку
        }



        bool CheckInpuIngredient()
        {
            if (String.IsNullOrEmpty(textBox2Weight.Text))
            {
                MessageBox.Show("Вы не ввели вес/объём продукта!");
                textBox2Weight.Focus();
                return false;
            }

            if(!float.TryParse(textBox2Weight.Text, out float a))
            {
                MessageBox.Show("Вы некорректно ввели вес/объём продукта!");
                textBox2Weight.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(comboBox2MeasurementUnit.Text))
            {
                MessageBox.Show("Вы не ввели ед.измерения для веса/объёма продукта!");
                comboBox2MeasurementUnit.Focus();
                return false;
            }

            if (listView1Ingredients.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали продукт!");
                listView1Ingredients.Focus();
                return false;
            }

            return true;
        }


        /// <summary>
        /// Очистка, сброс полей ввода
        /// </summary>
        void ClearInputBoxs()
        {
            textBox2Weight.Clear();
            comboBox2MeasurementUnit.Text = "";
            listView1Ingredients.Focus();
        }


        /// <summary>
        /// Нажатие кнопки "Добавить ингредиент"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1AddIngedient_Click(object sender, EventArgs e)
        {
            if (!CheckInpuIngredient()) return;

            int index = (int)listView1Ingredients.SelectedItems[0].Tag;
            Product product = products.Find(x => x.Id == index);
            Ingredient ingredient = new Ingredient()
            {
                MeasurementUnit = comboBox2MeasurementUnit.Text,
                Product = product,
                Recipe = NewRecipe,
                Weight = float.Parse(textBox2Weight.Text)
            };
            NewRecipe.Ingradients.Add(ingredient);

            //FormRecipies.ShowIngredientsInDataGrid(newRecipe, dataGridView1);
            RefreshDateGrid(NewRecipe, dataGridView1);

            ClearInputBoxs();

            //recipe.Ingradients
        }


        /// <summary>
        /// Обновить DataGrid содержащий данные об ингредиентах
        /// </summary>
        /// <param name="recipe">Рецепт, ингредиенты которого выводятся в DataGrid</param>
        /// <param name="dataGridView">DataGrid в который выводятся ингредиенты</param>
        void RefreshDateGrid(Recipe recipe, DataGridView dataGridView)
        {
            FormRecipies.ShowIngredientsInDataGrid(recipe, dataGridView);
        }


        private void button2SaveRecipe_Click(object sender, EventArgs e)
        {
            if (NewRecipe.Ingradients.Count<=0)
            {
                MessageBox.Show("Нет ингредиентов!");
                return;
            }

            if ( String.IsNullOrEmpty(textBox1RecipeName.Text))
            {
                MessageBox.Show("Не ввели название рецепта!");
                return;
            }

            if(comboBox1Group.SelectedItem is null)
            {
                MessageBox.Show("Не выбрали группу!");
                return;
            }

            NewRecipe.Name = textBox1RecipeName.Text;
            NewRecipe.Category = (Category)comboBox1Group.SelectedItem;

            DialogResult = DialogResult.OK;
        }

        private void button4DelIngredient_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Ингредиент не выбран!");
                return;
            }

            var rowIndex= dataGridView1.SelectedCells[0].RowIndex;  //индекс выбранной строки

            var ProductID =(int)dataGridView1.Rows[rowIndex].Cells["ProductID"].Value; //ID выбранного продукта
            NewRecipe.Ingradients.RemoveAll(x => x.Product.Id == ProductID);           //удаляем выбранный продукт
            RefreshDateGrid(NewRecipe, dataGridView1);
        }
    }
}
