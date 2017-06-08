namespace GroceryStore
{
    partial class CustomerEnterData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEnterData));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.lblEnterAddres = new System.Windows.Forms.Label();
            this.txtEnterAddress = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.checkHomeDelivery = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEnterName
            // 
            this.txtEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEnterName.Location = new System.Drawing.Point(73, 66);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(236, 23);
            this.txtEnterName.TabIndex = 1;
            // 
            // lblEnterAddres
            // 
            this.lblEnterAddres.Enabled = false;
            this.lblEnterAddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnterAddres.Location = new System.Drawing.Point(17, 154);
            this.lblEnterAddres.Name = "lblEnterAddres";
            this.lblEnterAddres.Size = new System.Drawing.Size(345, 25);
            this.lblEnterAddres.TabIndex = 2;
            this.lblEnterAddres.Text = "Enter your address";
            this.lblEnterAddres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEnterAddress
            // 
            this.txtEnterAddress.Enabled = false;
            this.txtEnterAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEnterAddress.Location = new System.Drawing.Point(73, 182);
            this.txtEnterAddress.Multiline = true;
            this.txtEnterAddress.Name = "txtEnterAddress";
            this.txtEnterAddress.Size = new System.Drawing.Size(236, 67);
            this.txtEnterAddress.TabIndex = 3;
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContinue.Image = ((System.Drawing.Image)(resources.GetObject("btnContinue.Image")));
            this.btnContinue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContinue.Location = new System.Drawing.Point(102, 284);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(184, 50);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // checkHomeDelivery
            // 
            this.checkHomeDelivery.AutoSize = true;
            this.checkHomeDelivery.Location = new System.Drawing.Point(141, 134);
            this.checkHomeDelivery.Name = "checkHomeDelivery";
            this.checkHomeDelivery.Size = new System.Drawing.Size(123, 17);
            this.checkHomeDelivery.TabIndex = 5;
            this.checkHomeDelivery.Text = "I want home delivery";
            this.checkHomeDelivery.UseVisualStyleBackColor = true;
            this.checkHomeDelivery.CheckedChanged += new System.EventHandler(this.checkHomeDelivery_CheckedChanged);
            // 
            // CustomerEnterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 359);
            this.Controls.Add(this.checkHomeDelivery);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtEnterAddress);
            this.Controls.Add(this.lblEnterAddres);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.label1);
            this.Name = "CustomerEnterData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Label lblEnterAddres;
        private System.Windows.Forms.TextBox txtEnterAddress;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.CheckBox checkHomeDelivery;
    }
}