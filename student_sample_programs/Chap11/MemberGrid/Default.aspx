<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="KarateDataSource" Height="205px" Width="460px">
        </asp:GridView>
        <asp:SqlDataSource ID="KarateDataSource" runat="server"></asp:SqlDataSource>
    </form>
</body>
</html>
