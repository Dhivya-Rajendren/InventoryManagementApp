<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="InventoryManagementApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-top:100px;margin-left:50px">
            <asp:Login ID="Login1" runat="server" LoginButtonText="SignIn" LoginButtonStyle-CssClass="btn btn-primary" OnAuthenticate="Login1_Authenticate" cre>

            </asp:Login>
        </div>
        <asp:Button ID="btnNewReg" runat="server" Text="NewUser" OnClick="btnNewReg_Click" />
    </form>
</body>
</html>
