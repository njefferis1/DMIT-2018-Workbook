<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewAddresses.aspx.cs" Inherits="WebAppCRUD.Admin.ViewAddresses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>View Addresses</h1>
    <asp:GridView ID="AddressesGridView" runat="server" CssClass="table table-hover" AutoGenerateColumns="False" DataSourceID="AddressDataSource">
        <Columns>
            <asp:BoundField DataField="AddressID" HeaderText="AddressID" SortExpression="AddressID"></asp:BoundField>
            <asp:BoundField DataField="Address1" HeaderText="Address1" SortExpression="Address1"></asp:BoundField>
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City"></asp:BoundField>
            <asp:BoundField DataField="Region" HeaderText="Region" SortExpression="Region"></asp:BoundField>
            <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" SortExpression="PostalCode"></asp:BoundField>
            <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="AddressDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="listAddresses" TypeName="WestWindSystem.BLL.CRUDController"></asp:ObjectDataSource>
</asp:Content>
