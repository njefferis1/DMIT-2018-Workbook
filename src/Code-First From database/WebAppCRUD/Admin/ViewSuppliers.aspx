﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewSuppliers.aspx.cs" Inherits="WebAppCRUD.Admin.ViewSuppliers1" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="my" TagName="MessageUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>View Suppliers</h1>

    <my:MessageUserControl runat="server" ID="MessageUserControl" />

    <asp:ListView ID="SupplierListView" runat="server" 
        DataSourceID="SuppliersDataSource" 
        DataKeyNames="SupplierID"
        InsertItemPosition="FirstItem"
        ItemType="WestWindSystem.Entities.Supplier">
        <LayoutTemplate>
            <table class="table table-hover table-condensed">
                <thead>
                    <tr>
                        <th>Supplier ID</th>
                        <th>Company Name</th>
                        <th>Contact</th>
                        <th>Address</th>
                        <th>Phone / Fax</th>
                    </tr>
                </thead>
                <tbody>
                    <tr id="itemPlaceholder" runat="server"></tr>
                </tbody>
            </table>
        </LayoutTemplate>

        <InsertItemTemplate>
             <tr class="bg-success">
                <td>
                    <asp:LinkButton ID="AddSupplier" runat="server" 
                        CssClass="btn btn-success glyphicon glyphicon-plus"
                        CommandName="Insert">
                        Add
                    </asp:LinkButton>
                    <asp:LinkButton ID="CancelInsert" runat="server" 
                        CssClass="btn btn-default" CommandName="Cancel">
                        Clear
                    </asp:LinkButton>
                </td>
                <td>
                    <asp:TextBox ID="CompanyName" runat="server" 
                        Text="<%# BindItem.CompanyName %>" 
                        placeholder="Enter company name"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="Contact" runat="server" 
                        Text="<%# BindItem.ContactName %>" 
                        placeholder="contact name"></asp:TextBox>
                <br />
                    <asp:TextBox ID="JobTitle" runat="server" 
                        Text="<%# BindItem.ContactTitle %>" 
                        placeholder="Job Title"></asp:TextBox>
                <br />
                    <asp:TextBox ID="Email" runat="server" 
                        Text="<%# BindItem.Email %>" 
                        TextMode="Email"
                        placeholder="Email"></asp:TextBox>
                </td>
                 <td>
                     <asp:DropDownList ID="AddressDropDown" runat="server"
                         DataSourceID="AddressDataSource"
                         AppendDataBoundItems="true"
                         DataTextField="FullAddress"
                         DataValueField="AddressID"
                         SelectedValue="<%# BindItem.AddressID %>">
                         <asp:ListItem Value="">[Select address on file]</asp:ListItem>
                     </asp:DropDownList>
                 </td>
                 <td>
                     <asp:TextBox ID="Phone" runat="server" 
                        Text="<%# BindItem.Phone %>" 
                         TextMode="Phone"
                        placeholder="Phone"></asp:TextBox>
                 <br />
                     <asp:TextBox ID="Fax" runat="server" 
                        Text="<%# BindItem.Fax %>" 
                         TextMode="Phone"
                        placeholder="Fax"></asp:TextBox>
                 </td>
            </tr>
        </InsertItemTemplate>

           <EditItemTemplate>
             <tr class="bg-info">
                <td>
                    <asp:LinkButton ID="UpdateSupplier" runat="server" 
                        CssClass="btn btn-success glyphicon glyphicon-ok"
                        CommandName="Update">
                        Save
                    </asp:LinkButton>
                    <asp:LinkButton ID="CancelUpdate" runat="server" 
                        CssClass="btn btn-default" CommandName="Cancel">
                        Cancel
                    </asp:LinkButton>
                </td>
                <td>
                    <asp:TextBox ID="CompanyName" runat="server" 
                        Text="<%# BindItem.CompanyName %>" 
                        placeholder="Enter company name"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="Contact" runat="server" 
                        Text="<%# BindItem.ContactName %>" 
                        placeholder="contact name"></asp:TextBox>
                <br />
                    <asp:TextBox ID="JobTitle" runat="server" 
                        Text="<%# BindItem.ContactTitle %>" 
                        placeholder="Job Title"></asp:TextBox>
                <br />
                    <asp:TextBox ID="Email" runat="server" 
                        Text="<%# BindItem.Email %>" 
                        TextMode="Email"
                        placeholder="Email"></asp:TextBox>
                </td>
                 <td>
                     <asp:DropDownList ID="AddressDropDown" runat="server"
                         DataSourceID="AddressDataSource"
                         AppendDataBoundItems="true"
                         DataTextField="FullAddress"
                         DataValueField="AddressID"
                         SelectedValue="<%# BindItem.AddressID %>">
                         <asp:ListItem Value="">[Select address on file]</asp:ListItem>
                     </asp:DropDownList>
                 </td>
                 <td>
                     <asp:TextBox ID="Phone" runat="server" 
                        Text="<%# BindItem.Phone %>" 
                         TextMode="Phone"
                        placeholder="Phone"></asp:TextBox>
                 <br />
                     <asp:TextBox ID="Fax" runat="server" 
                        Text="<%# BindItem.Fax %>" 
                         TextMode="Phone"
                        placeholder="Fax"></asp:TextBox>
                </td>
            </tr>
        </EditItemTemplate>


        <ItemTemplate>
            <tr>
                <td>
                    <asp:LinkButton ID="EditSupplier" runat="server"
                        CssClass="btn btn-info glyphicon glyphicon-pencil"
                        CommandName="Edit">
                        Edit
                    </asp:LinkButton>
                    <asp:LinkButton ID="Delete" runat="server" CssClass="btn btn-danger" 
                        OnClientClick="return confirm('are you sure you want to delete this supplier?')" 
                        CommandName="Delete">
                        Delete
                    </asp:LinkButton>
                </td>
                <td><%# Item.CompanyName %></td>
                <td>
                    <b><%# Item.ContactName %></b>
                    &ndash;
                    <i><%# Item.ContactTitle %><i>
                        <br />
                    <%# Item.Email %>
                </td>
                <td>
                    <%# Item.Address.Address1 %>
                    <br />
                    <%# Item.Address.City %>
                    <%# Item.Address.Region %>
                    &nbsp;&nbsp;
                    <%# Item.Address.PostalCode %>
                    <br />
                    <%# Item.Address.Country %>
                </td>
                <td>
                    <%# Item.Phone %>
                    <br />
                    <%# Item.Fax %>
                </td>
            </tr>
        </ItemTemplate>

    </asp:ListView>

    <asp:ObjectDataSource ID="SuppliersDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="listSuppliers" TypeName="WestWindSystem.BLL.CRUDController" DataObjectTypeName="WestWindSystem.Entities.Supplier" InsertMethod="AddSupplier" OnInserted="CheckForExceptions" OnUpdated="CheckForExceptions" OnDeleted="CheckForExceptions" DeleteMethod="DeleteSupplier" UpdateMethod="UpdateSupplier"></asp:ObjectDataSource>

    <asp:ObjectDataSource ID="AddressDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="listAddresses" TypeName="WestWindSystem.BLL.CRUDController"></asp:ObjectDataSource>
</asp:Content>
