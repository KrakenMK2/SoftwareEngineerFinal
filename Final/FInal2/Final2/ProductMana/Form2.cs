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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NTBU528C\KRAKEN;Initial Catalog=ProdManager;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prodManagerDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.prodManagerDataSet.Products);

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();


            string DisplayStr = "select * from Products where ProductID = '" + productIDTextBox.Text + "';";
            SqlDataAdapter da = new SqlDataAdapter(DisplayStr, con);
            var ds = new DataTable();
            da.Fill(ds);
            Products.DataSource = ds;
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            var Now = DateTime.Now.ToString("yyyy-MM-dd");
            string query = "insert into Products(ProductName, Price, LastStocked) values('" + proname.Text + "'," + priceTextBox.Text + ",'" + Now + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from Products where ProductID = " + productIDTextBox.Text + ";";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
