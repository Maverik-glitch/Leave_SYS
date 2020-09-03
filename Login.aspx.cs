using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CodeFirstDemo
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\register.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(*) from [Table] where EmailId = ' " + TextBox1.Text + " ' and  Password = ' " + TextBox2.Text + " ' ";
            SqlCommand com = new SqlCommand(str, con);
            con.Open();
            int temp= Convert.ToInt32(com.ExecuteScalar().ToString());
            if(temp==1)
            {
                Response.Redirect("~/Crud.aspx");
            }
            else
            {
                Label3.ForeColor = System.Drawing.Color.Red; 
                Label3.Text = "Your Credentials are wrong";
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}