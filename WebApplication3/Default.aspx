<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="add1" />
    <asp:TextBox ID="TextBox1" runat="server">counter</asp:TextBox>

</asp:Content>
