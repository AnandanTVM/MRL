<%@ Page Title="" Language="C#" MasterPageFile="~/program/Hdoctor.master" AutoEventWireup="true" CodeFile="Docvewcasesheet.aspx.cs" Inherits="program_Docvewcasesheet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        color: #fff;
        font-weight: 700;
        font-style: italic;
        height: 26px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table  style="width:60%" frame="hsides" align=center>
    <tr bgcolor="#003366">
        <td  colspan="2"align="center" valign="middle" bgcolor="" class="style1">
            View CaseSheet</td>
    </tr>
    <tr>
        <td>
                &nbsp;</td>
        <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
                &nbsp;</td>
        <td>
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" GridLines="Horizontal">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
                    <asp:BoundField DataField="ip" HeaderText="IP No" />
                    <asp:BoundField DataField="name" HeaderText="Name" />
                    <asp:BoundField DataField="disease" HeaderText="Disease" />
                    <asp:BoundField DataField="currentstatus" HeaderText="Current Status" />
                    <asp:HyperLinkField DataNavigateUrlFields="ip" 
                        DataNavigateUrlFormatString="Docvewcasesheet1.aspx?{0}" 
                        DataTextField="readdate" HeaderText="Valid UpTo" />
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
        <td align=center>
            <asp:Button ID="Button1" runat="server" Text="Back" onclick="Button1_Click" />
        </td>
    </tr>
    <tr>
        <td>
                &nbsp;</td>
        <td>
                &nbsp;</td>
    </tr>
</table>
</asp:Content>

