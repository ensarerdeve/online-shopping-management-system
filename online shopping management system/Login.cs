using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_shopping_management_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(uNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else if(uNameTb.Text == "Admin" && PasswordTb.Text == "Password")
            {
                Customers Obj = new Customers();
                Obj.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Invalid Credentials!");
            }
        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {
            PasswordTb.PasswordChar = '*';
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
