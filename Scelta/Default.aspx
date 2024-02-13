<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Scelta._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <form class="row" aria-labelledby="aspnetTitle">
            <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" onClick="Button1_" />
        </form>

     
    </main>

</asp:Content>
