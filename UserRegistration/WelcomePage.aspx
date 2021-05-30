<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePage.aspx.cs" Inherits="UserRegistration.WelcomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <table>  
        <tr>  
            <td class="td">FirstName:</td>  
            <td>  
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>  
            <td>  
                <asp:Label ID="lbID" runat="server" Visible="false"></asp:Label> </td>  
        </tr>  
        <tr>  
            <td class="td">LastName:</td>  
            <td>  
                <asp:TextBox ID="txtLName" runat="server"></asp:TextBox></td>  
            <td> </td>  
        </tr>  
        <tr>  
            <td class="td">EmailId:</td>  
            <td>  
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>  
            <td> </td>  
        </tr>  
        <tr>  
            <td class="td">Password</td>  
            <td>  
                <asp:TextBox ID="txtPw" runat="server"></asp:TextBox></td>  
            <td> </td>  
        </tr>  
        <tr>  
            <td></td>  
            <td>  
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />  
                <asp:Button ID="btnUpdate" runat="server" Text="Update" Visible="false"  
OnClick="btnUpdate_Click" />  
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" /></td>  
            <td></td>  
        </tr>  
    </table>  
  
    <div style="padding: 10px; margin: 0px; width: 100%;">  
        <p>  
            TotalUser:<asp:Label ID="lbltotalcount" runat="server" Font-Bold="true"></asp:Label>  
        </p>  
        <asp:GridView ID="GridView" runat="server" DataKeyNames="SID"   
            OnSelectedIndexChanged="GridView_SelectedIndexChanged"  
OnRowDeleting="GridView_RowDeleting">  
            <Columns>  
                <asp:CommandField HeaderText="Update" ShowSelectButton="True" />  
                <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />  
            </Columns>  
        </asp:GridView>  
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </div>  


       </div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
    
</body>
</html>
