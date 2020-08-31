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
namespace hobnob4
{
    public partial class AdminPage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=3RDGENRATION;Initial Catalog=Products;Integrated Security=True");
        public AdminPage()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //
            //insert 
            con.Open();
            String str = "INSERT INTO x (P_ID, P_Name, P_Description, P_Price) Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";
            SqlDataAdapter adpt = new SqlDataAdapter(str, con);
            adpt.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Product added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
            //Select Data
            //
            con.Open();
            String str = "Select * from x";
            SqlDataAdapter adpt = new SqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
            //Delete data
            //

            con.Open();
            String str = "DELETE FROM x WHERE P_ID = '" + textBox1.Text + "'";
            SqlDataAdapter adpt = new SqlDataAdapter(str, con);
            adpt.SelectCommand.ExecuteNonQuery();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //
            // Update data
            //
            con.Open();
            String str = "UPDATE x SET P_Name = '" + textBox2.Text + "',P_Description ='" + textBox3.Text + "' ,P_Price = '" + textBox4.Text + "' WHERE P_ID= '" + textBox1.Text + "' ";
            SqlDataAdapter adpt = new SqlDataAdapter(str, con);
            adpt.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Product Updated");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Exit
            //
            this.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            String str = "Select * from Table_2   ";
            SqlDataAdapter adapt = new SqlDataAdapter("select * from x where   P_Name like '" + textBox5.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();  
        }
    }
}
