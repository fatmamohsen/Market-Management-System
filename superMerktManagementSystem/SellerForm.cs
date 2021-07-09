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

namespace superMerktManagementSystem
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fatma\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Sid.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            Sname.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            Sage.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            Sphone.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            Spass.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into SellerTbl values(" + Sid.Text + ",'" + Sname.Text + "'," + Sage.Text + "," + Sphone.Text + ",'" + Spass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
                con.Close();
                Populate();
                Sid.Text = "";
                Sname.Text = "";
                Sage.Text = "";
                Sphone.Text = "";
                Spass.Text = "";
            }
            catch (Exception )
            {
                MessageBox.Show("Please review the data");
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sid.Text == "" || Sname.Text == "" || Sage.Text == "" || Sphone.Text == "" || Spass.Text== "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "update SellerTbl set SellerName='" + Sname.Text + "',SellerAge=" + Sage.Text + ", SellerPhon=" + Sphone.Text + ",SellerPass='" +Spass.Text + "' where SellerId=" + Sid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Information Successfully Updata");
                    con.Close();
                    Populate();
                    Sid.Text = "";
                    Sname.Text = "";
                    Sage.Text = "";
                    Sphone.Text = "";
                    Spass.Text = "";
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Please review the data");
                con.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sid.Text == "")
                {
                    MessageBox.Show("Select The Seller to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from SellerTbl where SellerId=" + Sid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    con.Close();
                    Populate();
                    Sid.Text = "";
                    Sname.Text = "";
                    Sage.Text = "";
                    Sphone.Text = "";
                    Spass.Text = "";

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please review the data");
                con.Close();
            }
        }
        private void Populate()
        {
            con.Open();
            string query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void SellerForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productForm prod = new productForm();
            prod.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatgoriesForm cat = new CatgoriesForm();
            cat.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
