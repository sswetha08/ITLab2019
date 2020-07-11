<%@ Page Title="" Language="C#" Theme="MiscTheme" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateProject.aspx.cs" Inherits="IT_Project.UpdateProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <style>
        .table1 
        {
            position:absolute;
            left:30%;
            top:7%;
            border:black solid 1px;
            padding:8px;
        }
         .table2 
        {
            position:absolute;
            left:30%;
            top:68%;
            border:black solid 1px;
            padding:8px;
        }
        
        td
        {
            margin:6px;
            padding:6px;
        }
 
    </style>
   
        
        

        
        <div>
            <table class="table1">
                <tr>
                
                    <td><asp:Label ID="Label2" runat="server" Text="Select Your Project"></asp:Label></td>
                    <td><asp:Label ID="Label12" runat="server" style="position:absolute; left:45%" Text="Update Project Details"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label ID="Error_msg_lbl" runat="server" ForeColor="Red" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Current details of selected project"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Client name :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Project Title :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Height="22px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label11" runat="server" Text="Project ID :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                </tr>
<tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Project Duration(Months):"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
<tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Commissioned Developers"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
<tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Project Completion Status :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <table class="table2">
                <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Update details"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Error_msg_lbl_1" ForeColor="Red" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Project Status :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="Project Duration(Months):"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><asp:Button ID="Button1" runat="server" Text="          Update          " OnClick="Button1_Click"/>
                </table>
        </div>
    </form>

</asp:Content>
