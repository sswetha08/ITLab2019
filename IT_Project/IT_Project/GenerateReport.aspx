<%@ Page Title="" Language="C#" Theme="MiscTheme" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="GenerateReport.aspx.cs" Inherits="IT_Project.GenerateReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div style="position:absolute;top:15%; left:45%; margin-right: 0px; height: 229px;">
<asp:Label ID="Label1" runat="server" Text="Choose Client: "></asp:Label>
    <br />
<asp:DropDownList ID="Client" runat="server"></asp:DropDownList>
    <br />
    <br />
<asp:Label ID="Label2" runat="server" Text="Choose Completion Status: "></asp:Label>
    <br />
<asp:DropDownList ID="Status" runat="server"></asp:DropDownList>

    <br />
    <br />



<asp:Button ID="Button1" runat="server" Text="Find Projects" OnClick ="Clicked" />
    <br />
    <br />
<asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
    <br />
<asp:Button ID="Button2" runat="server" Text="Generate Report" Visible ="false" OnClick ="RepButton" />
    <br />
    <br />
<asp:Label ID="Report" runat="server" Text=""></asp:Label>

</div>

</asp:Content>
