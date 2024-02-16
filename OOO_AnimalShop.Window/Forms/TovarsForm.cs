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
        public TovarsForm()
        {
            InitializeComponent();
            InitFlowLayout();
        }

        public void InitFlowLayout(bool isCheck = true)
        {
            using (var db = new AnimalShopContext())
            {
                comboBoxSupplier.DisplayMember = nameof(Supplier.Name);
                comboBoxSupplier.Items.AddRange(db.Suppliers.ToArray());
                comboBoxSupplier.Items.Insert(0, "Все производители");
                comboBoxSupplier.SelectedIndex = 0;
                var productTypes = db.ProductTypeses
                    .Include(x => x.Supplier)
                    .Include(x=>x.Manufacturer)
                    .OrderBy(x=>x.Price)
                    .ToList();
                foreach(var item in productTypes)
                {
                    var tovarView = new TovarView(item);
                    tovarView.Parent = flowLayoutPanel1;
                }
            }
            Filter();

        }

        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
           
            foreach(var item in flowLayoutPanel1.Controls)
            {
                if(item is TovarView tovarView)
                {
                    var visible = true;

                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
