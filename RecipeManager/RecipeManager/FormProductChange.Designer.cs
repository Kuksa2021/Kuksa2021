
namespace ViewerRecipeManager
{
    partial class FormProductChange
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
            this.textBox1Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1Picture = new System.Windows.Forms.PictureBox();
            this.button1SelectPicture = new System.Windows.Forms.Button();
            this.button2Save = new System.Windows.Forms.Button();
            this.button3Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // textBox1Name
            // 
            this.textBox1Name.Location = new System.Drawing.Point(192, 83);
            this.textBox1Name.Name = "textBox1Name";
            this.textBox1Name.Size = new System.Drawing.Size(322, 23);
            this.textBox1Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Изображение:";
            // 
            // pictureBox1Picture
            // 
            this.pictureBox1Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1Picture.Location = new System.Drawing.Point(192, 141);
            this.pictureBox1Picture.Name = "pictureBox1Picture";
            this.pictureBox1Picture.Size = new System.Drawing.Size(169, 126);
            this.pictureBox1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1Picture.TabIndex = 3;
            this.pictureBox1Picture.TabStop = false;
            // 
            // button1SelectPicture
            // 
            this.button1SelectPicture.Location = new System.Drawing.Point(192, 288);
            this.button1SelectPicture.Name = "button1SelectPicture";
            this.button1SelectPicture.Size = new System.Drawing.Size(169, 23);
            this.button1SelectPicture.TabIndex = 4;
            this.button1SelectPicture.Text = "Выбрать изображение";
            this.button1SelectPicture.UseVisualStyleBackColor = true;
            this.button1SelectPicture.Click += new System.EventHandler(this.button1SelectPicture_Click);
            // 
            // button2Save
            // 
            this.button2Save.Location = new System.Drawing.Point(182, 376);
            this.button2Save.Name = "button2Save";
            this.button2Save.Size = new System.Drawing.Size(115, 23);
            this.button2Save.TabIndex = 5;
            this.button2Save.Text = "Сохранить";
            this.button2Save.UseVisualStyleBackColor = true;
            this.button2Save.Click += new System.EventHandler(this.button2Save_Click);
            // 
            // button3Cancel
            // 
            this.button3Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3Cancel.Location = new System.Drawing.Point(345, 376);
            this.button3Cancel.Name = "button3Cancel";
            this.button3Cancel.Size = new System.Drawing.Size(115, 23);
            this.button3Cancel.TabIndex = 6;
            this.button3Cancel.Text = "Отмена";
            this.button3Cancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вы можете изменить информацию о продукте:";
            // 
            // FormProductChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3Cancel);
            this.Controls.Add(this.button2Save);
            this.Controls.Add(this.button1SelectPicture);
            this.Controls.Add(this.pictureBox1Picture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1Name);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 450);
            this.Name = "FormProductChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать продукт";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1Picture;
        private System.Windows.Forms.Button button1SelectPicture;
        private System.Windows.Forms.Button button2Save;
        private System.Windows.Forms.Button button3Cancel;
        private System.Windows.Forms.Label label3;
    }
}