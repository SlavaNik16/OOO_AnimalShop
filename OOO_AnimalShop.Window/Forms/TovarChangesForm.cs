using OOO_AnimalShop.Context;
using OOO_AnimalShop.Context.Models;
using OOO_AnimalShop.Context.Models.Enums;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OOO_AnimalShop.Window.Forms
{
    public partial class TovarChangesForm : Form
    {
        public ProductTypes productTypes { get; set; }
        public TovarChangesForm()
        {
            InitializeComponent();
            productTypes = new ProductTypes();
            InitTovars();
            
        }

        public TovarChangesForm(ProductTypes productTypes):this()
        {

            this.productTypes = productTypes;
            textBoxName.Text = productTypes.Name;
            numericUpDownPrice.Value = productTypes.Price;
            radioButtonMale.Checked = productTypes.CategoryType == CategoryTypes.Male;
            radioButtonFemale.Checked = productTypes.CategoryType == CategoryTypes.Male;
            comboBoxManufdacturer.SelectedItem = comboBoxManufdacturer.Items.Cast<Manufacturer>().FirstOrDefault(x => x.Id == productTypes.ManufacturerId);
            comboBoxSupplier.SelectedItem = comboBoxSupplier.Items.Cast<Supplier>().FirstOrDefault(x => x.Id == productTypes.SupplierId);
            numericUpDownCount.Value = productTypes.CountInPack;
            textBoxDesc.Text = productTypes.Description;
            if(!string.IsNullOrEmpty(productTypes.ImagePreview))
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
               "image", productTypes.ImagePreview);
                pictureBox1.Image = Image.FromFile(path);
            }

        }

        private void InitTovars()
        {
            using (var db = new AnimalShopContext())
            {
                comboBoxManufdacturer.DisplayMember = nameof(Manufacturer.Name);
                comboBoxManufdacturer.Items.AddRange(db.Manufacturers.ToArray());
                comboBoxManufdacturer.SelectedIndex = 0;

                comboBoxSupplier.DisplayMember = nameof(Supplier.Name);
                comboBoxSupplier.Items.AddRange(db.Suppliers.ToArray());
                comboBoxSupplier.SelectedIndex = 0;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            productTypes.Name = textBoxName.Text;
            ValidateTovar();
        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {
            productTypes.Price = numericUpDownPrice.Value;
        }

        private void comboBoxManufdacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            productTypes.ManufacturerId = ((Manufacturer)comboBoxManufdacturer.SelectedItem).Id;
        }

        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            productTypes.SupplierId = ((Supplier)comboBoxSupplier.SelectedItem).Id;
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
            {
                productTypes.CategoryType = radioButtonMale.Checked ? CategoryTypes.Male : CategoryTypes.Female;
            }
        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            productTypes.CountInPack = (int)numericUpDownCount.Value;
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            productTypes.Description = textBoxDesc.Text;
        }

        private void ValidateTovar()
        {
            buttonSave.Enabled =
                !string.IsNullOrWhiteSpace(textBoxName.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            productTypes.ImagePreview = Path.GetFileName(openFileDialog1.FileName);
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "image", productTypes.ImagePreview);
            if(openFileDialog1.FileName != path)
            {
                File.Copy(openFileDialog1.FileName, path);
            }
            pictureBox1.Image = Image.FromFile(path);
        }
    }
}
