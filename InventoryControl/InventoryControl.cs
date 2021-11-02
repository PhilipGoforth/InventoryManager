using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryControl
{
    public partial class InventoryControl : Form
    {
        public InventoryControl()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageCustomers userPage = new ManageCustomers();
            userPage.Show();
            this.Hide();
        }

        private void InventoryControl_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageUsers userPage = new ManageUsers();
            userPage.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Orders userPage = new Orders();
            userPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
