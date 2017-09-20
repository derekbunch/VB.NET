<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DropDownList Demo</title>
</head>
<body>
    <form id="form1" runat="server">

    <h1>DropDownList Demo</h1>  
          
Select a Kayak Tour:
        <p />
        <asp:DropDownList ID="ddlTours" runat="server" Height="16px" Width="159px">
            <asp:ListItem>Key Biscayne</asp:ListItem>
            <asp:ListItem>Colorado River</asp:ListItem>
            <asp:ListItem>Botany Bay</asp:ListItem>
            <asp:ListItem>Key Largo</asp:ListItem>
        </asp:DropDownList>
        <p />
        
    </form>
</body>
</html>
