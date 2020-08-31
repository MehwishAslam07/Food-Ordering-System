using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hobnob4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Panel1.Height = HOME.Height;
            Panel1.Top = HOME.Top;
            home1.BringToFront();
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            Panel1.Height = HOME.Height;
            Panel1.Top = HOME.Top;
            home1.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Panel1.Height = Button4.Height;
            Panel1.Top = Button4.Top;
            login1.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Panel1.Height = Button4.Height;
            Panel1.Top = Button4.Top;
            register1.BringToFront();
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //
            // open Admin Form 
            //
            
     AdminLogin adm = new AdminLogin();
          adm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Height = Button4.Height;
            Panel1.Top = Button4.Top;
            menu1.BringToFront();
        }
    }
}
