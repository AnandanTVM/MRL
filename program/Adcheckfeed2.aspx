<%@ Page Title="" Language="C#" MasterPageFile="~/program/Hadmin.master" AutoEventWireup="true" CodeFile="Adcheckfeed2.aspx.cs" Inherits="program_Adcheckfeed2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" class="style1" 
        style="vertical-align: middle" frame="box" width=50%>
        <tr bgcolor="#003366">
            <td colspan="3"  align="center" valign="middle" bgcolor="" class="text-white" colspan="3">
                <strong>Check F</strong><span class="style4">eedback from Public</span></td>
        </tr>
        <tr>
            <td>
                &nbsp;Name</td>
            <td>
                <asp:Label ID="name" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Feedback</td>
            <td>
                <asp:Label ID="feedback" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Phone</td>
            <td>
                <asp:Label ID="phone" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Email</td>
            <td>
                <asp:Label ID="email" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Place</td>
            <td>
                <asp:Label ID="place" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Back" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

