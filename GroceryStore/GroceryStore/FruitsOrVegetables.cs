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
using System.Globalization;


namespace GroceryStore
{
    public partial class FruitsOrVegetables : Form
    {
        private int clientID;
        private int orderID;
        private int index;

        public FruitsOrVegetables(int clientID)
        {
            this.clientID = clientID;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("insert into \"Order\" (Client_ID, Order_Date) values ('" + clientID + "', GetDate())", con);
            SqlCommand cmd1 = new SqlCommand("select Order_ID from \"Order\" where (Client_ID = '" + clientID + "')", con);
            command.ExecuteNonQuery();
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                orderID = reader.GetInt32(0);
            }
            con.Close();
            index = 1;

            this.Hide();
            ChooseProducts cp = new ChooseProducts(clientID, orderID, index);
            cp.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("insert into \"Order\" (Client_ID, Order_Date) values ('" + clientID + "', GetDate())", con);
            SqlCommand cmd1 = new SqlCommand("select Order_ID from \"Order\" where (Client_ID = '" + clientID + "')", con);
            command.ExecuteNonQuery();
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                orderID = reader.GetInt32(0);
            }
            con.Close();
            index = 2;

            this.Hide();
            ChooseProducts cp = new ChooseProducts(clientID, orderID, index);
            cp.ShowDialog();
            this.Close();
        }
    }
}
