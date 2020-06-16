﻿<%@ Page Title="ThinClientApp" Language="C#" MasterPageFile="~/ShopSite.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ThinClientApp.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Available Products</h2>
    <p>
        <asp:GridView ID="ProductGridView" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataKeyNames="ProductNo" DataSourceID="ProductDataSource" ForeColor="Black">
            <Columns>
                <asp:BoundField DataField="ProductNo" HeaderText="Product No" ReadOnly="True" SortExpression="ProductNo" />
                <asp:BoundField DataField="Price" HeaderText="Unit Price" SortExpression="Price" />
                <asp:BoundField DataField="Stock" HeaderText="Current Stock" SortExpression="Stock" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />

        </asp:GridView>
        <asp:ObjectDataSource ID="ProductDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="ThinClientApp.Models.ShopDataSetTableAdapters.ProductTableAdapter"></asp:ObjectDataSource>
    </p>
    <asp:HyperLink Text="Customer Log In" NavigateUrl="~/Customer.aspx" runat="server" />
</asp:Content>
