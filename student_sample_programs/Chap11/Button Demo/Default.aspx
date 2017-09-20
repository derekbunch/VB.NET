<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Button Demo</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            width: 245px;
            height: 42px;
        }
        .style4
        {
            height: 42px;
        }
        .style5
        {
            width: 245px;
            height: 48px;
        }
        .style6
        {
            height: 48px;
        }
        .style7
        {
            width: 245px;
            height: 52px;
        }
        .style8
        {
            height: 52px;
        }
        .style9
        {
            width: 245px;
            height: 47px;
        }
        .style10
        {
            height: 47px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div title="Button Demo">
    
        <h2>
            Examples of Button-Type Controls</h2>
    
    </div>
    <table class="style1">
        <tr>
            <td class="style3">
                <asp:HyperLink ID="HyperLink1" runat="server">HyperLink control</asp:HyperLink>
            </td>
            <td class="style4">
                (no click event, navigates to another URL)</td>
        </tr>
        <tr>
            <td class="style5">
                <asp:LinkButton ID="LinkButton1" runat="server">LinkButton control</asp:LinkButton>
            </td>
            <td class="style6">
                <asp:Label ID="lblLinkButtonMessage" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style7">
                <asp:ImageButton ID="ImageButton1" runat="server" Width="99px" Height="22px" 
                    ImageUrl="~/ButtonImage.png" />
            &nbsp; (ImageButton)</td>
            <td class="style8">
                <asp:Label ID="lblImageButtonMessage" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style9">
                <asp:Button ID="Button1" runat="server" Text="Button" Width="97px" />
            </td>
            <td class="style10">
                <asp:Label ID="lblButtonMessage" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
