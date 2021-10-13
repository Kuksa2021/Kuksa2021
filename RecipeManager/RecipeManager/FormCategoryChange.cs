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
    public partial class FormCategoryChange : Form
    {
        public delegate string CheckCategoryName(TextBox textBoxCategoryName, List<Category> list);
        public FormCategoryChange(Category category, List<Category> list, CheckCategoryName CheckName)
        {
            InitializeComponent();
            this.Category = category;
            this.list = list;
            this.checkName = CheckName;

            textBox1CategoryName.Text = category.Name;
        }

        internal Category Category { get; }
        List<Category> list;
        CheckCategoryName checkName;
        private void button1Ok_Click(object sender, EventArgs e)
        {
            string name = checkName(textBox1CategoryName, list);
            if (String.IsNullOrEmpty(name))
            {
                DialogResult = DialogResult.Cancel;
                return;
            }

            if (Category.Name == name)
            {
                DialogResult = DialogResult.Cancel;
                return;
            }

            Category.Name = name;
            DialogResult = DialogResult.OK;
        }
    }
}
