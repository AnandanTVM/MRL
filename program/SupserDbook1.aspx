<%@ Page Title="" Language="C#" MasterPageFile="~/program/Hsuperant.master" AutoEventWireup="true" CodeFile="SupserDbook1.aspx.cs" Inherits="program_SupserDbook1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table  style="width:60%" frame="hsides" align=center>
        <tr bgcolor="#003366">
            <td  colspan="2"align="center" valign="middle" bgcolor="" class="text-white">
                Death&nbsp; Book</td>
        </tr>
        <tr>
            <td>
                IP Number</td>
            <td>
                <asp:Label ID="ipno" runat="server"></asp:Label>
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
            <td class="style1">
                Genter</td>
            <td class="style1">
                <asp:Label ID="genter" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                C/O</td>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                C/O Name</td>
            <td>
                <asp:Label ID="Coname" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Address</td>
            <td>
                <asp:Label ID="address" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Phone</td>
            <td>
                <asp:Label ID="Phone" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Date Of Admit</td>
            <td>
                <asp:Label ID="dateadmit" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Date Of Death</td>
            <td>
                <asp:Label ID="datedeath" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Time Of Death</td>
            <td>
                <asp:Label ID="timedath" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Case Of Death</td>
            <td>
                <asp:Label ID="caseofdath" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Remark</td>
            <td>
                <asp:Label ID="remark" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Back" />
            </td>
        </tr>
    </table>
</asp:Content>

