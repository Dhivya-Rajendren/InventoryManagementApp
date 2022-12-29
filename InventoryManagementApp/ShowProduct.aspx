<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowProduct.aspx.cs" Inherits="InventoryManagementApp.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />

    <div class="card">
        <div class="card-header">
            <asp:Label ID="lblProductName" runat="server" />
        </div>
        <asp:Image ID="imgProduct" runat="server" CssClass="card-img" />
        <div class="card-body">
            <asp:Label ID="lblCategory" runat="server" />
        </div>
    </div>
</asp:Content>
