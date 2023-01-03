<%@ Page Title="" Language="C#" MasterPageFile="~/program/Hlibrarian.master" AutoEventWireup="true" CodeFile="LibserBbook1.aspx.cs" Inherits="program_LibserBbook1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table  style="width:60%" frame="hsides" align=center>
        <tr bgcolor="#003366">
            <td  colspan="3"align="center" valign="middle" bgcolor="" class="text-white">
                Brith Book</td>
        </tr>
        <tr>
            <td>
                IP Number</td>
            <td>
                <asp:Label ID="ipno" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Name</td>
            <td>
                <asp:Label ID="name" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                Genter</td>
            <td class="style1">
                <asp:Label ID="genter" runat="server"></asp:Label>
            </td>
            <td class="style1">
            </td>
        </tr>
        <tr>
            <td>
                Name Of Mother</td>
            <td>
                <asp:Label ID="mother" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Name Of Father</td>
            <td>
                <asp:Label ID="father" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Address</td>
            <td>
                <asp:Label ID="address" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Phone</td>
            <td>
                <asp:Label ID="Phone" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Date Of Brith</td>
            <td>
                <asp:Label ID="dob" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Time Of Brith</td>
            <td>
                <asp:Label ID="dobt" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Unit</td>
            <td>
                <asp:Label ID="unit" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Droctor</td>
            <td>
                <asp:Label ID="doctor" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
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
            <td>
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>

