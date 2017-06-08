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
    public partial class Orders : Form
    {
        private int employeeID;
        //private int orderID;

        public Orders(int employeeID)
        {
            this.employeeID = employeeID;
            //this.orderID = orderID;
            InitializeComponent();
        }

        private void btnSelectOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int orderID = Int32.Parse(listOrders.SelectedValue.ToString());

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
                con.Open();
                SqlCommand a = new SqlCommand("Update \"Order\" set Order_Status = \'Processed\' where Order_ID = '" + orderID + "' ", con);
                a.ExecuteNonQuery();
                SqlCommand b = new SqlCommand("Insert into Employee_Order (Employee_ID, Order_ID) values('" + employeeID + "', '" + orderID + "') ", con);
                b.ExecuteNonQuery();

                con.Close();


                this.Hide();
                ProcessOrder po = new ProcessOrder(employeeID, orderID);
                po.ShowDialog();
                this.Close();
            } catch (Exception)
            {
                MessageBox.Show("There are no orders to be processed");
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
                con.Open();
                SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM \"Order\" where Order_Status  COLLATE Latin1_General_CS_AS LIKE 'Unprocessed'order by Order_Date Desc", con);

                var t = new DataTable();
                a.Fill(t);

                listOrders.DisplayMember = "Order_ID";
                listOrders.ValueMember = "Order_ID";
                listOrders.DataSource = t;
                con.Close();
            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
            con.Open();
            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM \"Order\" where Order_Status  COLLATE Latin1_General_CS_AS LIKE 'Unprocessed'order by Order_Date Desc", con);

            var t = new DataTable();
            a.Fill(t);

            listOrders.DisplayMember = "Order_ID";
            listOrders.ValueMember = "Order_ID";
            listOrders.DataSource = t;
            con.Close();

        }
    }
}
