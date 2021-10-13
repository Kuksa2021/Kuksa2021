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
using Presenter;
using RecipeManager;
using ModelDB.Properties;

namespace ViewerRecipeManager
{
    public partial class FormRecipies : Form, IRecipesViewer
    {
        List<Recipe> recipes;
        List<Category> categories;
        List<Product> products;

        public FormRecipies()
        {
            InitializeComponent();
            presenter = new RecipiesPresenter(this);
            GetDBRecipiesFromPresener();
        }



        RecipiesPresenter presenter;
        public event EventHandler<Recipe> DeletingRecipy;
        public event EventHandler<Recipe> AddingRecipy;
        public event EventHandler<Recipe> UpdatingRecipy;
        //public event EventHandler< List<Recipe>> SaveRecipies;

        public event Action<List<Recipe>, string> SaveRecipiesToFile;
        public event Action<string> LoadRecipiesFromFile;


        void GetDBRecipiesFromPresener()
        {
            presenter.GetRecipeisFromDB();
        }


        /// <summary>
        /// Экземпляр класса Produck, используется для вывода строки, с содержимым "Поиск по всем продуктам" 
        /// </summary>
        /// <returns></returns>
        static Product GetProductForAllFind()
        {
            Product allProduct=null;

            if (allProduct == null)
            {
                allProduct = new Product()
                {
                    Id = 0,
                    Name = "Поиск по всем продуктам",
                    Image = Resources.allProducts,
                    Ingredient = null
                }; 
            }
            return allProduct;
        }


        /// <summary>
        /// Экземпляр класса Category, используется для вывода строки, с содержимым "Поиск во всех категориях" 
        /// </summary>
        static Category GetCategoryForAllFind()
        {
           Category allCategory = null;

            if (allCategory == null)
            {
                allCategory= new Category()
                {
                Id = 0,
                Name = "Поиск во всех категориях",
                Recipe = null
                };
            }
            return allCategory;
        }


        /// <summary>
        /// Вывод рецептов
        /// </summary>
        /// <param name="_recipes"></param>
        /// <param name="_listCategories"></param>
        /// <param name="_products"></param>
        public void ShowRecipies(List<Recipe> _recipes, List<Category> _listCategories, List<Product> _products)
        {
            recipes = _recipes;
            categories = _listCategories;
            products = _products;

            //Выводим список категорий
            categories.Insert(0, GetCategoryForAllFind());

            FormCategories.ShowCathegoriesInListBox(categories, listBox1Categories);
            listBox1Categories.SelectedIndex = 0; //Выделить/выбрать первую строчку

            //Выводим список продуктов
            products.Insert(0, GetProductForAllFind()); //Вставили на первое место

            FormProducts.ShowProductsInListView(products, listView1);
            listView1.Items[0].Selected = true; //Выделить/выбрать первую строчку

            RecipiesFilter();
        }


        /// <summary>
        /// Фильтрация рецептов по продуктам и категориям
        /// </summary>
        private void RecipiesFilter()
        {
            //1. фильтруем по КАТЕГОРИИ
            // получаем выделенную категорию
            Category category = (Category)listBox1Categories.SelectedItem;
            int indexFilterCategory = category.Id;

            List<Recipe> filteredRecipies = null;
            //if (indexFilterCategory == 0) filteredRecipies = recipes;
            if (indexFilterCategory == GetCategoryForAllFind().Id) filteredRecipies = recipes;
            else
            {
                filteredRecipies = recipes.Where(x => x.CategoryID == indexFilterCategory).ToList();
            }


            //2.Фильтруем по ПРОДУКТУ
            if (listView1.SelectedItems.Count != 0)
            {
                int indexFilteredProduct = (int)listView1.SelectedItems[0].Tag;
                //if (indexFilteredProduct != 0)
                if (indexFilteredProduct != GetProductForAllFind().Id)
                {
                    filteredRecipies =
                        filteredRecipies.Where(x => x.Ingradients.Any(y => y.ProductId == indexFilteredProduct)).ToList();
                }
            }

            ShowFilteredRecipies(filteredRecipies);
        }


        /// <summary>
        /// Вывод рецептов на экран
        /// </summary>
        /// <param name="filteredRecipies"></param>
        void ShowFilteredRecipies(List<Recipe> filteredRecipies)
        {
            //Выводим список рецептов
            listBox1Recipies.DataSource = filteredRecipies;
            listBox1Recipies.DisplayMember = "Name";
            listBox1Recipies.ValueMember = "Id";
            ShowIngradients();
        }


        /// <summary>
        /// Фильтрация рецептов по названию
        /// </summary>
        void FilterByName()
        {
            string findingName = textBox1NameForFind.Text;
            System.Media.SystemSounds.Beep.Play();

            List<Recipe> filteredRecipies = recipes.Where(x => x.Name.ToUpper().Contains(findingName.ToUpper()) ==true).ToList();
            ShowFilteredRecipies(filteredRecipies);
        }

        /// <summary>
        /// Ввод нового или редактирование выбранного рецепта
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>

        private Recipe NewEditRecipe(Recipe recipe)
        {

            List<Category> withoutAllCategory = categories.Where(x => x.Id != GetCategoryForAllFind().Id).ToList();
            List<Product> withoutAllProduct = products.Where(x => x.Id != GetProductForAllFind().Id).ToList();

            FormAddNewRecipe formAddNewRecipe = new FormAddNewRecipe(withoutAllCategory, withoutAllProduct, recipe);
            formAddNewRecipe.ShowDialog();

            if (formAddNewRecipe.DialogResult == DialogResult.Cancel) return null;

            // получаем введённый пользователем новый рецепт
            return formAddNewRecipe.NewRecipe;

            //AddRecipy?.Invoke(this, recipe);
        }


        /// <summary>
        /// Добавить новый рецепт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1AddNewRecipe_Click(object sender, EventArgs e)
        {
            if (AddingRecipy == null)
            {
                MessageBox.Show("В программе нет возможности добавлять рецепты!");
                return;
            }
            Recipe addedRecipe = NewEditRecipe(null);

            if (addedRecipe != null) AddingRecipy?.Invoke(this, addedRecipe);
        }



        /// <summary>
        /// Нажатие кнопки "Изменить рецепт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3Edit_Click(object sender, EventArgs e)
        {
            if (UpdatingRecipy == null)
            {
                MessageBox.Show("В программе нет возможности изменять рецепты!");
                return;
            }

            if (listBox1Recipies.SelectedItem is null)
            {
                MessageBox.Show("Рецепт не выбран!");
                return; //Если ни один рецепт не выбран, сразу выходим
            }

            Recipe selectedRecipe = (Recipe)listBox1Recipies.SelectedItem; // получаем выделенный рецепт
            //int indexFilterCategory = category.Id;
            
            Recipe  editRecipe=  NewEditRecipe(selectedRecipe);

            if (editRecipe!=null) UpdatingRecipy?.Invoke(this, editRecipe);
        }

        //выбор другой строчки в списке рецептов
        private void listBox1Recipies_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowIngradients();
        }



        /// <summary>
        /// Выводим ингредиенты в DataGridView
        /// </summary>
        /// <param name="recipe">Рецепт, ингредиенты которого выводятся</param>
        /// <param name="dataGridView">dataGridView в который выводим игредиенты</param>
        public static void ShowIngredientsInDataGrid(Recipe recipe, DataGridView dataGridView)
        {
            var lines = (from item in recipe.Ingradients
                         select new
                         {
                             ProductID=item.Product.Id,
                             ProductName = item.Product.Name,
                             ProductImage = item.Product.Image,
                             Weight = item.Weight,
                             MeasurementUnit = item.MeasurementUnit
                         }).ToList();


            //DataGrid
            dataGridView.DataSource = lines;

            int imageIndex = dataGridView.Columns["ProductImage"].Index;

            dataGridView.Columns["ProductID"].Visible = false;
            dataGridView.Columns["ProductName"].HeaderText = "Название";
            dataGridView.Columns[imageIndex].HeaderText = "Изображение";
            dataGridView.Columns["Weight"].HeaderText = "кол.";
            dataGridView.Columns["MeasurementUnit"].HeaderText = "ед.изм.";

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;


            ((DataGridViewImageColumn)dataGridView.Columns[imageIndex]).ImageLayout
                    = DataGridViewImageCellLayout.Zoom;
        }


        /// <summary>
        ///  Вывод ингредиентов выбронного рецепта
        /// </summary>
        private void ShowIngradients()
        {
            if (listBox1Recipies.Items.Count > 0)
            {
                // получаем весь выделенный объект
                Recipe recipe = (Recipe)listBox1Recipies.SelectedItem;
                textBox1Description.Text = recipe.Description; //Выводим описание

                ShowIngredientsInDataGrid(recipe, dataGridView1Ingredients);
            }
            else
            {
                textBox1Description.Clear();
                dataGridView1Ingredients.DataSource = null;
            }
        }

        //нажатие кнопки найти
        private void button4Find_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            RecipiesFilter();
        }

        private void FormRecipes_Load(object sender, EventArgs e)
        {
        }


        /// <summary>
        /// Проверяем выбран ли рецепт в списке
        /// </summary>
        /// <returns></returns>
        bool CheckSelectedRecipe()
        {
            if (listBox1Recipies.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран ни один рецепт в списке рецептов!");
                return false;
            }
            return true;
        }


        //Нажатие кнопки "Удалить рецепт"
        private void button2Del_Click(object sender, EventArgs e)
        {
            if (!CheckSelectedRecipe()) return;

            if (DeletingRecipy == null)
            {
                MessageBox.Show("В программе нет возможности удалять рецепты!");
                return;
            }

            // получаем выделенный рецепт
            Recipe recipe = (Recipe)listBox1Recipies.SelectedItem;
            DeletingRecipy?.Invoke(this, recipe);
        }


        /// <summary>
        /// Нажаты кнопка "Сохранить выбранный рецепт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button21SaveOne_Click(object sender, EventArgs e)
        {
            if (!CheckSelectedRecipe()) return;
            
            // получаем выделенный рецепт
            Recipe recipe = (Recipe)listBox1Recipies.SelectedItem;
            SaveRecipe(new List<Recipe> { recipe });
        }



        /// <summary>
        /// Нажаты кнопка "Сохранить все"
        /// </summary>
        private void button22SaveAll_Click(object sender, EventArgs e)
        {
            if (listBox1Recipies.Items.Count<=0)
            {
                MessageBox.Show("Нет рецептов в списке рецептов!");
                return;
            }

            List<Recipe> recipies = new List<Recipe>();

            // перебираем все рецепт
            foreach (var item  in listBox1Recipies.Items)
            {
                Recipe recipe = new Recipe();
                recipe = (Recipe)item;
                recipies.Add(recipe);
            };
                
            SaveRecipe(recipies);
        }


        /// <summary>
        /// Сохранить список рецептов в файле
        /// </summary>
        /// <param name="recipies"></param>
        void SaveRecipe(List<Recipe> recipies)
        {
            if (SaveRecipiesToFile == null)
            {
                MessageBox.Show("В программе нет возможности сохранять рецепты!");
                return;
            }

            string fileName = SelectFileForSave();
            if ( !String.IsNullOrEmpty(fileName)) SaveRecipiesToFile?.Invoke(recipies, fileName);

        }

        /// <summary>
        /// Выбираем/создаём файл на диске, в который будем записывать рецепты
        /// </summary>
        /// <returns>Имя файла</returns>
        string SelectFileForSave()
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "XML files(*.xml)|*.xml|Txt files(*.txt)|*.txt|All files(*.*)|*.*";
            
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return String.Empty;
            
            return saveFile.FileName; // получаем выбранный файл
        }



        /// <summary>
        ///  Загрузить рецепты из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5LoadFromFile_Click(object sender, EventArgs e)
        {
            if (LoadRecipiesFromFile == null)
            {
                MessageBox.Show("В программе нет возможности загружать рецепты из файла!");
                return;
            }

            string fileName = SelectFileForLoad();
            if (!String.IsNullOrEmpty(fileName))
            {
                LoadRecipiesFromFile?.Invoke(fileName);
                
            }
        }

        /// <summary>
        /// Вывод рецептов прочитанных из файла
        /// </summary>
        public void ShowRezultLoadingRecipiesFromFile(
             in List<Recipe> addedRecipies,
             in List<Recipe> notAddedRecipies,
             in List<Product> addedProducts,
             in List<Category> addedCategories)
        {

            FormReportLoadProductsFromFile report = 
                new FormReportLoadProductsFromFile(addedRecipies,notAddedRecipies,addedProducts,addedCategories);
            report.ShowDialog();
        }




        /// <summary>
        /// Выбираем файл на диске, из которого будем считывать рецепты
        /// </summary>
        /// <returns>Имя файла</returns>
        string SelectFileForLoad()
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "XML files(*.xml)|*.xml|Txt files(*.txt)|*.txt|All files(*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.Cancel)
                return String.Empty;

            return openFile.FileName; // получаем выбранный файл
        }

        //Нажатие кнопки Найти
        private void button1ByName_Click(object sender, EventArgs e)
        {
            FilterByName();
            listBox1Recipies.Update();
        }
    }
}
