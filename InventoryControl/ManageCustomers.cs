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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            InventoryControl userPage = new InventoryControl();
            userPage.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageUsers userPage = new ManageUsers();
            userPage.Show();
            this.Hide();
        }
    }
}
