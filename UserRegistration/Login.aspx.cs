using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Data;

namespace UserRegistration
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserRegistrationEntities1"].ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserRegistrationEntities1"].ToString());
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Users] where EmailAddress=@EmailAddress and Password=@Password", conn);
            cmd.Parameters.AddWithValue("@EmailAddress", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (dt.Rows.Count > 0)
            {
                Response.Redirect("RegistrationForm.aspx");
            }
            else
            {
                Label1.Text = "Your username and word is incorrect";
                Label1.ForeColor = System.Drawing.Color.Red;

            }


        }

        


    }
}