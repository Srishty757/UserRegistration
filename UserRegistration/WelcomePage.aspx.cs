using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace UserRegistration
{
    public partial class WelcomePage : System.Web.UI.Page
    {
        #region Sql Connection  
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserRegistrationEntities1"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    BindGridView();

                }
            }
            catch (Exception ex)
            {
                
            }
        }
#endregion
        #region show message
        void clear()
        {
            txtName.Text = string.Empty; txtLName.Text = string.Empty; txtEmail.Text = string.Empty;
            txtPw.Text = string.Empty;
            txtName.Focus();
        }
        #endregion
        #region bind data to GridView
        private void BindGridView()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

               
                 SqlCommand cmd = new SqlCommand("select * from [dbo].[Users] where EmailAddress=@EmailAddress and Password=@Password", conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                GridView.DataSource = ds;
                GridView.DataBind();
                lbltotalcount.Text = GridView.Rows.Count.ToString();
                
                
                
            }
            catch (SqlException ex)
            {
                // ShowMessage(ex.Message);
            }
            
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
           
        }
        #endregion
        #region Insert Data  
        /// <summary>  
        /// this code used to Data insert in SQL Database  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserRegistrationEntities1"].ToString());
                SqlCommand cmd = new SqlCommand("select * from [dbo].[Users] where FirstName = @FirstName LastName = @LastName EmailAddress=@EmailAddress and Password=@Password", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@EmailAddress", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPw.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLName.Text);
                cmd.Parameters.AddWithValue("@FirstName", txtName.Text);
                
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                // ("Registered successfully......!");
                clear();
                BindGridView();
            }
            catch (SqlException ex)
            {
               // ShowMessage(ex.Message);
            }
            
        }

        #endregion
        #region SelectedIndexChanged  
        /// <summary>  
        /// this code used to GridViewRow SelectedIndexChanged value show textbox  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView.SelectedRow;
            lbID.Text = row.Cells[2].Text;
            txtName.Text = row.Cells[3].Text;
            txtLName.Text = row.Cells[4].Text;
            txtEmail.Text = row.Cells[5].Text;
            txtPw.Text = row.Cells[6].Text;
            btnSubmit.Visible = false;
            btnUpdate.Visible = true;
        }
        #endregion
        #region Delete Data  
        /// <summary>  
        /// This code used to GridView_RowDeleting  Data Delete  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        protected void GridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                conn.Open();
                int ID = Convert.ToInt32(GridView.DataKeys[e.RowIndex].Value);
                SqlCommand cmd = new SqlCommand("Delete From Users where ID='" + ID + "'",
conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                Label1.Text=("Data Delete Successfully......!");
                GridView.EditIndex = -1;
                BindGridView();
            }
            catch (SqlException ex)
            {
                
            }
            
        }
        #endregion
        #region  data update  
        /// <summary>  
        /// This code used to data update  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string ID = lbID.Text;
                SqlCommand cmd = new SqlCommand("Update [dbo].[Users] where ID = @ID FirstName = @FirstName LastName = @LastName " +
                    "EmailAddress=@EmailAddress and Password=@Password", conn);
                cmd.Parameters.AddWithValue("@FirstName", txtName.Text);
                cmd.Parameters.AddWithValue("@LastNae", txtLName.Text);
                cmd.Parameters.AddWithValue("@EmailAddress", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPw.Text);
                cmd.Parameters.AddWithValue("ID", ID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                Label2.Text =(" Data update Successfully......!");
                GridView.EditIndex = -1;
                BindGridView(); btnUpdate.Visible = false;
            }
            catch (SqlException ex)
            {
                
            }
      
        }
        #endregion
        #region textbox clear  
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }
        #endregion
    }
}
