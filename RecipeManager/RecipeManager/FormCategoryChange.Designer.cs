
namespace ViewerRecipeManager
{
    partial class FormCategoryChange
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
            this.button1Ok = new System.Windows.Forms.Button();
            this.button2Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1CategoryName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1Ok
            // 
            this.button1Ok.Location = new System.Drawing.Point(156, 192);
            this.button1Ok.Name = "button1Ok";
            this.button1Ok.Size = new System.Drawing.Size(75, 23);
            this.button1Ok.TabIndex = 0;
            this.button1Ok.Text = "Сохранить";
            this.button1Ok.UseVisualStyleBackColor = true;
            this.button1Ok.Click += new System.EventHandler(this.button1Ok_Click);
            // 
            // button2Cancel
            // 
            this.button2Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2Cancel.Location = new System.Drawing.Point(263, 191);
            this.button2Cancel.Name = "button2Cancel";
            this.button2Cancel.Size = new System.Drawing.Size(75, 23);
            this.button2Cancel.TabIndex = 1;
            this.button2Cancel.Text = "Отмена";
            this.button2Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Внесите изменения в название категории:";
            // 
            // textBox1CategoryName
            // 
            this.textBox1CategoryName.Location = new System.Drawing.Point(34, 102);
            this.textBox1CategoryName.Name = "textBox1CategoryName";
            this.textBox1CategoryName.Size = new System.Drawing.Size(402, 23);
            this.textBox1CategoryName.TabIndex = 3;
            // 
            // FormCategoryChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.textBox1CategoryName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2Cancel);
            this.Controls.Add(this.button1Ok);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "FormCategoryChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование названия категории";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Ok;
        private System.Windows.Forms.Button button2Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1CategoryName;
    }
}