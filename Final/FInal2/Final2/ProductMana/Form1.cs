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

namespace ProductMana
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NTBU528C\KRAKEN;Initial Catalog=ProdManager;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            con.Open();
            string Myquery = "select * from Users where email = '" + Email.Text + "' and passwords = '" + Password.Text + "' and AdminStatus = 'yes'";
            SqlDataAdapter dd = new SqlDataAdapter(Myquery, con);
            var dc = new DataTable();
            dd.Fill(dc);
            con.Close();
            if (dc.Rows.Count == 1)
            {
                if (dc.Rows[0][4].ToString() == "yes")
                {
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    label1.Text = "The user is not an Admin";
                }
            }
            else
            {
                label1.Text = "The user does not exist";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string Myquery = "select * from Users where email = '" + Email.Text + "' and passwords = '" + Password.Text + "' and AdminStatus = 'yes'";
            SqlDataAdapter dd = new SqlDataAdapter(Myquery, con);
            var dc = new DataTable();
            dd.Fill(dc);
            con.Close();
            if (dc.Rows.Count == 1)
            {
                if (dc.Rows[0][4].ToString() == "yes")
                {
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.Show();
                }
                else
                {
                    label1.Text = "The user is not an Admin";
                }
            }
            else
            {
                label1.Text = "The user does not exist";
            }
        }
    }
}
