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
    public partial class customerLISTFORM : Form
    {
        public customerLISTFORM()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerLISTFORM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onlineShoppingDBDataSet.CustomerTbl' table. You can move, or remove it, as needed.
            this.customerTblTableAdapter.Fill(this.onlineShoppingDBDataSet.CustomerTbl);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
