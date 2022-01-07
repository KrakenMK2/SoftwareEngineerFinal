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
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Registation_Click(object sender, EventArgs e)
        {
            con.Open();
            int passLen = password.MaxLength;
            if (passLen >= 8)
            {
                string query = "insert into Customers(CustomerName,email,passwords) values('" + Username.Text + "','" + email.Text + "','" + password.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                
            }
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}