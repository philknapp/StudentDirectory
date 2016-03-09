<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="StudentDirectory.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 371px;
            width: 347px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <tr>
            <td><asp:Label ID="userNameLabel" runat="server" Text="User Name: "></asp:Label></td>
            <td><asp:TextBox ID="userNameBox" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
            <td><asp:Label ID="firstNameLabel" runat="server" Text="First Name: "></asp:Label></td>
            <td><asp:TextBox ID="firstNameBox" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
            <td><asp:Label ID="lastNameLabel" runat="server" Text="Last Name: "></asp:Label></td>
            <td><asp:TextBox ID="lastNameBox" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
            <td><asp:Label ID="emailLabel" runat="server" Text="Email: "></asp:Label></td>
            <td><asp:TextBox ID="emailBox" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
            <td><asp:Label ID="phoneLabel" runat="server" Text="Phone Number: "></asp:Label></td>
            <td><asp:TextBox ID="phoneBox" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
            <td><asp:Label ID="majorLabel" runat="server" Text="Major: "></asp:Label></td>
            <td><asp:TextBox ID="majorBox" runat="server"></asp:TextBox></td>
    </tr>

    <tr>
        <td>
            &nbsp;</td>
        <td>
        <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />
        <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" />
        <asp:Button ID="deleteButton" runat="server" Text="Delete" OnClick="deleteButton_Click" />
        <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
        <asp:Button ID="clearButton" runat="server" Text="Clear" OnClick="clearButton_Click" />
        <asp:Button ID="showButton" runat="server" Text="Show" OnClick="show_Click" />
        </td>
    </tr>    
    </table>
    </div>
        <p>




<br />
        <asp:Label ID="StudentLabel" runat="server" Text="Students: "></asp:Label>

        </p>


        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Height="405px" Width="411px"></asp:TextBox>


    </form>
</body>
</html>
