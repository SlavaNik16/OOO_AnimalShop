namespace OOO_AnimalShop.Window
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.формыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TovarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BibliyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripFIO = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // формыToolStripMenuItem
            // 
            this.формыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TovarsToolStripMenuItem,
            this.BibliyaToolStripMenuItem});
            this.формыToolStripMenuItem.Name = "формыToolStripMenuItem";
            this.формыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.формыToolStripMenuItem.Text = "Формы";
            // 
            // TovarsToolStripMenuItem
            // 
            this.TovarsToolStripMenuItem.Name = "TovarsToolStripMenuItem";
            this.TovarsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.TovarsToolStripMenuItem.Text = "Товары";
            this.TovarsToolStripMenuItem.Click += new System.EventHandler(this.TovarsToolStripMenuItem_Click);
            // 
            // BibliyaToolStripMenuItem
            // 
            this.BibliyaToolStripMenuItem.Name = "BibliyaToolStripMenuItem";
            this.BibliyaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.BibliyaToolStripMenuItem.Text = "Библиотека";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFIO,
            this.toolStripRole});
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(705, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripFIO
            // 
            this.toolStripFIO.Name = "toolStripFIO";
            this.toolStripFIO.Size = new System.Drawing.Size(34, 17);
            this.toolStripFIO.Text = "ФИО";
            // 
            // toolStripRole
            // 
            this.toolStripRole.Name = "toolStripRole";
            this.toolStripRole.Size = new System.Drawing.Size(37, 17);
            this.toolStripRole.Text = "Гость";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 430);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Главная";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem формыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TovarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BibliyaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFIO;
        private System.Windows.Forms.ToolStripStatusLabel toolStripRole;
    }
}

