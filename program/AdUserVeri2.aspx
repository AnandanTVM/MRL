<%@ Page Title="" Language="C#" MasterPageFile="~/program/Hadmin.master" AutoEventWireup="true" CodeFile="AdUserVeri2.aspx.cs" Inherits="program_AdUserVeri2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table  align="center" cellpadding="0" class="style1" 
        style="vertical-align: middle" frame="box" width=50%>
        <tr bgcolor="#003366">
            <td colspan="2"align="center" valign="middle" bgcolor="" class="text-white" >
                Verification Deatails</td>
        </tr>
        <tr>
            <td>
                Post</td>
            <td>
                <asp:Label ID="post" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Name</td>
            <td>
                <asp:Label ID="name" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                User Name</td>
            <td>
                <asp:Label ID="user_name" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Password</td>
            <td>
                <asp:Label ID="password" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Address</td>
            <td>
                <asp:Label ID="addressinfo" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Phone</td>
            <td>
                <asp:Label ID="phone" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Email Id</td>
            <td>
                <asp:Label ID="email" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Date Of Join</td>
            <td>
                <asp:Label ID="boj" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Reg.No</td>
            <td>
                <asp:Label ID="reg_no" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align=right>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Reject" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Accept" />
            </td>
        </tr>
    </table>
</asp:Content>

