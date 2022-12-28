<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmDelete.aspx.cs"   MasterPageFile="~/Site.Master" Inherits="InventoryManagementApp.ConfirmDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="alert alert-info">
        <asp:Label ID="lblProductName" runat="server" />
        <br />
        <br />
        <asp:Label ID="lblPrice" runat="server" />

    </div>

    <p > Are you sure to Delete the product From the system 
        <asp:Button ID="btnYes" CssClass="btn btn-success btn-sm" Text="Yes" runat="server" OnClick="btnYes_Click" />
                <asp:Button ID="btnNo" CssClass="btn btn-danger btn-sm" Text="No" runat="server" OnClick="btnNo_Click" />

    </p>
</asp:Content>