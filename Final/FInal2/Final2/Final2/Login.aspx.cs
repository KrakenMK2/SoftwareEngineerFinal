using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Final2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            con.Open();
            string Myquery = "select * from Customers where email = '" + Email.Text + "' and passwords = '" + Password.Text + "'";
            SqlDataAdapter dd = new SqlDataAdapter(Myquery, con);
            var dc = new DataTable();
            dd.Fill(dc);
            
            if (dc.Rows.Count == 1)
            {
                HttpCookie cookie = new HttpCookie("user");
                cookie.Value = dc.Rows[0]["CustomerID"].ToString();
                cookie.Expires = DateTime.Now.AddHours(1);
                Response.Cookies.Add(cookie);
                Response.Redirect("Order.aspx");
            }
            con.Close();


        }

        protected void Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}