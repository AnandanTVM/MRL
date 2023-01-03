<%@ Page Title="" Language="C#" MasterPageFile="~/program/Hsuperant.master" AutoEventWireup="true" CodeFile="SupmessageR1.aspx.cs" Inherits="program_SupmessageR1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table  style="width:60%" frame="hsides" align=center>
        <tr bgcolor="#003366">
            <td  colspan="2"align="center" valign="middle" bgcolor="" class="text-white">
                Inbox</td>
        </tr>
        <tr>
            <td>
                <table align="center" cellpadding="0" class="style1" frame="box" width="100%">
                    <tr>
                        <td class="style3">
                            Sender Type</td>
                        <td>
                            <asp:Label ID="st" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            Sender Name</td>
                        <td>
                            <asp:Label ID="sn" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            Subject</td>
                        <td>
                            <asp:Label ID="s" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            Message</td>
                        <td>
                            <asp:Label ID="msg" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            Date of Sending</td>
                        <td>
                            <asp:Label ID="sdate" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            Reply</td>
                        <td>
                            <asp:Label ID="reply" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Accept" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style3">
                            <asp:Label ID="Label7" runat="server" Text="Response" Visible="False"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Height="134px" TextMode="MultiLine" 
                                Visible="False" Width="196px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                                Text="Update Response" Visible="False" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

