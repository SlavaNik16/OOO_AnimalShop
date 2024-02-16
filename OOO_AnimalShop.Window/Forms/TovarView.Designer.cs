namespace OOO_AnimalShop.Window.Forms
{
    partial class TovarView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelManufacture = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCountInPack = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butEdit = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelName);
            this.flowLayoutPanel1.Controls.Add(this.labelDesc);
            this.flowLayoutPanel1.Controls.Add(this.labelManufacture);
            this.flowLayoutPanel1.Controls.Add(this.labelPrice);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(415, 22);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(768, 275);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelName.Location = new System.Drawing.Point(4, 0);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(227, 37);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Наименование";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelDesc.Location = new System.Drawing.Point(4, 37);
            this.labelDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(155, 37);
            this.labelDesc.TabIndex = 1;
            this.labelDesc.Text = "Описание";
            // 
            // labelManufacture
            // 
            this.labelManufacture.AutoSize = true;
            this.labelManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelManufacture.Location = new System.Drawing.Point(4, 74);
            this.labelManufacture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManufacture.Name = "labelManufacture";
            this.labelManufacture.Size = new System.Drawing.Size(234, 37);
            this.labelManufacture.TabIndex = 3;
            this.labelManufacture.Text = "Производитель";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelPrice.Location = new System.Drawing.Point(4, 111);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(89, 37);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Цена";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelCountInPack);
            this.panel1.Location = new System.Drawing.Point(1191, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 186);
            this.panel1.TabIndex = 2;
            // 
            // labelCountInPack
            // 
            this.labelCountInPack.AutoSize = true;
            this.labelCountInPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelCountInPack.Location = new System.Drawing.Point(36, 93);
            this.labelCountInPack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountInPack.Name = "labelCountInPack";
            this.labelCountInPack.Size = new System.Drawing.Size(159, 74);
            this.labelCountInPack.TabIndex = 1;
            this.labelCountInPack.Text = "Наличие\r\nна складе";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddOrderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 36);
            // 
            // AddOrderToolStripMenuItem
            // 
            this.AddOrderToolStripMenuItem.Name = "AddOrderToolStripMenuItem";
            this.AddOrderToolStripMenuItem.Size = new System.Drawing.Size(225, 32);
            this.AddOrderToolStripMenuItem.Text = "Добавить в заказ";
            // 
            // butEdit
            // 
            this.butEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(64)))));
            this.butEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.butEdit.Location = new System.Drawing.Point(1430, 22);
            this.butEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(208, 66);
            this.butEdit.TabIndex = 4;
            this.butEdit.Text = "Изменить";
            this.butEdit.UseVisualStyleBackColor = false;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(189)))), ((int)(((byte)(64)))));
            this.butDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.butDelete.Location = new System.Drawing.Point(1430, 221);
            this.butDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(208, 66);
            this.butDelete.TabIndex = 5;
            this.butDelete.Text = "Удалить";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOO_AnimalShop.Window.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(20, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(36, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "Наличие\r\nна складе:";
            // 
            // TovarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TovarView";
            this.Size = new System.Drawing.Size(1642, 322);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCountInPack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddOrderToolStripMenuItem;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Label labelManufacture;
        private System.Windows.Forms.Label label1;
    }
}
