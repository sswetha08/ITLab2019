<%@ Page Title="" Language="C#" Theme="MiscTheme" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MakeComments.aspx.cs" Inherits="IT_Project.MakeComments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        table 
        {
            position:absolute;
            left:35%;
            top:10%;
            border:solid black 1px;
            margin:20px;
            padding:20px;
        }

    </style>

        <div>
             <table class="table1">
                    <caption><asp:Label ID="Label2" runat="server" Text="Select Your Project"></asp:Label></caption>
                 <tr>
                     <td></td>
                <tr>
                    <td>
                       <span> <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList></span>
                    </td>
                    <tr>
                        <td></td>
                    </tr>
                    <td>
                        <asp:Label ID="Error_msg_lbl" runat="server" ForeColor="Red" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Add comments"></asp:Label></td>
                    </tr>
                     <tr>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                     <td></td>
                 </tr>
                 <tr>
                     <td>
                         <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/>
                     </td>
                 </tr>
            </table>
        </div>
        <asp:Label ID="Label4" runat="server" ForeColor="White" Text="Label"></asp:Label>
        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>


</asp:Content>
