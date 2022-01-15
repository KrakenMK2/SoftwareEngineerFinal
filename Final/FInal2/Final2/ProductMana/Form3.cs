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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NTBU528C\KRAKEN;Initial Catalog=ProdManager;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prodManagerDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text == null || email.Text == null || password.Text == null)
            {
                label1.Text = "You need to fill in all the fields";
            }
            con.Open();
            int passLen = password.MaxLength;
            if (passLen >= 8)
            {
                if (checkBox1.Checked)
                {
                    string query = "insert into Users(CustomerName,email,passwords,AdminStatus) values('" + Username.Text + "','" + email.Text + "','" + password.Text + "','yes')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
                else
                {
                    string query = "insert into Users(CustomerName,email,passwords,AdminStatus) values('" + Username.Text + "','" + email.Text + "','" + password.Text + "','no')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
            }
            else
            {
                label1.Text = "Your password is too short";
            }
            con.Close();
        }
    }
}
