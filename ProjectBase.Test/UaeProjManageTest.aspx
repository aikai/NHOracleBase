﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UaeProjManageTest.aspx.cs" Inherits="ProjectBase.Test.UaeProjManageTest" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
    <asp:Panel ID="Panel1" runat="server" GroupingText="Results:">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
            DataKeyNames="Id" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="GridView1_RowCancelingEdit"
            OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:CommandField HeaderText="Edit-Update" ShowEditButton="True" />
                <asp:TemplateField HeaderText="Item">
                    <ItemTemplate>
                        <%# Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" ReadOnly="True" />
                <asp:BoundField DataField="ProjCode" HeaderText="ProjCode" SortExpression="ProjCode" />
                <asp:BoundField DataField="ProjEname" HeaderText="ProjEname" SortExpression="ProjEname" />
                <asp:BoundField DataField="ProjTname" HeaderText="ProjTname" SortExpression="ProjTname" />
                <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
            </Columns>
            <RowStyle BackColor="#E3EAEB" />
            <EditRowStyle BackColor="#7C6F57" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    </asp:Panel>
</asp:Content>
