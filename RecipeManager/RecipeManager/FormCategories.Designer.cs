
namespace RecipeManager
{
    partial class FormCategories
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
            this.textBox1NewCategory = new System.Windows.Forms.TextBox();
            this.button1AddNewCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1Categories = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2DelCategory = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название:";
            // 
            // textBox1NewCategory
            // 
            this.textBox1NewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1NewCategory.Location = new System.Drawing.Point(153, 106);
            this.textBox1NewCategory.Name = "textBox1NewCategory";
            this.textBox1NewCategory.Size = new System.Drawing.Size(174, 23);
            this.textBox1NewCategory.TabIndex = 1;
            // 
            // button1AddNewCategory
            // 
            this.button1AddNewCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1AddNewCategory.Location = new System.Drawing.Point(180, 148);
            this.button1AddNewCategory.Margin = new System.Windows.Forms.Padding(10);
            this.button1AddNewCategory.MaximumSize = new System.Drawing.Size(190, 40);
            this.button1AddNewCategory.Name = "button1AddNewCategory";
            this.button1AddNewCategory.Size = new System.Drawing.Size(120, 25);
            this.button1AddNewCategory.TabIndex = 2;
            this.button1AddNewCategory.Text = "Добавить";
            this.button1AddNewCategory.UseVisualStyleBackColor = true;
            this.button1AddNewCategory.Click += new System.EventHandler(this.button1AddNewCategory_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(78, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Добавление новых категорий.";
            // 
            // listBox1Categories
            // 
            this.listBox1Categories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1Categories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.listBox1Categories, 2);
            this.listBox1Categories.FormattingEnabled = true;
            this.listBox1Categories.ItemHeight = 15;
            this.listBox1Categories.Location = new System.Drawing.Point(350, 50);
            this.listBox1Categories.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.listBox1Categories.Name = "listBox1Categories";
            this.tableLayoutPanel1.SetRowSpan(this.listBox1Categories, 4);
            this.listBox1Categories.Size = new System.Drawing.Size(380, 302);
            this.listBox1Categories.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(485, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Список категорий:";
            // 
            // button2DelCategory
            // 
            this.button2DelCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2DelCategory.Location = new System.Drawing.Point(360, 377);
            this.button2DelCategory.MaximumSize = new System.Drawing.Size(190, 40);
            this.button2DelCategory.Name = "button2DelCategory";
            this.button2DelCategory.Size = new System.Drawing.Size(120, 25);
            this.button2DelCategory.TabIndex = 6;
            this.button2DelCategory.Text = "Удалить";
            this.button2DelCategory.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(570, 377);
            this.button3.MaximumSize = new System.Drawing.Size(190, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1NewCategory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1Categories, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2DelCategory, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.button3, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.button1AddNewCategory, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 427);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategories";
            this.Text = "Категории";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1NewCategory;
        private System.Windows.Forms.Button button1AddNewCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1Categories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2DelCategory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}