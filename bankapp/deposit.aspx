﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="deposit.aspx.cs" Inherits="deposit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Deposit</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Account No"></asp:Label>  <asp:TextBox ID="txtAccountNo" runat="server" Text=""></asp:TextBox>
        <asp:Button
            ID="Button1" runat="server" Text="Get" onclick="Button1_Click" />
            <br />
        <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblBalance" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Amount to Deposit"></asp:Label><asp:TextBox
            ID="txtAmount" runat="server"></asp:TextBox>
            <br />
        <asp:Button ID="Button2" runat="server" Text="Deposit" Enabled="False" 
            onclick="Button2_Click" />
    </div>
    </form>
</body>
</html>
