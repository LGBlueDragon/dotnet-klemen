<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validator.aspx.cs" Inherits="LotoWev.validator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Date: <asp:TextBox ID="Date" runat="server"></asp:TextBox>
    <br />
    Combinations:
    <asp:TextBox ID="TextBox1" runat="server" Height="27px" Width="27px"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server" Height="27px" Width="27px"></asp:TextBox>
    <asp:TextBox ID="TextBox3" runat="server" Height="27px" Width="27px"></asp:TextBox>
    <asp:TextBox ID="TextBox4" runat="server" Height="27px" Width="27px"></asp:TextBox>
    <asp:TextBox ID="TextBox5" runat="server" Height="27px" Width="27px"></asp:TextBox>
    <asp:TextBox ID="TextBox6" runat="server" Height="27px" Width="27px"></asp:TextBox>
    <asp:TextBox ID="TextBox7" runat="server" Height="27px" Width="27px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="OK" onclick="Button1_Click" />

    <asp:Label ID="PrintNum" runat="server" Text="Nothing yet"></asp:Label>
    </div>
    </form>
</body>
</html>
