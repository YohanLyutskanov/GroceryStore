﻿namespace GroceryStore
{
    partial class FruitsOrVegetables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FruitsOrVegetables));
            this.pictureFruits = new System.Windows.Forms.PictureBox();
            this.pictureVegetables = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFruits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVegetables)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureFruits
            // 
            this.pictureFruits.Image = ((System.Drawing.Image)(resources.GetObject("pictureFruits.Image")));
            this.pictureFruits.Location = new System.Drawing.Point(32, 43);
            this.pictureFruits.Name = "pictureFruits";
            this.pictureFruits.Size = new System.Drawing.Size(181, 135);
            this.pictureFruits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFruits.TabIndex = 0;
            this.pictureFruits.TabStop = false;
            this.pictureFruits.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureVegetables
            // 
            this.pictureVegetables.Image = ((System.Drawing.Image)(resources.GetObject("pictureVegetables.Image")));
            this.pictureVegetables.Location = new System.Drawing.Point(280, 43);
            this.pictureVegetables.Name = "pictureVegetables";
            this.pictureVegetables.Size = new System.Drawing.Size(181, 135);
            this.pictureVegetables.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureVegetables.TabIndex = 1;
            this.pictureVegetables.TabStop = false;
            this.pictureVegetables.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fruits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(310, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vegetables";
            // 
            // FruitsOrVegetables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureVegetables);
            this.Controls.Add(this.pictureFruits);
            this.Name = "FruitsOrVegetables";
            ((System.ComponentModel.ISupportInitialize)(this.pictureFruits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVegetables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureFruits;
        private System.Windows.Forms.PictureBox pictureVegetables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}