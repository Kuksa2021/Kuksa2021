
namespace RecipeManager
{
    partial class FormAddNewRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1RecipeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1Group = new System.Windows.Forms.ComboBox();
            this.listView1Ingredients = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2MeasurementUnit = new System.Windows.Forms.ComboBox();
            this.button1AddIngedient = new System.Windows.Forms.Button();
            this.button2SaveRecipe = new System.Windows.Forms.Button();
            this.button3Cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4DelIngredient = new System.Windows.Forms.Button();
            this.textBox2Weight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название рецепта:";
            // 
            // textBox1RecipeName
            // 
            this.textBox1RecipeName.Location = new System.Drawing.Point(599, 32);
            this.textBox1RecipeName.Name = "textBox1RecipeName";
            this.textBox1RecipeName.Size = new System.Drawing.Size(276, 23);
            this.textBox1RecipeName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Группа:";
            // 
            // comboBox1Group
            // 
            this.comboBox1Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1Group.FormattingEnabled = true;
            this.comboBox1Group.Location = new System.Drawing.Point(599, 76);
            this.comboBox1Group.Name = "comboBox1Group";
            this.comboBox1Group.Size = new System.Drawing.Size(276, 23);
            this.comboBox1Group.TabIndex = 3;
            // 
            // listView1Ingredients
            // 
            this.listView1Ingredients.HideSelection = false;
            this.listView1Ingredients.Location = new System.Drawing.Point(118, 116);
            this.listView1Ingredients.MultiSelect = false;
            this.listView1Ingredients.Name = "listView1Ingredients";
            this.listView1Ingredients.Size = new System.Drawing.Size(276, 232);
            this.listView1Ingredients.TabIndex = 4;
            this.listView1Ingredients.UseCompatibleStateImageBehavior = false;
            this.listView1Ingredients.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Продукты:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вес/объём:";
            // 
            // comboBox2MeasurementUnit
            // 
            this.comboBox2MeasurementUnit.FormattingEnabled = true;
            this.comboBox2MeasurementUnit.Location = new System.Drawing.Point(118, 392);
            this.comboBox2MeasurementUnit.Name = "comboBox2MeasurementUnit";
            this.comboBox2MeasurementUnit.Size = new System.Drawing.Size(276, 23);
            this.comboBox2MeasurementUnit.TabIndex = 7;
            // 
            // button1AddIngedient
            // 
            this.button1AddIngedient.Location = new System.Drawing.Point(170, 430);
            this.button1AddIngedient.Name = "button1AddIngedient";
            this.button1AddIngedient.Size = new System.Drawing.Size(153, 23);
            this.button1AddIngedient.TabIndex = 8;
            this.button1AddIngedient.Text = "Добавить ингредиент";
            this.button1AddIngedient.UseVisualStyleBackColor = true;
            this.button1AddIngedient.Click += new System.EventHandler(this.button1AddIngedient_Click);
            // 
            // button2SaveRecipe
            // 
            this.button2SaveRecipe.Location = new System.Drawing.Point(566, 476);
            this.button2SaveRecipe.Name = "button2SaveRecipe";
            this.button2SaveRecipe.Size = new System.Drawing.Size(125, 23);
            this.button2SaveRecipe.TabIndex = 9;
            this.button2SaveRecipe.Text = "Сохранить рецепт";
            this.button2SaveRecipe.UseVisualStyleBackColor = true;
            this.button2SaveRecipe.Click += new System.EventHandler(this.button2SaveRecipe_Click);
            // 
            // button3Cancel
            // 
            this.button3Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3Cancel.Location = new System.Drawing.Point(718, 476);
            this.button3Cancel.Name = "button3Cancel";
            this.button3Cancel.Size = new System.Drawing.Size(125, 23);
            this.button3Cancel.TabIndex = 10;
            this.button3Cancel.Text = "Отмена";
            this.button3Cancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(445, 138);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(482, 251);
            this.dataGridView1.TabIndex = 11;
            // 
            // button4DelIngredient
            // 
            this.button4DelIngredient.Location = new System.Drawing.Point(611, 408);
            this.button4DelIngredient.Name = "button4DelIngredient";
            this.button4DelIngredient.Size = new System.Drawing.Size(145, 23);
            this.button4DelIngredient.TabIndex = 12;
            this.button4DelIngredient.Text = "Удалить ингредиент";
            this.button4DelIngredient.UseVisualStyleBackColor = true;
            this.button4DelIngredient.Click += new System.EventHandler(this.button4DelIngredient_Click);
            // 
            // textBox2Weight
            // 
            this.textBox2Weight.Location = new System.Drawing.Point(118, 354);
            this.textBox2Weight.Name = "textBox2Weight";
            this.textBox2Weight.Size = new System.Drawing.Size(276, 23);
            this.textBox2Weight.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "ед.измерения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ингредиенты:";
            // 
            // FormAddNewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2Weight);
            this.Controls.Add(this.button4DelIngredient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3Cancel);
            this.Controls.Add(this.button2SaveRecipe);
            this.Controls.Add(this.button1AddIngedient);
            this.Controls.Add(this.comboBox2MeasurementUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1Ingredients);
            this.Controls.Add(this.comboBox1Group);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1RecipeName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddNewRecipe";
            this.Text = "Состав нового рецепта";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1RecipeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1Group;
        private System.Windows.Forms.ListView listView1Ingredients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2MeasurementUnit;
        private System.Windows.Forms.Button button1AddIngedient;
        private System.Windows.Forms.Button button2SaveRecipe;
        private System.Windows.Forms.Button button3Cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4DelIngredient;
        private System.Windows.Forms.TextBox textBox2Weight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}