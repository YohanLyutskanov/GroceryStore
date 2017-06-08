using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class ChooseQuantity : Form
    {
        private int value;
        private int clientID;
        private int orderID;
        private double totalValue;
        private int index;

        public ChooseQuantity(int value, int clientID, int orderID, int index)
        {
            this.value = value;
            this.clientID = clientID;
            this.orderID = orderID;
            this.index = index;
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Product  where Product_ID  = '" + value + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblProductName.Text = reader.GetString(2);
                var price = reader.GetDecimal(3);
                lblPricePerKG.Text = price.ToString("0.00");

            }

            //Change pictures for different products
            switch (lblProductName.Text)
            {
                case "Cucumbers":
                    pictureBox1.Image = GroceryStore.Properties.Resources.Cucumbers;
                    break;
                case "Green Apples":
                    pictureBox1.Image = GroceryStore.Properties.Resources.green_apples;
                    break;
                case "Red Apples":
                    pictureBox1.Image = GroceryStore.Properties.Resources.red_apples;
                    break;
                case "Bananas":
                    pictureBox1.Image = GroceryStore.Properties.Resources.bananas;
                    break;
                case "Peaches":
                    pictureBox1.Image = GroceryStore.Properties.Resources.peaches;
                    break;
                case "Grapes":
                    pictureBox1.Image = GroceryStore.Properties.Resources.grapes;
                    break;
                case "Cherries":
                    pictureBox1.Image = GroceryStore.Properties.Resources.cherry;
                    break;
                case "Lemons":
                    pictureBox1.Image = GroceryStore.Properties.Resources.lemons;
                    break;
                case "Cabbage":
                    pictureBox1.Image = GroceryStore.Properties.Resources.cabage;
                    break;
                case "Tomatoes":
                    pictureBox1.Image = GroceryStore.Properties.Resources.tomatoes;
                    break;
                case "Spinach":
                    pictureBox1.Image = GroceryStore.Properties.Resources.spinach;
                    break;
                case "Oranges":
                    pictureBox1.Image = GroceryStore.Properties.Resources.Oranges;
                    break;
            }
        }


        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                try
                {
                    totalValue = System.Convert.ToDouble(txtQuantity.Text) * System.Convert.ToDouble(lblPricePerKG.Text);
                    lblTotalPriceForProduct.Text = totalValue.ToString("0.00");
                }
                catch (Exception)
                {
                    MessageBox.Show("Please use only numbers and commma for decimal sign");
                    txtQuantity.Text = "";
                    lblTotalPriceForProduct.Text = "0";
                }
            }
            else
            {
                lblTotalPriceForProduct.Text = "0";
            }

        }

        private void btnAddProductToCart_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Please enter quantity");
                
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
                con.Open();


                SqlCommand newCmd = new SqlCommand("INSERT INTO Product_Order (Order_ID, Product_ID, Product_Quantity) VALUES (@OrderID, @ProductID, @Quantity)", con);

                newCmd.Parameters.Add("@OrderID", SqlDbType.Int)
                     .Value = orderID;

                newCmd.Parameters.Add("@ProductID", SqlDbType.Int)
                     .Value = value;

                newCmd.Parameters.Add("@Quantity", SqlDbType.Decimal)
                     .Value = System.Convert.ToDecimal(txtQuantity.Text);

                try
                {
                    newCmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("You already added " + lblProductName.Text + " to your cart");
                    this.Close();
                }
                SqlCommand cmd1 = new SqlCommand("select Order_ID from \"Order\" where (Client_ID = '" + clientID + "')", con);

                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    orderID = reader.GetInt32(0);
                }

                con.Close();
                this.Hide();
                ChooseProducts chp = new ChooseProducts(clientID, orderID, index);
                chp.ShowDialog();
                this.Close();
            }
        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseProducts chp = new ChooseProducts(clientID, orderID, index);
            chp.ShowDialog();
            this.Close();
        }
    }
}

