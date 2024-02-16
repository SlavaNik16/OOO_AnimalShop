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
            ProductTypes= productTypes;
            labelName.Text = ProductTypes.Name;
            labelDesc.Text = ProductTypes.Description;
            labelPrice.Text = ProductTypes.Price.ToString("C2");
            labelIsActual.Text = ProductTypes.CountInPack == 0 ? "Нет" : "Да";
            labelManufacture.Text = ProductTypes.Manufacturer.Name;
            //if(ProductTypes.ImagePreview != null)
            //{
            //    pictureBox1.Image = Image.FromStream(new MemoryStream(ProductTypes.ImagePreview));
            //}

        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            using (var db = new AnimalShopContext())
            {
                var productTypes = db.ProductTypeses.FirstOrDefault(x => x.Articul == ProductTypes.Articul);
                if (productTypes == null) return;
                var isOrder = db.Orders.Include(x=> x.Products).Any(x=>x.Products.Any(y=>y.ProductTypesArticul == productTypes.Articul));
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
    }
}
