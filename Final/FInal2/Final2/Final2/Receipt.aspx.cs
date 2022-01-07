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
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            string cookie = Request.Cookies["order"].Value;
            con.Open();
            string DisplayStr = "select p.ProductName, p.Price, od.Quantity from Products as p LEFT JOIN OrderDetails as od on p.ProductID = od.ProductID where od.OrderID = " + cookie;
            SqlCommand cmd = new SqlCommand(DisplayStr, con); 
            SqlDataReader reader = cmd.ExecuteReader();
            Receipt.DataSource = reader;
            Receipt.DataBind();
            con.Close();
        }
    }
}