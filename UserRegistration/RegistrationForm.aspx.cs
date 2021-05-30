using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


namespace UserRegistration
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click (object sender, EventArgs e)
        {
            
        }
      /*  protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
           {
                if (fileUpload.HasFile)
                {
                    string fileName = Path.GetFileName(fileUpload.PostedFile.FileName);
                    fileUpload.PostedFile.SaveAs(Server.MapPath("~/ProfileImages/") + fileName);
                    imgProfile.ImageUrl = "~/ProfileImages/" + fileName;
                }
            }
            catch (Exception ex)
            {
                // object lblInfo = null;
                // lblInfo.Text = "Image upload: " + ex.Message.ToString();
            }
        }*/
         
        protected void ButtonReg_Click(object sender, EventArgs e)
        {
            if (FileUpload1.PostedFile != null)
            {
                string strpath = Path.GetExtension(FileUpload1.PostedFile.FileName);
                if (strpath != "jpg" && strpath != "jpg" && strpath != "jpeg" && strpath != "gif" && strpath != "png")
                {
                    LabUpMess.Text = "Only Image Type = .jpg, .jpeg, .gif, .png is allowed";
                    LabUpMess.ForeColor = System.Drawing.Color.Red;
                }

                else
                {
                    LabUpMess.Text = "Profile Image is saved";
                    LabUpMess.ForeColor = System.Drawing.Color.Green;
                }
                string fileImg = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/UserImages/" + fileImg));

               
                
                string gender = string.Empty;
                if (RadMale.Checked)
                {
                    gender = "M";
                }
                else
                {
                    gender = "F";
                }
                string mainconn = ConfigurationManager.ConnectionStrings["UserRegistrationEntities1"].ConnectionString;
                SqlConnection sqlConn = new SqlConnection(mainconn);
                string sqlquery = "insert into [dbo].[Users]" +
                    " (FirstName,MiddleName,LastName,Address,Gender,DOB,EmailAddress," +
                    "Education,Password,ImageName,)" +
                    "values (@FirstName,@MiddleName,@LastName,@Address,@Gender,@DOB,@EmailAddress,@Education,@Password," +
                    ",@ImageName)";

                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlConn);
                sqlConn.Open();
                sqlcomm.Parameters.AddWithValue("@FirstName", TxtFirstName.Text);
                sqlcomm.Parameters.AddWithValue("@MiddleName", TextMiddleName.Text);
                sqlcomm.Parameters.AddWithValue("@LastName", TextLastName.Text);
                sqlcomm.Parameters.AddWithValue("@Address", Address.Text);
                sqlcomm.Parameters.AddWithValue("@Gender", gender);
                sqlcomm.Parameters.AddWithValue("@DOB", TextDOB.Text);
                sqlcomm.Parameters.AddWithValue("@EmailAddress", TextEmail.Text);
              // sqlcomm.Parameters.AddWithValue("@PhoneNo", TextPhone.Text);
               // sqlcomm.Parameters.AddWithValue("@CountryCode",DropDownList1.Text);
                // sqlcomm.Parameters.AddWithValue("@city", TextCity.Text);
                sqlcomm.Parameters.AddWithValue("@Education", TextEdu.Text);
                sqlcomm.Parameters.AddWithValue("@Password", TextPsw.Text);
                sqlcomm.Parameters.AddWithValue("@ImageName", "~/UserImages/" + fileImg);
                sqlcomm.ExecuteNonQuery();
                LabRegMess.Text = "User" + TxtFirstName.Text + "Is Saved Successfully :" ;
            }
            else
            {
                LabRegMess.Text = "Record Not saved";
           
            }
        }
    }
}
