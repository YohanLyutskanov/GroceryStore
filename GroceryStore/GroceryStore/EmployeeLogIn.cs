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
    public partial class EmployeeLogIn : Form
    {
        private int employeeID;
        public EmployeeLogIn()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please provide Username and Password");
                return;
            }

            SqlCommand cmd = new SqlCommand("Select Employee_ID from Employee where Employee_Username COLLATE Latin1_General_CS_AS LIKE @username and Employee_Password COLLATE Latin1_General_CS_AS LIKE @password", con);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            con.Open();
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    employeeID = reader.GetInt32(0);
                }

                this.Hide();
                Orders ord = new Orders(employeeID);
                ord.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();

        }
    }
}
