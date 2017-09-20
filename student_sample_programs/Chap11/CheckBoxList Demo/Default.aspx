<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CheckBoxListBox Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>CheckBoxList Demo</h1>    
Ben's Coffee shop
        <p />
    </div>
        <asp:CheckBoxList ID="chkDrinks" runat="server" 
            Height="100px" Width="175px" BorderWidth="1px">
            <asp:ListItem>Plain coffee</asp:ListItem>
            <asp:ListItem>Cappucino</asp:ListItem>
            <asp:ListItem>Latte</asp:ListItem>
            <asp:ListItem>Espresso</asp:ListItem>
            <asp:ListItem>Cafe au Lait</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Confirm" Width="69px" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </form>
</body>
</html>
