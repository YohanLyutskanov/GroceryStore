using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class CustomerEnterData : Form
    {
        private int clientID = 0;
        public CustomerEnterData()
        {
            InitializeComponent();
        }

        private void checkHomeDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHomeDelivery.Checked == true)
            {
                txtEnterAddress.Enabled = true;
                lblEnterAddres.Enabled = true;
            }
            else
            {
                txtEnterAddress.Enabled = false;
                txtEnterAddress.Text = "";
                lblEnterAddres.Enabled = false;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (txtEnterName.Text == "" || (checkHomeDelivery.Checked == true && txtEnterAddress.Text == ""))
            {
                MessageBox.Show("Please fill the required fields");
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P74G1IQ\SQLEXPRESS;Initial Catalog=GroceryStore;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Client (Client_Name, Client_Address) values ('" + txtEnterName.Text + "', '" + txtEnterAddress.Text + "') SELECT scope_identity()", con);
            var newIdentity = cmd.ExecuteScalar().ToString();
            clientID = Int32.Parse(newIdentity);
            con.Close();


            this.Hide();
            FruitsOrVegetables fv = new FruitsOrVegetables(clientID);
            fv.ShowDialog();
            this.Close();

        }
    }
}
