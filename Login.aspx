<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CodeFirstDemo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </h1>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="EMail ID"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 6px" Width="155px" Height="22px"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 2px" Width="156px" OnTextChanged="TextBox2_TextChanged" Height="23px" TextMode="Password"></asp:TextBox>
        &nbsp;<p>
&nbsp;<asp:Button ID="Button1" runat="server" Height="28px" OnClick="Button1_Click" Text="Login" Width="200px" style="margin-left: 0px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Height="31px" PostBackUrl="~/RegistrationPage.aspx" style="margin-left: 1px" Text="New User  Register Now" Width="204px" />
        </p>
        <p>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
