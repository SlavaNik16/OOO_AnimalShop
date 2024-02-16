using OOO_AnimalShop.Context;
using OOO_AnimalShop.Window.WorkUser;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OOO_AnimalShop.Window.Forms
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            using (var db = new AnimalShopContext())
            {
                var user = db.Users.FirstOrDefault(x=>x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
                if (user == null)
                {
                    MessageBox.Show("Пользователь не найден!", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                WorkToUser.User = user;

                var mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
        }

        private void butGuest_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
            this.Show();
        }
    }
}
