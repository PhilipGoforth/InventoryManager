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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageCustomers userPage = new ManageCustomers();
            userPage.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageUsers userPage = new ManageUsers();
            userPage.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InventoryControl userPage = new InventoryControl();
            userPage.Show();
            this.Hide();
        }
    }
}
