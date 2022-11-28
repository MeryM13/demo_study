using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using demo_study.CLASSES;

namespace demo_study.FORMS
{
    public partial class ProductUserControl : UserControl
    {
        private Product product;
        private string ImageFolderPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\IMAGES\"));
        private bool updateAvailable;

        public ProductUserControl(Product _product, bool updatable)
        {
            InitializeComponent();
            this.product = _product;
            this.updateAvailable = updatable;
            lblName.Text = product.Name;
            lblDescription.Text = product.Description;
            lblManufacturer.Text = product.Manufacturer;
            lblPrice.Text = product.Cost.ToString();
            lblAvailable.Text = product.Quantity == 0 ? "Нет" : product.Quantity.ToString();

            Image image;
            if (!String.IsNullOrEmpty(product.Photo))
            {
                image = Image.FromFile(ImageFolderPath + product.Photo);
            }
            else
            {
                image = Image.FromFile(ImageFolderPath + "picture.png");
            }
            imgProduct.Image = image;
        }

        private void ProductUserControl_Click(object sender, EventArgs e)
        {
            if (updateAvailable)
            {
                AddUpdateForm addUpdate = new AddUpdateForm(product);
                this.Hide();
                addUpdate.ShowDialog();
                this.Show();
            }
        }
    }
}
