﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="WebFormsDI.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products</title>
</head>
<body>
    <h1>Imperial Catalog</h1>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>
