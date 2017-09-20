<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Event Demo</title>
</head>
<body>
<form id="form1" runat="server">

<h1>Events</h1>

Enter your name: 
<asp:TextBox 
	ID="txtName" 
	Columns="25"
	runat="server">
	</asp:TextBox>

<asp:Button 
	ID="btnOk" 
	runat="server" 
	Text="OK" />

    <br />

<p />
<asp:ListBox 
	ID="lstEvents" 
	runat="server"
	Width="250px" 
	Height="109px">
	</asp:ListBox>

</form>
</body>
</html>
