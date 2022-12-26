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
    public partial class Product : Form
    {
        Functions Con;
        public Product()
        {
            InitializeComponent();
            Con = new Functions();
            ShowProduct();
        }
        private void ShowProduct()
        {
            try
            {
                string Query = "Select * from ProductTbl";
                guna2DataGridView1.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
            Customers customers = new Customers();
            customers.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            list list = new list();
            list.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (protext.Text == "" || AmountTb.Text == "" || CostTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Name = namebox.Text;
                    string Product = protext.Text;
                    string Amount = AmountTb.Text;
                    string Cost = CostTb.Text;
                    string Query = "update ProductTbl set ShippmentTime = '{0}',Product = '{1}',Cost = '{2}',Amount = '{3}',Name = '{4}'  where ProId = {5}";
                    Query = string.Format(Query, DenemeTimeTb.Value.ToString("yyyy-MM-dd"), Product, Cost, Amount,Name, Key);
                    Con.SetData(Query);
                    ShowProduct();
                    MessageBox.Show("Shopping Details Updated!");
                    CostTb.Text = "";
                    AmountTb.Text = "";
                    ProductCB.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DenemeTimeTb.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            protext.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            AmountTb.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            CostTb.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            namebox.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            if (AmountTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (protext.Text == "" || AmountTb.Text == "" || CostTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    string Name = namebox.Text;
                    string Product = protext.Text;
                    string Amount = AmountTb.Text;
                    string Cost = CostTb.Text;
                    string Query = "insert into ProductTbl values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, DenemeTimeTb.Value.ToString("yyyy-MM-dd"),Product,Cost,Amount,Name, Key);
                    Con.SetData(Query);
                    ShowProduct();
                    MessageBox.Show("Shopping Details Added!");
                    CostTb.Text = "";
                    AmountTb.Text = "";
                    ProductCB.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onlineShoppingDBDataSet.CustomerTbl' table. You can move, or remove it, as needed.
            this.customerTblTableAdapter.Fill(this.onlineShoppingDBDataSet.CustomerTbl);
            try
            {

                using (OnlineShoppingDBEntities db = new OnlineShoppingDBEntities())
                {
                    ProductCB.DataSource = db.Product_List.ToList();
                    ProductCB.ValueMember = "Id";
                    ProductCB.DisplayMember = "Products";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Product_List obj = ProductCB.SelectedItem as Product_List;
            if (obj != null)
            {

                pricelabel.Text = obj.Prices.ToString();
            }
            Cursor.Current = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Select A Product");
                }
                else
                {

                    string Query = "delete from ProductTbl where ProId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowProduct();
                    MessageBox.Show("Shopping Details Deleted!");
                    CostTb.Text = "";
                    AmountTb.Text = "";
                    protext.Text = "";
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void pricelabel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            customerLISTFORM list = new customerLISTFORM();
            list.Show();
        }
    }
}
