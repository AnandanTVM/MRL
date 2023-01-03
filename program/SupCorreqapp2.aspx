<%@ Page Title="" Language="C#" MasterPageFile="~/program/Hsuperant.master" AutoEventWireup="true" CodeFile="SupCorreqapp2.aspx.cs" Inherits="program_SupCorreqapp2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            color: #fff;
            font-weight: 700;
            font-style: italic;
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table  style="width:60%" frame="hsides" align=center>
        <tr bgcolor="#003366">
            <td  colspan="3" align="center" valign="middle" bgcolor="" class="text-white">
                Correption Deatils</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label28" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Type</td>
            <td>
                Wrong data</td>
            <td>
                Coreption Data</td>
        </tr>
        <tr>
            <td>
                Name</td>
            <td>
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label7" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Genter</td>
            <td>
                <asp:Label ID="Label8" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label9" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Date Of Brith</td>
            <td>
                <asp:Label ID="Label10" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label11" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Name Of Father</td>
            <td>
                <asp:Label ID="Label12" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label13" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Name Of Mother</td>
            <td>
                <asp:Label ID="Label14" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label15" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Address</td>
            <td>
                <asp:Label ID="Label16" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label17" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
         <tr bgcolor="#003366">
            <td  colspan="3" align="center" valign="middle" bgcolor="" class="style1">
                Update Correption Deatils</td>
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
                IP&nbsp; No</td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Gender</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Date Of Birth</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Date Of Admit</td>
            <td>
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Date Of Discharge/Death</td>
            <td>
                <asp:Label ID="Label18" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Father Name</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Mother Name</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Adderss</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Contact No</td>
            <td>
                <asp:Label ID="Label22" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Diseases</td>
            <td>
                <asp:Label ID="Label23" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                MRL Code</td>
            <td>
                <asp:Label ID="Label24" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Name Of Doctor</td>
            <td>
                <asp:Label ID="Label25" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Ward</td>
            <td>
                <asp:Label ID="Label26" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Current Status</td>
            <td>
                <asp:Label ID="Label27" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
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
                <asp:Button ID="Button1" runat="server" Text="Update" onclick="Button1_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

