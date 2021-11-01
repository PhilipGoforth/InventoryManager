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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            UserNameBox.Text = "";
            PasswordBox.Text = "";
        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowPasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPasswordCheck.Checked == true)
            {
                PasswordBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordBox.UseSystemPasswordChar = false;
            }
        }
    }
}
