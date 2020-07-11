<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" Theme ="MiscTheme" AutoEventWireup ="true" CodeBehind="Notifications.aspx.cs" Inherits="IT_Project.Notifications" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Notifications</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:SqlDataSource ID="notds" runat="server"
        SelectCommand="select * from Comments where ReviewStatus='Pending'" ConnectionString="Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Project_mgmt; Integrated Security=true;Pooling=false">
        
    </asp:SqlDataSource>
 <asp:GridView AllowPaging="true" PageSize="10" runat="server" ID="gv" DataSourceID="notds" OnRowCommand="gv_RowCommand" HorizontalAlign="Center">
        <HeaderStyle BackColor="#66ffff" ForeColor="#0000ff" Font-Bold="true" Font-Size="Large" />
        <AlternatingRowStyle BackColor="GainsBoro" />
        <Columns>
        <asp:TemplateField HeaderText="Action">
            <ItemTemplate>
                <asp:Button CommandName="approve" CommandArgument='<%# Eval("CommentId") %>' runat="server" ID="btn_approve" Text="Approve" BackColor="Green" ForeColor="White" EnableTheming="false" />
                <asp:Button CommandName="reject" CommandArgument='<%# Eval("CommentId") %>' runat="server" ID="btn_reject" Text="Reject"  BackColor="Red" ForeColor="White" EnableTheming="false"/>
            </ItemTemplate>
        </asp:TemplateField>
            </Columns>
    </asp:GridView>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
