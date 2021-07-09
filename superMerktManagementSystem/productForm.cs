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
    public partial class productForm : Form
    {
        public productForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fatma\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into ProductTbl values(" + PordId.Text + ",'" + ProdName.Text + "'," + ProdQty.Text + "," + ProdPrice.Text + ",'"+CatCb.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                con.Close();
                Populate();
            }
            catch (Exception )
            {
                MessageBox.Show("Please review the data");
                con.Close();
            }
        }
        private void fillcmbo()
        {
            //this method will bind the combobox with database
            con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            CatCb.ValueMember = "CatName";
            CatCb.DataSource = dt;
            con.Close();
        }
        private void Populate()
        {
            con.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGN.DataSource = ds.Tables[0];
            con.Close();
        }
        private void productForm_Load(object sender, EventArgs e)
        {
            fillcmbo();
            Populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatgoriesForm cat = new CatgoriesForm();
            cat.Show();
            this.Hide(); 
        }

        private void ProdDGN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PordId.Text = ProdDGN.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProdDGN.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProdDGN.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProdDGN.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedValue = ProdDGN.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (PordId.Text == "")
                {
                    MessageBox.Show("Select The Product to Delete");
                }
                else
                {
                    con.Open();
                    string query = "delete from ProductTbl where ProdId=" + PordId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    con.Close();
                    Populate();
                }
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
                if (PordId.Text == "" || ProdName.Text == "" || ProdQty.Text == ""||ProdPrice.Text==""||CatCb.SelectedValue=="")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "update ProductTbl set ProdName='" + ProdName.Text + "',prodQty=" + ProdQty.Text + ", ProdPrice="+ProdPrice.Text+",ProdCat='"+CatCb.SelectedValue+"' where ProdId=" + PordId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updata");
                    con.Close();
                    Populate();

                }
            }
            catch (Exception )
            {
                MessageBox.Show("Please review the data");
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm seller = new SellerForm();
            seller.Show();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * form ProducTbl where ProdCat='" + comboBox2.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGN.DataSource = ds.Tables[0];
            con.Close();
        }

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
