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

namespace InventoryControl
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@""); 
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            InventoryControl userPage = new InventoryControl();
            userPage.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageCustomers userPage = new ManageCustomers();
            userPage.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Orders userPage = new Orders();
            userPage.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
