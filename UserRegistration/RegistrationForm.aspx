<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="UserRegistration.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
<style>
.borderless td, .borderless th {
border: none;
border-color: Red;
}

.table-condensed > thead > tr > th, .table-condensed > tbody > tr > th, .table-condensed > tfoot > tr > th, .table-condensed > thead > tr > td, .table-condensed > tbody > tr > td, .table-condensed > tfoot > tr > td {
padding: 3px;
}

input, select {
border-radius: 3px;
padding: 1px;
border: 1px solid darkgray;
}

.btnCoral {
background-color: crimson;
color: #fff;
}

body {

background: #1e5799; /* Old browsers */
background: -moz-linear-gradient(top, #1e5799 0%, #2989d8 50%, #207cca 51%, #7db9e8 100%); /* FF3.6-15 */
background: -webkit-linear-gradient(top, #1e5799 0%,#2989d8 50%,#207cca 51%,#7db9e8 100%); /* Chrome10-25,Safari5.1-6 */
background: linear-gradient(to bottom, #1e5799 0%,#2989d8 50%,#207cca 51%,#7db9e8 100%); /* W3C, IE10+, FF16+, Chrome26+, Opera12+, Safari7+ */
filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#1e5799', endColorstr='#7db9e8',GradientType=0 ); /* IE6-9 */
}

.parent-container {
background-color: black;
width:70%;
}

.container {
background-color: white;
margin:2px;
width:auto;
}

</style>
</head>

<body>
    <form id="form1" runat="server">
<asp:ScriptManager runat="server" />

        <div class="container">
            <h1>New user</h1>
            <div class="form-group">
                <label>Enter FirstName:</label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TxtFirstName" runat="server" CssClass="form-control" placeholder="Enter Username.." autofocus></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label>Enter MiddleName:</label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextMiddleName" runat="server" CssClass="form-control" placeholder="Enter MiddleName.." autofocus></asp:TextBox>
                </div>
            </div>

             <div class="form-group">
                <label>Enter LastName:</label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextLastName" runat="server" CssClass="form-control" placeholder="Enter LastName.." autofocus></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label>Enter Address:</label>
                <div class="col-sm-9">
                    <asp:TextBox ID="Address" runat="server" CssClass="form-control" placeholder="Enter Address.." autofocus></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label>Enter DOB:</label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextDOB" runat="server" CssClass="form-control" TextMode="Date" placeholder="Enter DOB.." autofocus></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label>Enter PhoneNo:</label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextPhone" runat="server" CssClass="form-control" TextMode="Number" placeholder="Enter DOB.." autofocus></asp:TextBox>
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>CountryCode
                </div>
            </div>

            <div class="form-group">
                <label>Enter City:</label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextCity" runat="server" CssClass="form-control"  placeholder="Enter City.." autofocus></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label>Education:</label>
                <div class="col-sm-9">
                   <asp:CheckBoxList ID="TextEdu" runat="server" CssClass="form-control"></asp:CheckBoxList>
                    <asp:CheckBox ID="CheckBox1" runat="server"/>Bachelors
                    <asp:CheckBox ID="CheckBox2" runat="server"/>Masters
                    <asp:CheckBox ID="CheckBox3" runat="server"/>InterMediate
                </div>
            </div>

            <div class="form-group">
                <div class="col-sm-9">
                    <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />Upload Photo            
                </div>
            </div>

             <div class="form-group">
                 <label>Gender:</label>
                <div class="col-sm-9">
                     <asp:RadioButton ID="RadMale" runat="server" CssClass="form-control" GroupName="Gender" />Male
                     <asp:RadioButton ID="RadFemale" runat="server" CssClass="form-control" GroupName="Gender" />Female
                </div>
            </>

            <div class="form-group">
                <label>Enter Email:</label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextEmail" runat="server" CssClass="form-control" TextMode="Email" placeholder="Enter Email.." autofocus></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label>Enter Password:</label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextPsw" runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter Password.." autofocus></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label>Confirm Password:</label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextCnf" runat="server" CssClass="form-control" TextMode="Password" placeholder="Confirm Password.." autofocus></asp:TextBox>
                </div>
            </div>

            
                <div class="col-sm-9">
                    <asp:Button ID="ButtonReg" runat="server" Text="Register" cssclass="btn-btn-primary btn-block" OnClick="ButtonReg_Click"/>Registration         
            </div>

            <asp:Label ID="LabUpMess" runat="server"></asp:Label>
            <asp:Label ID="LabRegMess" runat="server"></asp:Label>
            </div>

             </div>
    </form>
       
    
</body>
</html>
     </asp:Content>