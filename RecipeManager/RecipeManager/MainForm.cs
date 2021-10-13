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

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tabPage2Products_Enter(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //вставляем форму рецептов
            FormRecipies formRecipies = new FormRecipies();
            formRecipies.Dock = DockStyle.Fill;
            formRecipies.TopLevel = false;
            formRecipies.BackColor = tabControl1.TabPages["tabPage1Recipies"].BackColor;
            formRecipies.Show();
            tabControl1.TabPages["tabPage1Recipies"].Controls.Clear();
            tabControl1.TabPages["tabPage1Recipies"].Controls.Add(formRecipies);


            //вставляем форму продуктов
            FormProducts formProducts = new FormProducts();
            formProducts.Dock = DockStyle.Fill;
            formProducts.TopLevel = false;
            formProducts.BackColor = tabControl1.TabPages["tabPage2Products"].BackColor;
            formProducts.Show();
            tabControl1.TabPages["tabPage2Products"].Controls.Clear();
            tabControl1.TabPages["tabPage2Products"].Controls.Add(formProducts);

            //вставляем форму Категорий
            FormCategories formCategories = new FormCategories();
            formCategories.Dock = DockStyle.Fill;
            formCategories.TopLevel = false;
            formCategories.BackColor = tabControl1.TabPages["tabPage3Categories"].BackColor;
            formCategories.Show();
            tabControl1.TabPages["tabPage3Categories"].Controls.Clear();
            tabControl1.TabPages["tabPage3Categories"].Controls.Add(formCategories);
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpWindow help = new HelpWindow();
            help.ShowDialog();
        }

        private void StripMenuItemAboutProgramm_Click(object sender, EventArgs e)
        {
            About about= new About();
            about.ShowDialog();
        }

        /// <summary>
        /// Выбор меню - Файл - Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выходToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
