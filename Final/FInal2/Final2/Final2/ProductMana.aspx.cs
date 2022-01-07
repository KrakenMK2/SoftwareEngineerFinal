using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Final2
{
    
    public partial class UserMana : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();


            string DisplayStr = "select * from Products where ProductID = '" + proid.Text + "';";
            SqlCommand cmd = new SqlCommand(DisplayStr, con);
            SqlDataReader reader = cmd.ExecuteReader();
            Products.DataSource = reader;
            Products.DataBind();
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            var Now = DateTime.Now.ToString("yyyy-MM-dd");
            string query = "insert into Products(ProductName, Price, LastStocked) values('" + proname.Text + "'," + price.Text + ",'" + Now + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from Products where ProductID = "+ proid.Text +";";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}