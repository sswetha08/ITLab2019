<%@ Page Title="" Language="C#" Theme="MiscTheme" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CreateProject.aspx.cs" Inherits="IT_Project.CreateProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="position:absolute;top:30%;left:40%;font-size:x-large;">
        <table>
            <caption>Project creation</caption>
            <tr>
                <td><asp:Label runat="server" ID="l1">Title</asp:Label></td>
                <td><asp:TextBox id="tb1" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label runat="server" ID="l2">Duration</asp:Label></td>
                <td><asp:TextBox id="tb2" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="l3" runat="server">Client</asp:Label></td>
                <td><asp:TextBox id="tb3" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <div style="position:absolute;top:105%;left:50%;">
            <asp:Button runat="server" ID="butt1" Text="Submit" OnClick="butt1_Click"/>
        </div>
        <div style=""position:absolute;top:115%;left:40%;">
            <asp:Label runat="server" ID="l4"></asp:Label>
        </div>
        </div>
    </asp:Content>
    <asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    </asp:Content>
    <asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    </asp:Content>
