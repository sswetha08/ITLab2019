<%@ Page Title="" Language="C#" Theme="MiscTheme" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DisplayStatus.aspx.cs" Inherits="IT_Project.DisplayStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="position:absolute;top:40%;left:46%;">
    <asp:Label ID="Label1" runat="server" Text="Select a Project: "></asp:Label>
    <br />
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="PId" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="PClient" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="PDuration" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="PStatus" runat="server" Text=""></asp:Label>
    <br />
        <br />
    <asp:Button ID="Button1" runat="server" Text="Display Details" OnClick ="Clicked" />
    <div />
    </div>
    
</asp:Content>

