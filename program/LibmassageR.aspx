<%@ Page Title="" Language="C#" MasterPageFile="~/program/Hlibrarian.master" AutoEventWireup="true" CodeFile="LibmassageR.aspx.cs" Inherits="program_LibmassageR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table  style="width:60%" frame="hsides" align=center>
        <tr bgcolor="#003366">
            <td align="center" valign="middle" bgcolor="" class="text-white">
                Inbox</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:BoundField DataField="sendertype" HeaderText="Post" />
                        <asp:BoundField DataField="sendername" HeaderText="Name" />
                        <asp:HyperLinkField DataNavigateUrlFields="cid" 
                            DataNavigateUrlFormatString="LibmassageR1.aspx?{0}" DataTextField="subject" 
                            HeaderText="Subject" />
                    </Columns>
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <SortedAscendingCellStyle BackColor="#F4F4FD" />
                    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                    <SortedDescendingCellStyle BackColor="#D8D8F0" />
                    <SortedDescendingHeaderStyle BackColor="#3E3277" />
                </asp:GridView>
                `</td>
        </tr>
        <tr>
            <td>
                `</td>
        </tr>
    </table>
</asp:Content>

