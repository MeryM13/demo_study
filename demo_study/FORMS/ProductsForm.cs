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
    public partial class ProductsForm : ParentForm
    {
        private User user;
        private string searchString = "";
        private bool sortUp = true;
        private string manufacturer = "";
        private bool updatable = false;
        public ProductsForm(User _user)
        {
            InitializeComponent();
            this.user = _user;
            if (user == null)
            {
                lblWelcome.Visible = false;
            }
            else
            {
                lblWelcome.Text = $"Здравствуйте, {user.Name}";
                if (user.Role == 1)
                {
                    btnAdd.Enabled = true;
                    btnAdd.Visible = true;
                    updatable = true;
                }
            }

            cmbManufacturer.Items.Clear();
            cmbManufacturer.Items.Add("Все производители");
            foreach (var manufact in DataWork.GetManufacturerList())
            {
                cmbManufacturer.Items.Add(manufact);
            }
            Render();
        }

        private void Render()
        {
            try
            {
                panelProducts.Controls.Clear();
                foreach (var product in DataWork.GetProductList(searchString, sortUp, manufacturer))
                {
                    panelProducts.Controls.Add(new ProductUserControl(product, updatable));
                }

                int count = DataWork.GetProductListCount(searchString, manufacturer);
                lblCount.Text = $"Показано {count} записей из {count}";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchString = txtSearch.Text;
            Render();
        }

        private void rbAcs_CheckedChanged(object sender, EventArgs e)
        {
            sortUp = true;
            Render();
        }

        private void rbDesc_CheckedChanged(object sender, EventArgs e)
        {
            sortUp = false;
            Render();
        }

        private void cmbManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            manufacturer = cmbManufacturer.SelectedItem.ToString() == "Все производители"? "" : cmbManufacturer.SelectedItem.ToString();
            Render();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateForm addUpdate = new AddUpdateForm(null);
            this.Hide();
            addUpdate.ShowDialog();
            this.Show();
        }
    }
}
