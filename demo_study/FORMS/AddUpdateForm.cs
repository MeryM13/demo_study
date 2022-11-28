using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using demo_study.CLASSES;

namespace demo_study.FORMS
{
    public partial class AddUpdateForm : ParentForm
    {
        private Product product;
        private string photoPath;
        private string ImageFolderPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\IMAGES\"));
        private int mode;
        public AddUpdateForm(Product _product)
        {
            InitializeComponent();
            this.product = _product;
            if (_product != null)
            {
                //добавление
                mode = 0;
                txtArticle.Text = product.Article;
                txtCost.Text = product.Cost.ToString();
                ImgUpload(product.Photo);
                //Загрузить данные в поля
            }
            else
            {
                //редактирование
                mode = 1;
                txtArticle.Visible = false;
            }

        }

        private void AddUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool SaveData()
        {
            try
            {
                //Считать данные из полей в продукт
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Данные введены неправильно");
                return false;
            }
        }

        private void btnSaveAndExit_Click(object sender, EventArgs e)
        {
            ImgSave();
            this.Close();
        }

        private void ImgUpload(string path)
        {
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


        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            using (var openPhotoDialog = new OpenFileDialog())
            {
                if (openPhotoDialog.ShowDialog() == DialogResult.OK)
                {
                    ImgUpload(openPhotoDialog.FileName);
                    photoPath = openPhotoDialog.FileName;
                }
            }
        }

        private void ImgSave()
        {
            string name = Path.GetFileName(photoPath);
            if (name != product.Photo && photoPath != product.Photo)
            {
                product.Photo = name;
                File.Copy(photoPath, ImageFolderPath + name, true);
            }
        }

    }
}
