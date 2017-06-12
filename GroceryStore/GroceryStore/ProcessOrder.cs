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
    public partial class ProcessOrder : Form
    {
        private int employeeID;
        private int orderID;
        private string clientName;
        private decimal first = 0;
        private decimal second = 0;
        private decimal totalPrice = 0;



        public ProcessOrder(int employeeID, int orderID)
        {
            this.employeeID = employeeID;
            this.orderID = orderID;

            InitializeComponent();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Client_Name from Client as c JOIN \"Order\" as o ON c.Client_ID=o.Client_ID where (Order_ID = '" + orderID + "')", con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clientName = reader.GetString(0);
            }

            con.Close();

            SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");

            con1.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT Product_Price, Product_Quantity  FROM Product AS p JOIN Product_Order AS po ON p.Product_ID = po.Product_ID JOIN \"Order\" AS o ON po.Order_ID = o.Order_ID WHERE o.Order_ID='" + orderID + "'", con1);

            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                first = reader1.GetDecimal(0);
                second = reader1.GetDecimal(1);
                totalPrice += first * second;
            }

            con1.Close();

            //Show all the products in the order
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
            con2.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Product_Name as Product, Product_Quantity as \"Quantity (kg)\" FROM Product AS p JOIN Product_Order AS po ON p.Product_ID = po.Product_ID JOIN \"Order\" AS o ON po.Order_ID = o.Order_ID WHERE o.Order_ID='" + orderID + "'", con2);
            DataTable data = new DataTable();
            sda.Fill(data);

            var commandBuilder = new SqlCommandBuilder(sda);
            var dts = new DataSet();
            sda.Fill(dts);
            dataGridView1.ReadOnly = true;
            
            dataGridView1.DataSource = dts.Tables[0];
            dataGridView1.AutoGenerateColumns = false;

            con2.Close();

        }

        private void btnSelectOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders o = new Orders(employeeID);
            o.ShowDialog();
            this.Close();
        }

        private void ProcessOrder_Load(object sender, EventArgs e)
        {
            lblOrderNumber.Text = orderID.ToString();
            lblClientName.Text = clientName;
            lblTotalPrice.Text = totalPrice.ToString("0.00");
        }
    }
}
