﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ProductList.aspx.cs" Inherits="InventoryManagementApp.ProductList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <h3 class="alert alert-warning text-center"> Product Details</h3>


    <asp:Button ID="btnNewProduct" runat="server" Text="Create New " CssClass="btn btn-primary" OnClick="btnNewProduct_Click" />
    <br />
    <br />

    <asp:GridView ID="gvProducts" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false">
  <Columns>
      <asp:TemplateField HeaderText="Name">
         <ItemTemplate>
             <asp:Label ID="lblProductName" Text='<%#Eval("ProductName") %>'  runat="server"/>
         </ItemTemplate>
      </asp:TemplateField>
      <asp:TemplateField HeaderText="Category">
          <ItemTemplate>
         <asp:label ID="lblCategory" Text='<%#Eval("Category") %>' runat="server" />
          </ItemTemplate>
      </asp:TemplateField>
        <asp:TemplateField HeaderText="Product Code">
          <ItemTemplate>
              <asp:Label ID="lblCode" Text='<%#Eval("ProductCode") %>' runat="server" />
          </ItemTemplate>
      </asp:TemplateField>
        <asp:TemplateField HeaderText="Price">
          <ItemTemplate>
              <asp:Label ID="lblPrice" Text='<%#Eval("SellingPrice") %>' runat="server" />
          </ItemTemplate>
      </asp:TemplateField>

  </Columns>

    </asp:GridView>

</asp:Content>
