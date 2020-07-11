<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" Theme="MiscTheme" AutoEventWireup="true" CodeBehind="Admin_Home.aspx.cs" Inherits="IT_Project.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div style="position:absolute;top:30%;left:43%;font-size:x-large">
        <asp:Label ID="l1" runat="server">You have <B style="color:red;"><%#n %></B> </asp:Label><asp:HyperLink ID="h1" runat="server" NavigateURL="Notifications.aspx" Text=" Notifications"></asp:HyperLink>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="position:absolute;top:35%;left:43%;font-size:x-large">
        <asp:Label ID="Label1" runat="server">Create a </asp:Label><asp:HyperLink ID="HyperLink1" runat="server" NavigateURL="CreateProject.aspx" Text="New Project"></asp:HyperLink>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div style="position:absolute;top:40%;left:43%;font-size:x-large">
        <asp:Label ID="Label2" runat="server">Generate a </asp:Label><asp:HyperLink ID="HyperLink2" runat="server" NavigateURL="GenerateReport.aspx" Text="Report"></asp:HyperLink>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <div style="position:absolute;top:45%;left:43%;font-size:x-large">
        <asp:Label ID="Label3" runat="server">Display </asp:Label><asp:HyperLink ID="HyperLink3" runat="server" NavigateURL="DisplayStatus.aspx" Text="Status details"></asp:HyperLink>
    </div>
</asp:Content>
