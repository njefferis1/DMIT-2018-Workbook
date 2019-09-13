<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewCategories.aspx.cs" Inherits="WebAppCRUD.Admin.ViewCategories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>View Categories</h1>
    <asp:GridView ID="CategoryGridView" runat="server" CssClass="table table-hover" AutoGenerateColumns="False" DataSourceID="CategoryDataSource">
        <Columns>
            <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID"></asp:BoundField>
            <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" SortExpression="CategoryName"></asp:BoundField>
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description"></asp:BoundField>
            <asp:BoundField DataField="PictureMimeType" HeaderText="PictureMimeType" SortExpression="PictureMimeType"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="CategoryDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="listCategories" TypeName="WestWindSystem.BLL.CRUDController"></asp:ObjectDataSource>
</asp:Content>
