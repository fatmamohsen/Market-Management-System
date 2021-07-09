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
    public partial class CatgoriesForm : Form
    {
        public CatgoriesForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fatma\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdTb.Text == "" || CatName.Text == "" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "update CategoryTbl set CatName='" + CatName.Text + "',CatDesc='" + CatDescTb.Text + "' where CatId=" + CatIdTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updata");
                    con.Close();
                    Populate();
                    CatIdTb.Text = "";
                    CatName.Text = "";
                    CatDescTb.Text = "";
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatIdTb.Text=="")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from CategoryTbl where CatId=" + CatIdTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    con.Close();
                    Populate();
                    CatIdTb.Text = "";
                    CatName.Text = "";
                    CatDescTb.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into CategoryTbl values(" + CatIdTb.Text + ",'" + CatName.Text + "','" + CatDescTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                con.Close();
                Populate();
                CatIdTb.Text = "";
                CatName.Text = "";
                CatDescTb.Text = "";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Populate()
        {
            con.Open();
            string query ="select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void CatgoriesForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatName.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productForm pro = new productForm();
            pro.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
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
    }
}
