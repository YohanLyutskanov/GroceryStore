﻿namespace GroceryStore
{
    partial class ChooseQuantity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseQuantity));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnCancelProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPricePerKG = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPriceForProduct = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddProductToCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(255, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductName.Location = new System.Drawing.Point(210, 200);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(322, 40);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQuantity.Location = new System.Drawing.Point(487, 337);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(131, 30);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyUp);
            // 
            // btnCancelProduct
            // 
            this.btnCancelProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelProduct.Location = new System.Drawing.Point(131, 515);
            this.btnCancelProduct.Name = "btnCancelProduct";
            this.btnCancelProduct.Size = new System.Drawing.Size(208, 58);
            this.btnCancelProduct.TabIndex = 3;
            this.btnCancelProduct.Text = "Cancel";
            this.btnCancelProduct.UseVisualStyleBackColor = true;
            this.btnCancelProduct.Click += new System.EventHandler(this.btnCancelProduct_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(135, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantity (kg):";
            // 
            // lblPricePerKG
            // 
            this.lblPricePerKG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPricePerKG.AutoSize = true;
            this.lblPricePerKG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPricePerKG.Location = new System.Drawing.Point(528, 270);
            this.lblPricePerKG.Name = "lblPricePerKG";
            this.lblPricePerKG.Size = new System.Drawing.Size(29, 31);
            this.lblPricePerKG.TabIndex = 5;
            this.lblPricePerKG.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(135, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price per Kilogram:";
            // 
            // lblTotalPriceForProduct
            // 
            this.lblTotalPriceForProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPriceForProduct.AutoSize = true;
            this.lblTotalPriceForProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalPriceForProduct.Location = new System.Drawing.Point(528, 414);
            this.lblTotalPriceForProduct.Name = "lblTotalPriceForProduct";
            this.lblTotalPriceForProduct.Size = new System.Drawing.Size(29, 31);
            this.lblTotalPriceForProduct.TabIndex = 7;
            this.lblTotalPriceForProduct.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(135, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Price:";
            // 
            // btnAddProductToCart
            // 
            this.btnAddProductToCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProductToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProductToCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProductToCart.Image")));
            this.btnAddProductToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProductToCart.Location = new System.Drawing.Point(386, 515);
            this.btnAddProductToCart.Name = "btnAddProductToCart";
            this.btnAddProductToCart.Size = new System.Drawing.Size(203, 58);
            this.btnAddProductToCart.TabIndex = 9;
            this.btnAddProductToCart.Text = "Add to Cart";
            this.btnAddProductToCart.UseVisualStyleBackColor = true;
            this.btnAddProductToCart.Click += new System.EventHandler(this.btnAddProductToCart_Click);
            // 
            // ChooseQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 598);
            this.Controls.Add(this.btnAddProductToCart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalPriceForProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPricePerKG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelProduct);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChooseQuantity";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnCancelProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPricePerKG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPriceForProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddProductToCart;
    }
}