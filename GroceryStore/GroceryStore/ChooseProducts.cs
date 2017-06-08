using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GroceryStore
{
    public partial class ChooseProducts : Form
    {
        private int clientID;
        private int orderID;
        private int index;
        private int productID;
        private double sum = 0;
        public ChooseProducts(int clientID, int orderID, int index)
        {
            this.clientID = clientID;
            this.orderID = orderID;
            this.index = index;
            InitializeComponent();



            //Create columns in Shopping cart table
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Product_Name as Product, Product_Price as \"Price per Kilogram\", Product_Quantity as \"Quantity (kg)\" FROM Product AS p JOIN Product_Order AS po ON p.Product_ID = po.Product_ID JOIN \"Order\" AS o ON po.Order_ID = o.Order_ID WHERE o.Client_ID='" + clientID + "'", con);
            DataTable data = new DataTable();
            sda.Fill(data);

            var commandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.ReadOnly = true;


            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.AutoGenerateColumns = false;

            dataGridView2.Columns.Add("Total_Price", "Total Price");

            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }


        private void ChooseProducts_Load(object sender, EventArgs e)
        {
            //Load the table with the products

            if (index == 1)
            {
                try
                {
                    this.productTableAdapter.Fruits(this.groceryStoreDataSet.Product);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            else if (index == 2)
            {
                try
                {
                    this.productTableAdapter.Vegetables(this.groceryStoreDataSet.Product);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }

            // Calculate total price for single product
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                int n = row.Index;
                dataGridView2.Rows[n].Cells[3].Value =
                   (decimal)(Decimal.Parse(dataGridView2.Rows[n].Cells[1].Value.ToString()) *
                    Decimal.Parse(dataGridView2.Rows[n].Cells[2].Value.ToString()));
                sum += Double.Parse(dataGridView2.Rows[n].Cells[3].Value.ToString());
                lblTotalPrice.Text = sum.ToString("0.00");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerEnterData ced = new CustomerEnterData();
            ced.ShowDialog();
            this.Close();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            var value = dataGridViewProducts.Rows[dataGridViewProducts.SelectedRows[0].Index].Cells[0].Value.ToString();
            var valueInt = Int32.Parse(value);

            this.Hide();
            ChooseQuantity cq = new ChooseQuantity(valueInt, clientID, orderID, index);
            cq.ShowDialog();
            this.Close();

        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            if (sum == 0)
            {
                MessageBox.Show("Please choose some products");
            }
            else
            {
                this.Hide();
                Receipt r = new Receipt(orderID, clientID, lblTotalPrice.Text);
                r.ShowDialog();
                this.Close();
            }


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.Fruits(this.groceryStoreDataSet.Product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            index = 1;
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.Vegetables(this.groceryStoreDataSet.Product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            index = 2;
        }



        private void btnDelete_Click(object sender, EventArgs e)    
        {
            try
            {
                var value = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[0].Value.ToString();
                var name = value.ToString();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Product_ID from Product where (Product_Name like '" + name + "')", con);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    productID = reader.GetInt32(0);
                }

                con.Close();
                SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("delete from Product_Order where (Order_ID = '" + orderID + "' and Product_ID = '" + productID + "')", con1);
                cmd1.ExecuteNonQuery();
                con1.Close();

                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentCell.RowIndex);

                if (dataGridView2.Rows.Count == 0)
                {
                    lblTotalPrice.Text = "0";
                }
                sum = 0;
                // Calculate total price for single product
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    int n = row.Index;
                    dataGridView2.Rows[n].Cells[3].Value =
                        (Decimal.Parse(dataGridView2.Rows[n].Cells[1].Value.ToString()) *
                        Decimal.Parse(dataGridView2.Rows[n].Cells[2].Value.ToString())).ToString();
                    sum += Double.Parse(dataGridView2.Rows[n].Cells[3].Value.ToString());
                    lblTotalPrice.Text = sum.ToString("0.00");
                }

                MessageBox.Show("The product was successfully removed from your cart!");
            }
            catch (Exception)
            {
                MessageBox.Show("Your cart is empty");
            }
        }
    }
}
