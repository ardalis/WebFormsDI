<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="WebFormsDI.Products" MasterPageFile="~/Site.Master" Title="Imperial Products" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Imperial Catalog</h1>
    <div>
        <ul>
            <asp:Repeater ID="ProductRepeater" runat="server">
                <ItemTemplate>
                    <li>
                        <%# Eval("Name") %>: <%# Eval("Price") %></li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</asp:Content>
