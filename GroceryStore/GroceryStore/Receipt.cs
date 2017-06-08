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
    public partial class Receipt : Form
    {
        private int orderID;
        private int clientID;
        private string clientName;
        private string totalPrice;

        public Receipt(int orderID, int clientID, string totalPrice)
        {
            this.orderID = orderID;
            this.clientID = clientID;
            this.totalPrice = totalPrice;
            InitializeComponent();

            //Create columns in Shopping cart table
            SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Product_Name as Product, Product_Quantity as \"Quantity (kg)\" FROM Product AS p JOIN Product_Order AS po ON p.Product_ID = po.Product_ID JOIN \"Order\" AS o ON po.Order_ID = o.Order_ID WHERE o.Client_ID='" + clientID + "'", con1);
            DataTable data = new DataTable();
            sda.Fill(data);

            var commandBuilder = new SqlCommandBuilder(sda);
            var dts = new DataSet();
            sda.Fill(dts);
            dataGridView2.ReadOnly = true;


            dataGridView2.DataSource = dts.Tables[0];
            dataGridView2.AutoGenerateColumns = false;





            // Select Order_ID and Client_Name
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Client_Name from Client where (Client_ID = '" + clientID + "')", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clientName = reader.GetString(0);
            }
            con.Close();

            lblOrderNumber.Text = orderID.ToString();
            lblCustomerName.Text = clientName;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  \"Order\" set  Order_Status = \'Unprocessed\' where Order_ID = '" + orderID + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();

            //SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
            //con1.Open();
            //SqlCommand cmd1 = new SqlCommand("delete from  \"Order\"  where Order_Status like null", con1);
            //cmd1.ExecuteNonQuery();
            //con1.Close();

            this.Hide();
            CustomerEnterData ced = new CustomerEnterData();
            ced.ShowDialog();
            this.Close();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            lblTotalPrice.Text = totalPrice;
        }
    }
}
