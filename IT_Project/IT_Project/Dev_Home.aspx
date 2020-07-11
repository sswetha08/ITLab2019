<%@ Page Title="" Language="C#" Theme="MiscTheme" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dev_Home.aspx.cs" Inherits="IT_Project.Dev_Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div  style="position:absolute;top:40%;left:46%;">
        <style>
        div
        {
            padding:20px;
            margin:20px;
        }
        </style>
        </div>
          
         <div>
           <div><asp:Label ID="Welcome_msg_label" runat="server"></asp:Label></div>
            <div><asp:Button ID="Button1" runat="server" Text="Update Project" OnClick="Button1_Click"/></div>
            <div><asp:Button  ID="Button2" runat="server" Text="Comments" OnClick="Button2_Click" /></div>
        </div>


</asp:Content>
