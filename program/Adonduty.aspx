<%@ Page Title="" Language="C#" MasterPageFile="~/program/Hadmin.master" AutoEventWireup="true" CodeFile="Adonduty.aspx.cs" Inherits="program_Adonduty" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:60%" frame="hsides" align=center>
        <tr bgcolor="#003366">
            <td colspan="3" align="center" valign="middle" bgcolor="" class="text-white">
                On Duty details</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td align =center>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" GridLines="Horizontal" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:BoundField DataField="name" HeaderText="Name" />
                        <asp:HyperLinkField HeaderText="Post" DataNavigateUrlFields="uid" 
                            DataNavigateUrlFormatString="Adonduty1.aspx?{0}" 
                            DataTextField="Post" />
                       
                        <asp:HyperLinkField DataNavigateUrlFields="uid" 
                            DataNavigateUrlFormatString="Adonduty1.aspx?{0}" DataTextField="Phone" 
                            HeaderText="Phone" />
                       
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
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

