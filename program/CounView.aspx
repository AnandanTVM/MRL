<%@ Page Title="" Language="C#" MasterPageFile="~/program/Hcounter.master" AutoEventWireup="true" CodeFile="CounView.aspx.cs" Inherits="program_CounView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            font-family: "Times New Roman", Times, serif;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <table style="width:60%" frame="hsides" align=center>
        <tr bgcolor="#003366">
            <td colspan="2" align="center" valign="middle" bgcolor="" class="text-white">
                View</td>
        </tr>
        <tr>
            <td class="style1" colspan="2">
                <marquee> Impostant Details Do Not share.......</marquee></td>
        </tr>
        <tr>
            <td class="style1">
                View BrithBook</td>
            <td>
               <a href="CounbbookV.aspx">>>>>>>>>>>>>>>>></a></td>
        </tr>
        <tr>
            <td class="style1">
                View DeathBook</td>
            <td>
                <a href="CoundbookV.aspx">>>>>>>>>>>>>>>>></a></td>
        </tr>
    </table>
</asp:Content>

