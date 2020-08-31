using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace hobnob4
{
    public partial class login : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=3RDGENRATION;Initial Catalog=Products;Integrated Security=True;");
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Login Button
            String str1 = "select Email,Password from Reg_2 where Email = '" + textBox1.Text.Trim() + "' and Password= '" + textBox2.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(str1, con);
            SqlDataAdapter da = new SqlDataAdapter(str1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(" Login successfull");

         
            }
            else
            {
                MessageBox.Show("invalid Login");
            }
        }
    }
}
