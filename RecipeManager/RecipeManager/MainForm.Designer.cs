
namespace RecipeManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1Recipies = new System.Windows.Forms.TabPage();
            this.tabPage2Products = new System.Windows.Forms.TabPage();
            this.tabPage3Categories = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemAboutProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1Recipies);
            this.tabControl1.Controls.Add(this.tabPage2Products);
            this.tabControl1.Controls.Add(this.tabPage3Categories);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 687);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1Recipies
            // 
            this.tabPage1Recipies.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage1Recipies.Location = new System.Drawing.Point(4, 24);
            this.tabPage1Recipies.Name = "tabPage1Recipies";
            this.tabPage1Recipies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Recipies.Size = new System.Drawing.Size(1076, 659);
            this.tabPage1Recipies.TabIndex = 0;
            this.tabPage1Recipies.Text = "Рецепты";
            // 
            // tabPage2Products
            // 
            this.tabPage2Products.BackColor = System.Drawing.Color.Thistle;
            this.tabPage2Products.Location = new System.Drawing.Point(4, 24);
            this.tabPage2Products.Name = "tabPage2Products";
            this.tabPage2Products.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Products.Size = new System.Drawing.Size(1076, 759);
            this.tabPage2Products.TabIndex = 1;
            this.tabPage2Products.Text = "Продукты";
            this.tabPage2Products.Enter += new System.EventHandler(this.tabPage2Products_Enter);
            // 
            // tabPage3Categories
            // 
            this.tabPage3Categories.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage3Categories.Location = new System.Drawing.Point(4, 24);
            this.tabPage3Categories.Name = "tabPage3Categories";
            this.tabPage3Categories.Size = new System.Drawing.Size(1076, 759);
            this.tabPage3Categories.TabIndex = 2;
            this.tabPage3Categories.Text = "Категории";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.StripMenuItemAboutProgramm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItemExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItemExit
            // 
            this.выходToolStripMenuItemExit.Name = "выходToolStripMenuItemExit";
            this.выходToolStripMenuItemExit.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItemExit.Text = "Выход";
            this.выходToolStripMenuItemExit.Click += new System.EventHandler(this.выходToolStripMenuItemExit_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // StripMenuItemAboutProgramm
            // 
            this.StripMenuItemAboutProgramm.Name = "StripMenuItemAboutProgramm";
            this.StripMenuItemAboutProgramm.Size = new System.Drawing.Size(94, 20);
            this.StripMenuItemAboutProgramm.Text = "О программе";
            this.StripMenuItemAboutProgramm.Click += new System.EventHandler(this.StripMenuItemAboutProgramm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рецепты";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1Recipies;
        private System.Windows.Forms.TabPage tabPage2Products;
        private System.Windows.Forms.TabPage tabPage3Categories;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemAboutProgramm;
    }
}

