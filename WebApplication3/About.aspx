<%@ Page Title="Jack" AutoEventWireup="True" Inherits="WebApplication3.About" CodeBehind="~/About.aspx.cs" Language="C#" %>

<form runat="server">
    <asp:Label ID="id" runat="server" Text="id"></asp:Label>
    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
    <asp:Label ID="user" runat="server" Text="User"></asp:Label>
    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
    <asp:Label ID="pass" runat="server" Text="Password"></asp:Label>

    <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
    <asp:Button ID="Insert" runat="server" OnClick="btnLogin_Click" Text="Insert"></asp:Button>
    <asp:Button ID="Update" runat="server" OnClick="UpdateData" Text="Update"></asp:Button>
    <asp:Button ID="Delete" runat="server" OnClick="DeleteData" Text="Delete"></asp:Button>


    <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="btnSearch_Click" Text="Search"></asp:Button>
    <asp:GridView ID="gridView" runat="server"></asp:GridView>


    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUser" ErrorMessage="Please Enter User"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPass" ErrorMessage="Please Enter Password"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator runat="server" ControlToValidate="txtUser" ErrorMessage="Please Enter Valid User Name" ValidationExpression="^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,}$"></asp:RegularExpressionValidator>




</form>
