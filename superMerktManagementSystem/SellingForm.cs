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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fatma\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Populate()
        {
            con.Open();
            string query = "select ProdName,ProdQty from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Populatebills()
        {
            con.Open();
            string query = "select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillsDGV.DataSource = ds.Tables[0];
            con.Close();
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
        private void SellingForm_Load(object sender, EventArgs e)
        {
            Populate();
            Populatebills();
            fillcmbo();
            SellerNamelbl.Text = Form1.Sellername;
        }
        

        private void PordId_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void ProdDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Text = ProdDGV1.SelectedRows[0].Cells[0].Value.ToString();
            ProdPrice.Text = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();
            
        }
        int Grdtotal = 0,n = 0;

        private void button6_Click(object sender, EventArgs e)
        {
            if (BillID.Text == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into BillTbl values(" + BillID.Text + ",'" + SellerNamelbl.Text + "','" + Datelbl.Text + "'," + Amtbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    con.Close();
                    Populatebills();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please review the data");
                    con.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
             if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("MAMES SuperMarket", new Font("Century Gothic",25,FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID: "+BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100,70));
            e.Graphics.DrawString("Seller Name: " + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100, 100));
            e.Graphics.DrawString("Date: " + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100, 160));
            e.Graphics.DrawString("CodeSpace", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Red, new Point(270,230));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string query = "select ProdName,ProdQty from ProductTbl where ProdCat='" + CatCb.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ProdName.Text == "" || ProdQty.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdName.Text;
                newRow.Cells[2].Value = ProdPrice.Text;
                newRow.Cells[3].Value = ProdQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                OrderDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                Amtbl.Text = "" + Grdtotal;
            }
        }
    }
}
