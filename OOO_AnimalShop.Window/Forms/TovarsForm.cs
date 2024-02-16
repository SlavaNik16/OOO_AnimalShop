using OOO_AnimalShop.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using OOO_AnimalShop.Context.Models;

namespace OOO_AnimalShop.Window.Forms
{
    public partial class TovarsForm : Form
    {
        private Dictionary<ProductTypes, int> productTypesOrder;
        public TovarsForm()
        {
            InitializeComponent();
            Init();
            InitFlowLayout();
        }

        private void Init()
        {
            using (var db = new AnimalShopContext())
            {
                comboBoxManufacture.DisplayMember = nameof(Manufacturer.Name);
                comboBoxManufacture.Items.AddRange(db.Manufacturers.ToArray());
                comboBoxManufacture.Items.Insert(0, new Manufacturer()
                {
                    Id = -1,
                    Name = "Все производители"
                });
                comboBoxManufacture.SelectedIndex = 0;
            }
        }

        public void InitFlowLayout(bool isCheck = true)
        {
            using (var db = new AnimalShopContext())
            {
                var productTypes = db.ProductTypeses
                    .Include(x => x.Supplier)
                    .Include(x => x.Manufacturer);

                productTypes = isCheck ? productTypes.OrderByDescending(x => x.Price) : productTypes.OrderBy(x => x.Price);

                flowLayoutPanel1.Controls.Clear();
                foreach (var item in productTypes.ToList())
                {
                    CreateTovarView(item);
                }
            }
            Filter();

        }

        private void CreateTovarView(ProductTypes item)
        {
            var tovarView = new TovarView(item);
            tovarView.Parent = flowLayoutPanel1;
            tovarView.ProductTypesAddOrder += TovarView_ProductTypesAddOrder;
        }

        private void TovarView_ProductTypesAddOrder(ProductTypes tovar)
        {
            if(productTypesOrder.TryGetValue(tovar, out var count))
            {
                productTypesOrder[tovar] = ++count;
            }
            else
            {
                productTypesOrder.Add(tovar, 1);
            }
            buttonOrder.Visible = true;
        }

        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            if (comboBoxManufacture.SelectedItem == null) return;
            var id = ((Manufacturer)comboBoxManufacture.SelectedItem).Id;
            var count = 0;
            foreach(var item in flowLayoutPanel1.Controls)
            {
                if(item is TovarView tovarView)
                {
                    var visible = true;
                    if(id != -1 &&
                        tovarView.ProductTypes.ManufacturerId != id)
                    {
                        visible = false;
                    }
                    if(!(string.IsNullOrEmpty(textBoxSearch.Text) ||
                        tovarView.ProductTypes.Name.Contains(textBoxSearch.Text)))
                    {
                        visible = false;
                    }

                    if (visible)
                    {
                        count++;
                    }
                    tovarView.Visible = visible;
                }
            }
            using (var db = new AnimalShopContext()) 
            {
                labelCountProductTypes.Text = $"{count} из {db.ProductTypeses.Count()}";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            InitFlowLayout(checkBoxSort.Checked);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var tovarChangesForm = new TovarChangesForm();
            if(tovarChangesForm.ShowDialog() == DialogResult.OK)
            {
                using (var db = new AnimalShopContext())
                {
                    var tovar = tovarChangesForm.productTypes;
                    tovar.Articul = GeneratorArticul();
                    db.ProductTypeses.Add(tovar);
                    db.SaveChanges();
                    var product = db.ProductTypeses
                        .Include(x => x.Manufacturer)
                        .Include(y => y.Supplier)
                        .FirstOrDefault(x => x.Articul == tovar.Articul);
                    CreateTovarView(product);
                }
            }
        }

        private string GeneratorArticul()
        {
            var list = new List<string>() { "a", "b", "c", "d", "e", "f", "g","0","1","2","3","4","5","6","7" };
            var rnd = new Random();
            var size = 6;
            var result = string.Empty;
            using (var db = new AnimalShopContext()) 
            {
                while (result.Length < size)
                {
                    result += list[rnd.Next(0, list.Count)];
                    if (db.ProductTypeses.Any(x=>x.Articul == result))
                    {
                        result = string.Empty;
                    }
                }
                return result;
            }
        }
    }
}
