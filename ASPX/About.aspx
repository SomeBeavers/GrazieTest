<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ASPX.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page. infomation</h3>
 <%--   
     <h3>Your application description page. infomation</h3>.
     --%>
    <a></a>
    <abbr title="Phone infomation">P:</abbr>
    <asp:Label ID="lbl" runat="server" Text="Label text my infomation"></asp:Label>
</asp:Content>
