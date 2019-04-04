<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication7.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtA" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtA" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtA" ErrorMessage="RegularExpressionValidator" 
            ForeColor="Red" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
        <br />
        <asp:TextBox ID="txtB" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtB" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="txtB" ErrorMessage="RegularExpressionValidator" 
            ForeColor="Red" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="+" />
        <asp:Button ID="btnSub" runat="server" onclick="btnSub_Click" Text="-" />
        <asp:Button ID="btnMul" runat="server" onclick="btnMul_Click" Text="*" />
        <asp:Button ID="btnDiv" runat="server" onclick="btnDiv_Click" Text="/" />
        <br />
        <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
    
    </div>
    </form>
</body>
</html>
