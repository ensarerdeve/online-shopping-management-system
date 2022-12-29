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
    public partial class Customers : Form
    {
        Functions Con;
        public Customers()
        {
            InitializeComponent();
            Con = new Functions();
            ShowCustomers();
        }

        private void ShowCustomers()
        {
            try
            {
                string Query = "Select * from CustomerTbl";
                CustomerList.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        int Key = 0;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustNameTb.Text = CustomerList.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = CustomerList.SelectedRows[0].Cells[2].Value.ToString();
            AddressTb.Text = CustomerList.SelectedRows[0].Cells[3].Value.ToString();
            DenemeTimeTb.Text = CustomerList.SelectedRows[0].Cells[4].Value.ToString();
            GenderCb.SelectedItem = CustomerList.SelectedRows[0].Cells[5].Value.ToString();
            ProTb.Text = CustomerList.SelectedRows[0].Cells[6].Value.ToString();
            if(CustNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CustomerList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustNameTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "" || ProTb.Text == "" || GenderCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Name = CustNameTb.Text;
                    string Phone = PhoneTb.Text;
                    string Address = AddressTb.Text;
                    string Amount = GenderCb.SelectedItem.ToString();
                    string Product = ProTb.Text;
                    string Query = "insert into CustomerTbl values('{0}','{1}','{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query, Name, Phone, Address,DenemeTimeTb.Value.ToString("yyyy-MM-dd"), Amount, Product);
                    Con.SetData(Query);
                    ShowCustomers();
                    MessageBox.Show("Customer Added!");
                    CustNameTb.Text = "";
                    PhoneTb.Text = "";
                    ProTb.Text = "";
                    AddressTb.Text = "";
                    GenderCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Select A Customer");
                }
                else
                {

                    string Query = "delete from CustomerTbl where CustomerId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowCustomers();
                    MessageBox.Show("Customer Deleted!");
                    CustNameTb.Text = "";
                    PhoneTb.Text = "";
                    ProTb.Text = "";
                    AddressTb.Text = "";
                    GenderCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustNameTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "" || ProTb.Text == "" || GenderCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Name = CustNameTb.Text;
                    string Phone = PhoneTb.Text;
                    string Address = AddressTb.Text;
                    string Amount = GenderCb.SelectedItem.ToString();
                    string Product = ProTb.Text;
                    string Query = "update CustomerTbl set CustomerName = '{0}',CustomerPhone = '{1}',CustomerAddress = '{2}',CustomerBirthday = '{3}',CustomerAmount = '{4}',CustomerProduct = '{5}' where CustomerId = {6}";
                    Query = string.Format(Query, Name, Phone, Address, DenemeTimeTb.Value.ToString("yyyy-MM-dd"), Amount, Product, Key);
                    Con.SetData(Query);
                    ShowCustomers();
                    MessageBox.Show("Customer Updated!");
                    CustNameTb.Text = "";
                    PhoneTb.Text = "";
                    ProTb.Text = "";
                    AddressTb.Text = "";
                    GenderCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
            Product product = new Product();
            product.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DenemeTimeTb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            list list = new list();
            list.Show();
        }
    }
}
