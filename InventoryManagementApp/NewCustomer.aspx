<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewCustomer.aspx.cs" Inherits="InventoryManagementApp.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1> Add a New Customer Here!!</h1>

     <div class="form-group">
    <asp:Label ID="lblCustomerName" runat="server" Text="Enter Customer Name : " />
    <asp:TextBox ID="txtCustomerName" CssClass="form-control" runat="server" />
         <br />
         <br />
         <asp:RequiredFieldValidator ID="rfvCustomerName" ValidationGroup="gv1" runat="server" ControlToValidate="txtCustomerName" ErrorMessage="Customer Name is mandatory " CssClass="bg-danger alert alert-danger" />
         </div>
    
     <div class="form-group">
    <asp:Label ID="lblEmail" runat="server" Text="Enter Email : " />
    <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" />
            <br />
         <br />
         <asp:RegularExpressionValidator ID="rgEmail" ValidationGroup="gv1" runat="server" ErrorMessage="Email is not Valid" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="bg-danger alert alert-danger"></asp:RegularExpressionValidator>         
  </div>
     <div class="form-group">
    <asp:Label ID="lblMobile" runat="server" Text="Enter Customer Mobile : " />
    <asp:TextBox ID="txtMobile" CssClass="form-control" runat="server" />
         <asp:RegularExpressionValidator ID="rgPhone" ValidationGroup="gv1" runat="server" ErrorMessage="Enter a Valid Phone Number" ControlToValidate="txtMobile" ValidationExpression="[6789][0-9]{9}" CssClass="bg-danger alert alert-danger"></asp:RegularExpressionValidator>
   </div>
     <div class="form-group">
    <asp:Label ID="lblPassowrd" runat="server" Text="Enter Password : " />
    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" />
         </div>

       <div class="form-group">
    <asp:Label ID="lblCPassword" runat="server" Text="Confirm Password : " />
    <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="form-control" />
         </div>

    <asp:CompareValidator ID="cvPassword" runat="server" ValidationGroup="gv1" ControlToValidate="txtPassword" ControlToCompare="txtConfirmPassword" ErrorMessage="Password mismatch with Confirm password"></asp:CompareValidator>

        <asp:Button ID="btnCreateCustomer" runat="server" Text="Add New " CssClass="btn btn-primary" ValidationGroup="gv1"/>

    <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="btn btn-info" />


</asp:Content>
