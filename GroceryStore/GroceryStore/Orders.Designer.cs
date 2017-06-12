namespace GroceryStore
{
    partial class Orders
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
            this.components = new System.ComponentModel.Container();
            this.listOrders = new System.Windows.Forms.ListBox();
            this.btnSelectOrder = new System.Windows.Forms.Button();
            this.groceryStoreDataSet = new GroceryStore.GroceryStoreDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new GroceryStore.GroceryStoreDataSetTableAdapters.OrderTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groceryStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listOrders
            // 
            this.listOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOrders.FormattingEnabled = true;
            this.listOrders.ItemHeight = 25;
            this.listOrders.Location = new System.Drawing.Point(42, 61);
            this.listOrders.Name = "listOrders";
            this.listOrders.Size = new System.Drawing.Size(253, 154);
            this.listOrders.TabIndex = 0;
            // 
            // btnSelectOrder
            // 
            this.btnSelectOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectOrder.Location = new System.Drawing.Point(65, 259);
            this.btnSelectOrder.Name = "btnSelectOrder";
            this.btnSelectOrder.Size = new System.Drawing.Size(204, 58);
            this.btnSelectOrder.TabIndex = 17;
            this.btnSelectOrder.Text = "Select Order";
            this.btnSelectOrder.UseVisualStyleBackColor = true;
            this.btnSelectOrder.Click += new System.EventHandler(this.btnSelectOrder_Click);
            // 
            // groceryStoreDataSet
            // 
            this.groceryStoreDataSet.DataSetName = "GroceryStoreDataSet";
            this.groceryStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.groceryStoreDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Orders";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectOrder);
            this.Controls.Add(this.listOrders);
            this.Name = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groceryStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOrders;
        private System.Windows.Forms.Button btnSelectOrder;
        private GroceryStoreDataSet groceryStoreDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private GroceryStoreDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}