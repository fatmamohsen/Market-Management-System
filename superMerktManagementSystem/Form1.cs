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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Sellername = "";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fatma\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PassTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text ==""||PassTb.Text=="")
            {
                MessageBox.Show("Enter the UserName And Password");
            }
            else
            {
                if(RoleCb.SelectedIndex> -1)
                {
                    if (RoleCb.SelectedItem.ToString() == "Admin")
                    {
                        if (UnameTb.Text == "Admin" && PassTb.Text == "Admin")
                        {
                            productForm prod = new productForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you ara tha admin, enter the correct Name and Password");
                        }
                    }
                    else
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from SellerTbl where SellerName='" + UnameTb.Text + "' and SellerPass='" + PassTb.Text + "'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            Sellername = UnameTb.Text;
                            SellingForm selling = new SellingForm();
                            selling.Show();
                            this.Hide();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong UserName or Password");
                        }
                        con.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Select A Role");
                } 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
