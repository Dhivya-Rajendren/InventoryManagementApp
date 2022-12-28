<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewProduct.aspx.cs"  MasterPageFile="~/Site.Master" Inherits="InventoryManagementApp.NewProduct" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1> Add a New Product Here!!</h1>

     <div class="form-group">
    <asp:Label ID="lblProductName" runat="server" Text="Enter Product Name : " />
    <asp:TextBox ID="txtProductName" CssClass="form-control" runat="server" />
         <br />
         <br />
         <asp:RequiredFieldValidator ID="rfvProductName" runat="server" ControlToValidate="txtProductName" ErrorMessage="Product Name is mandatory " CssClass="bg-danger alert alert-danger" />
         </div>
    
     <div class="form-group">
    <asp:Label ID="lblCategory" runat="server" Text="Enter Category : " />
    <asp:TextBox ID="txtCategory" CssClass="form-control" runat="server" />
            <br />
         <br />
         <asp:RequiredFieldValidator ID="rfvCategory" runat="server" ControlToValidate="txtCategory" ErrorMessage="Category is mandatory " CssClass="bg-danger alert alert-danger" />
         
  </div>
     <div class="form-group">
    <asp:Label ID="lblCode" runat="server" Text="Enter Product Code : " />
    <asp:TextBox ID="txtProductCode" CssClass="form-control" runat="server" />
   </div>
     <div class="form-group">
    <asp:Label ID="lblPrice" runat="server" Text="Enter Product Price : " />
    <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" />
         </div>
  <div class="form-group">
          <asp:Label ID="lblProductImage" runat="server" Text="Select a Product Image " />
      <asp:FileUpload ID="fuProductImage" runat="server" />
   

  </div>
        <asp:Button ID="btnCreateProduct" runat="server" Text="Add New " CssClass="btn btn-primary" OnClick="btnCreateProduct_Click" />

    </asp:Content>