using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superMerktManagementSystem
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        int starpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starpoint += 1;
            Myprogress.Value = starpoint;
            if(Myprogress.Value==100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
