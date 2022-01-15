using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace Final2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            string candy = Request.Cookies["user"].Value;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cookie = Request.Cookies["user"].Value;
            con.Open();
            string Myquery = "select * from Orders where OrderID = " + OrderID.Text;
            SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
            var ds = new DataTable();
            da.Fill(ds);

            if (ds.Rows.Count < 1)
            {
                SqlCommand cmd = new SqlCommand("insert into Orders(CustomerID,OrderStatus,Payment) values(" + cookie + ",'Ongoing','" + Payment.SelectedValue + "')", con);
                cmd.ExecuteNonQuery();
            }
            
            SqlCommand cmd2 = new SqlCommand("insert into OrderDetails(OrderID,ProductID,Quantity) values(" + OrderID.Text + "," + ProdID.Text + "," + Quantity.Text + ")", con);
            cmd2.ExecuteNonQuery();
            
            string DisplayStr = "select * from OrderDetails where OrderID = " + OrderID.Text;
            SqlCommand cmd3 = new SqlCommand(DisplayStr, con);
            SqlDataReader reader = cmd3.ExecuteReader();
            OrderDisplay.DataSource = reader;
            OrderDisplay.DataBind();
            con.Close();
        }

        protected void printButton_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("order");
            cookie.Value = OrderID.Text;
            cookie.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Receipt.aspx");
        }
    }
}