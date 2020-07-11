<%@ Page Title="" Language="C#"  MasterPageFile="~/Site1.Master" Theme="MiscTheme" AutoEventWireup="true" CodeBehind="Login_Page.aspx.cs" Inherits="IT_Project.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div style="position:absolute;left:40%;top:20%;">
    <table>
       <caption>Login Details</caption>
       <tr>
           <td>
               <asp:Label ID="Label1" runat="server" Text="Login ID : "></asp:Label>
           </td>
           <td>
               <asp:TextBox ID="Username" runat="server"></asp:TextBox>
           </td>
       </tr>
       <tr>
           <td>
               <asp:Label ID="Label2" runat="server" Text="Password : " ></asp:Label>
           </td>
           <td>
               <asp:TextBox ID="Pwd" runat="server" TextMode="Password"></asp:TextBox>
           </td>
      
       </tr>
   </table>
 
    </div>

    <div style="position:absolute;top:40%;left:65%;">
    <asp:RequiredFieldValidator ID="RFV1" runat="server" ForeColor="Red" ControlToValidate="Username" ErrorMessage="Enter UserId"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RFV2" runat="server" ForeColor="Red" ControlToValidate="Pwd" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>
  

     </div>

    <div style="position:absolute;top:40%;left:46%;">
    <asp:Button runat="server" Text="Log In!" OnClick ="LoginClick"/>
          
    </div>
    <div>
        <asp:Label ID="Error" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
