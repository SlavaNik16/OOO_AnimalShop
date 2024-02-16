using OOO_AnimalShop.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace OOO_AnimalShop.Window.Forms
{
    public partial class TovarView : UserControl
    {
        public ProductTypes ProductTypes { get; set; }
        public TovarView(ProductTypes productTypes)
        {
            InitializeComponent();
            ProductTypes = productTypes;
            InitTovarView();

        }

        private void InitTovarView()
        {
            labelName.Text = ProductTypes.Name;
            labelDesc.Text = ProductTypes.Description;
            labelPrice.Text = ProductTypes.Price.ToString("C2");
            labelCountInPack.Text = ProductTypes.CountInPack == 0 ? "Нет" : "Да";
            labelManufacture.Text = ProductTypes.Manufacturer.Name;
            if (!string.IsNullOrEmpty(ProductTypes.ImagePreview))
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    "image",
                    ProductTypes.ImagePreview);
                pictureBox1.Image = Image.FromFile(path);
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            using (var db = new AnimalShopContext())
            {
                var productTypes = db.ProductTypeses.FirstOrDefault(x => x.Articul == ProductTypes.Articul);
                if (productTypes == null) return;
                var isOrder = db.Products.Any(y=>y.ProductTypesArticul == productTypes.Articul);
                if (isOrder)
                {
                    MessageBox.Show("Вы не можете удалить этот тип товара так как он используется в заказе!!!",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Вы действительно хотите удалить этот тип товара?",
                    "Предупреждение!",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.ProductTypeses.Remove(productTypes);
                    db.SaveChanges();
                    this.Hide();
                }
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            using (var db = new AnimalShopContext())
            {
                var tovarDB = db.ProductTypeses.FirstOrDefault(x=>x.Articul == ProductTypes.Articul);
                var tovarChangesForm = new TovarChangesForm(tovarDB);
                if (tovarChangesForm.ShowDialog() == DialogResult.OK)
                {
                    ProductTypes = tovarDB;
                    db.SaveChanges();
                    InitTovarView();
                }
            }
        }

        private void labelIsActual_Click(object sender, EventArgs e)
        {

        }
    }
}
