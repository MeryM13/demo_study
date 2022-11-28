namespace demo_study.FORMS
{
    partial class AddUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblArticle;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label productUnitLabel;
            System.Windows.Forms.Label productCostLabel;
            System.Windows.Forms.Label productDiscountAmountLabel;
            System.Windows.Forms.Label productManufacturerLabel;
            System.Windows.Forms.Label productSupplierLabel;
            System.Windows.Forms.Label productCategoryLabel;
            System.Windows.Forms.Label productCurrentDiscountLabel;
            System.Windows.Forms.Label productQuantityInStockLabel;
            System.Windows.Forms.Label productDescriptionLabel;
            this.txtArticle = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.imgProduct = new System.Windows.Forms.PictureBox();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveAndExit = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.numCurrentDiscount = new System.Windows.Forms.NumericUpDown();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.numMaxDiscount = new System.Windows.Forms.NumericUpDown();
            lblArticle = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            productUnitLabel = new System.Windows.Forms.Label();
            productCostLabel = new System.Windows.Forms.Label();
            productDiscountAmountLabel = new System.Windows.Forms.Label();
            productManufacturerLabel = new System.Windows.Forms.Label();
            productSupplierLabel = new System.Windows.Forms.Label();
            productCategoryLabel = new System.Windows.Forms.Label();
            productCurrentDiscountLabel = new System.Windows.Forms.Label();
            productQuantityInStockLabel = new System.Windows.Forms.Label();
            productDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticle
            // 
            lblArticle.AutoSize = true;
            lblArticle.Location = new System.Drawing.Point(12, 34);
            lblArticle.Name = "lblArticle";
            lblArticle.Size = new System.Drawing.Size(76, 23);
            lblArticle.TabIndex = 1;
            lblArticle.Text = "Артикул";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(12, 70);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(80, 23);
            productNameLabel.TabIndex = 3;
            productNameLabel.Text = "Название";
            // 
            // productUnitLabel
            // 
            productUnitLabel.AutoSize = true;
            productUnitLabel.Location = new System.Drawing.Point(12, 106);
            productUnitLabel.Name = "productUnitLabel";
            productUnitLabel.Size = new System.Drawing.Size(162, 23);
            productUnitLabel.TabIndex = 5;
            productUnitLabel.Text = "Единица измерения";
            // 
            // productCostLabel
            // 
            productCostLabel.AutoSize = true;
            productCostLabel.Location = new System.Drawing.Point(12, 142);
            productCostLabel.Name = "productCostLabel";
            productCostLabel.Size = new System.Drawing.Size(92, 23);
            productCostLabel.TabIndex = 7;
            productCostLabel.Text = "Стоимость";
            // 
            // productDiscountAmountLabel
            // 
            productDiscountAmountLabel.AutoSize = true;
            productDiscountAmountLabel.Location = new System.Drawing.Point(12, 178);
            productDiscountAmountLabel.Name = "productDiscountAmountLabel";
            productDiscountAmountLabel.Size = new System.Drawing.Size(178, 23);
            productDiscountAmountLabel.TabIndex = 9;
            productDiscountAmountLabel.Text = "Максимальная скидка";
            // 
            // productManufacturerLabel
            // 
            productManufacturerLabel.AutoSize = true;
            productManufacturerLabel.Location = new System.Drawing.Point(12, 214);
            productManufacturerLabel.Name = "productManufacturerLabel";
            productManufacturerLabel.Size = new System.Drawing.Size(130, 23);
            productManufacturerLabel.TabIndex = 11;
            productManufacturerLabel.Text = "Производитель";
            // 
            // productSupplierLabel
            // 
            productSupplierLabel.AutoSize = true;
            productSupplierLabel.Location = new System.Drawing.Point(12, 250);
            productSupplierLabel.Name = "productSupplierLabel";
            productSupplierLabel.Size = new System.Drawing.Size(97, 23);
            productSupplierLabel.TabIndex = 13;
            productSupplierLabel.Text = "Поставщик";
            // 
            // productCategoryLabel
            // 
            productCategoryLabel.AutoSize = true;
            productCategoryLabel.Location = new System.Drawing.Point(12, 286);
            productCategoryLabel.Name = "productCategoryLabel";
            productCategoryLabel.Size = new System.Drawing.Size(88, 23);
            productCategoryLabel.TabIndex = 15;
            productCategoryLabel.Text = "Категория";
            // 
            // productCurrentDiscountLabel
            // 
            productCurrentDiscountLabel.AutoSize = true;
            productCurrentDiscountLabel.Location = new System.Drawing.Point(12, 322);
            productCurrentDiscountLabel.Name = "productCurrentDiscountLabel";
            productCurrentDiscountLabel.Size = new System.Drawing.Size(131, 23);
            productCurrentDiscountLabel.TabIndex = 17;
            productCurrentDiscountLabel.Text = "Текущая скидка";
            // 
            // productQuantityInStockLabel
            // 
            productQuantityInStockLabel.AutoSize = true;
            productQuantityInStockLabel.Location = new System.Drawing.Point(12, 358);
            productQuantityInStockLabel.Name = "productQuantityInStockLabel";
            productQuantityInStockLabel.Size = new System.Drawing.Size(177, 23);
            productQuantityInStockLabel.TabIndex = 19;
            productQuantityInStockLabel.Text = "Количество на складе";
            // 
            // productDescriptionLabel
            // 
            productDescriptionLabel.AutoSize = true;
            productDescriptionLabel.Location = new System.Drawing.Point(12, 394);
            productDescriptionLabel.Name = "productDescriptionLabel";
            productDescriptionLabel.Size = new System.Drawing.Size(86, 23);
            productDescriptionLabel.TabIndex = 21;
            productDescriptionLabel.Text = "Описание";
            // 
            // txtArticle
            // 
            this.txtArticle.Enabled = false;
            this.txtArticle.Location = new System.Drawing.Point(190, 31);
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.Size = new System.Drawing.Size(344, 30);
            this.txtArticle.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(190, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(344, 30);
            this.txtName.TabIndex = 4;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(190, 103);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(344, 30);
            this.txtUnit.TabIndex = 6;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(190, 139);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(344, 30);
            this.txtCost.TabIndex = 8;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(190, 211);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(344, 30);
            this.txtManufacturer.TabIndex = 12;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(190, 247);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(344, 30);
            this.txtSupplier.TabIndex = 14;
            // 
            // imgProduct
            // 
            this.imgProduct.Location = new System.Drawing.Point(540, 34);
            this.imgProduct.Name = "imgProduct";
            this.imgProduct.Size = new System.Drawing.Size(358, 315);
            this.imgProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProduct.TabIndex = 25;
            this.imgProduct.TabStop = false;
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Location = new System.Drawing.Point(540, 356);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(358, 29);
            this.btnChangeImage.TabIndex = 26;
            this.btnChangeImage.Text = "Изменить изображение";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(540, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(358, 30);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveAndExit
            // 
            this.btnSaveAndExit.Location = new System.Drawing.Point(540, 427);
            this.btnSaveAndExit.Name = "btnSaveAndExit";
            this.btnSaveAndExit.Size = new System.Drawing.Size(358, 30);
            this.btnSaveAndExit.TabIndex = 28;
            this.btnSaveAndExit.Text = "Сохранить и выйти";
            this.btnSaveAndExit.UseVisualStyleBackColor = true;
            this.btnSaveAndExit.Click += new System.EventHandler(this.btnSaveAndExit_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(190, 391);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(344, 66);
            this.txtDescription.TabIndex = 29;
            this.txtDescription.Text = "";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(190, 356);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(344, 30);
            this.numQuantity.TabIndex = 30;
            // 
            // numCurrentDiscount
            // 
            this.numCurrentDiscount.Location = new System.Drawing.Point(190, 320);
            this.numCurrentDiscount.Name = "numCurrentDiscount";
            this.numCurrentDiscount.Size = new System.Drawing.Size(344, 30);
            this.numCurrentDiscount.TabIndex = 31;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(190, 284);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(344, 31);
            this.cmbCategory.TabIndex = 32;
            // 
            // numMaxDiscount
            // 
            this.numMaxDiscount.Location = new System.Drawing.Point(190, 176);
            this.numMaxDiscount.Name = "numMaxDiscount";
            this.numMaxDiscount.Size = new System.Drawing.Size(344, 30);
            this.numMaxDiscount.TabIndex = 33;
            // 
            // AddUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 484);
            this.Controls.Add(this.numMaxDiscount);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.numCurrentDiscount);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSaveAndExit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.imgProduct);
            this.Controls.Add(lblArticle);
            this.Controls.Add(this.txtArticle);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(productUnitLabel);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(productCostLabel);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(productDiscountAmountLabel);
            this.Controls.Add(productManufacturerLabel);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(productSupplierLabel);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(productCategoryLabel);
            this.Controls.Add(productCurrentDiscountLabel);
            this.Controls.Add(productQuantityInStockLabel);
            this.Controls.Add(productDescriptionLabel);
            this.Name = "AddUpdateForm";
            this.Text = "AddUpdateForm";
            this.Load += new System.EventHandler(this.AddUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtArticle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.PictureBox imgProduct;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveAndExit;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.NumericUpDown numCurrentDiscount;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.NumericUpDown numMaxDiscount;
    }
}