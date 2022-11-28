using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo_study.CLASSES;
using demo_study.UTILS;

namespace demo_study.FORMS
{
    public partial class LoginForm : ParentForm
    {
        private User user;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                user = DataWork.GetUserByLoginAndPassword(txtLogin.Text, txtPassword.Text);
                ProductsForm productsForm = new ProductsForm(user);
                this.Hide();
                productsForm.ShowDialog();
                this.Show();
            }
            catch (Exception exception)
            {
               MessageBox.Show(exception.Message);
            }
        }

        private void linkGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            user = null;
            ProductsForm productsForm = new ProductsForm(user);
            this.Hide();
            productsForm.ShowDialog();
            this.Show();
            txtLogin.Text = "";
            txtPassword.Text = "";
        }
    }
}
