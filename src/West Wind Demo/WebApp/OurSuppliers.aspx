<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OurSuppliers.aspx.cs" Inherits="WebApp.OurSuppliers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">Our Suppliers</h1>

    <div class="row">
        <div class="col-md-12">
            <asp:Repeater ID="SupplierRepeater" runat="server" DataSourceID="SupplierDataSource">
                <ItemTemplate>


                </ItemTemplate>

            </asp:Repeater>


        </div>
    </div>

    <asp:ObjectDataSource ID="SupplierDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListSuppliersNameAndId" TypeName="WestWindSystem.BLL.ProductManagementController"></asp:ObjectDataSource>
</asp:Content>
