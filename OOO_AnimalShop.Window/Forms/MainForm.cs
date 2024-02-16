using OOO_AnimalShop.Window.Forms;
using OOO_AnimalShop.Window.WorkUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_AnimalShop.Window
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var user = WorkToUser.User;
            toolStripFIO.Text = $"{user.Surname} {user.Name} {user?.Patronimyc}";
            toolStripRole.Text = $"{user.RoleType}";
        }

        private void TovarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tovarForm = new TovarsForm();
            tovarForm.ShowDialog();
        }

    }
}
