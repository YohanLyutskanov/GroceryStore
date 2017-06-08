using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerEnterData ced = new CustomerEnterData();
            ced.ShowDialog();
            this.Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeLogIn el = new EmployeeLogIn();
            el.ShowDialog();
            this.Close();
        }
    }
}
