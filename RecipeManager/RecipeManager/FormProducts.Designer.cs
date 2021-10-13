
namespace ViewerRecipeManager
{
    partial class FormProducts
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2DelPrduct = new System.Windows.Forms.Button();
            this.button3ChangeProduct = new System.Windows.Forms.Button();
            this.button1AddNewProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1ProductName = new System.Windows.Forms.TextBox();
            this.button3SelectPicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button2DelPrduct, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.button3ChangeProduct, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1ProductName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3SelectPicture, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1AddNewProduct, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 468);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button2DelPrduct
            // 
            this.button2DelPrduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2DelPrduct.Location = new System.Drawing.Point(400, 429);
            this.button2DelPrduct.MaximumSize = new System.Drawing.Size(190, 40);
            this.button2DelPrduct.Name = "button2DelPrduct";
            this.button2DelPrduct.Size = new System.Drawing.Size(181, 35);
            this.button2DelPrduct.TabIndex = 0;
            this.button2DelPrduct.Text = "Удалить";
            this.button2DelPrduct.UseVisualStyleBackColor = true;
            this.button2DelPrduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3ChangeProduct
            // 
            this.button3ChangeProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3ChangeProduct.Location = new System.Drawing.Point(657, 429);
            this.button3ChangeProduct.MaximumSize = new System.Drawing.Size(190, 40);
            this.button3ChangeProduct.Name = "button3ChangeProduct";
            this.button3ChangeProduct.Size = new System.Drawing.Size(181, 35);
            this.button3ChangeProduct.TabIndex = 1;
            this.button3ChangeProduct.Text = "Изменить";
            this.button3ChangeProduct.UseVisualStyleBackColor = true;
            this.button3ChangeProduct.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1AddNewProduct
            // 
            this.button1AddNewProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1AddNewProduct.Location = new System.Drawing.Point(144, 316);
            this.button1AddNewProduct.MaximumSize = new System.Drawing.Size(190, 40);
            this.button1AddNewProduct.Name = "button1AddNewProduct";
            this.button1AddNewProduct.Size = new System.Drawing.Size(181, 35);
            this.button1AddNewProduct.TabIndex = 6;
            this.button1AddNewProduct.Text = "Добавить продукт";
            this.button1AddNewProduct.UseVisualStyleBackColor = true;
            this.button1AddNewProduct.Click += new System.EventHandler(this.button1AddNewProduct_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ввод нового продукта:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Картинка:";
            // 
            // textBox1ProductName
            // 
            this.textBox1ProductName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1ProductName.Location = new System.Drawing.Point(131, 74);
            this.textBox1ProductName.Name = "textBox1ProductName";
            this.textBox1ProductName.Size = new System.Drawing.Size(181, 23);
            this.textBox1ProductName.TabIndex = 10;
            // 
            // button3SelectPicture
            // 
            this.button3SelectPicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3SelectPicture.Location = new System.Drawing.Point(131, 115);
            this.button3SelectPicture.MaximumSize = new System.Drawing.Size(190, 40);
            this.button3SelectPicture.Name = "button3SelectPicture";
            this.button3SelectPicture.Size = new System.Drawing.Size(181, 31);
            this.button3SelectPicture.TabIndex = 11;
            this.button3SelectPicture.Text = "Выбрать";
            this.button3SelectPicture.UseVisualStyleBackColor = true;
            this.button3SelectPicture.Click += new System.EventHandler(this.button3SelectPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(138, 163);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(193, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listView1, 2);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(361, 25);
            this.listView1.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.listView1.Name = "listView1";
            this.tableLayoutPanel1.SetRowSpan(this.listView1, 6);
            this.listView1.Size = new System.Drawing.Size(474, 391);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 468);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2DelPrduct;
        private System.Windows.Forms.Button button3ChangeProduct;
        private System.Windows.Forms.Button button1AddNewProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1ProductName;
        private System.Windows.Forms.Button button3SelectPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
    }
}