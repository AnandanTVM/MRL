<%@ Page Title="" Language="C#" MasterPageFile="~/program/Hsuperant.master" AutoEventWireup="true" CodeFile="SupserCasesheet1.aspx.cs" Inherits="program_SupserCasesheet1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <table  style="width:60%" frame="hsides" align=center>
        <tr bgcolor="#003366">
            <td  colspan="2"align="center" valign="middle" bgcolor="" class="text-white">
                CaseSheet</td>
        </tr>
        <tr>
            <td class="style1">
                IP NO</td>
            <td class="style1">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Name</td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Gender</td>
            <td>
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Date Of Birth</td>
            <td>
                <asp:Label ID="Label4" runat="server"></asp:Label>
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
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Father Name</td>
            <td>
                <asp:Label ID="Label7" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Mother Name</td>
            <td>
                <asp:Label ID="Label8" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Adderss</td>
            <td>
                <asp:Label ID="Label9" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Contact No</td>
            <td>
                <asp:Label ID="Label10" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Diseases</td>
            <td>
                <asp:Label ID="Label11" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                MRL Code</td>
            <td>
                <asp:Label ID="Label12" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Name Of Doctor</td>
            <td>
                <asp:Label ID="Label13" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Ward</td>
            <td>
                <asp:Label ID="Label14" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Current Status</td>
            <td>
                <asp:Label ID="Label15" runat="server"></asp:Label>
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
                Scan Case Sheet&nbsp;&nbsp;&nbsp; :-</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server">
                    <Columns>
                <asp:ImageField DataImageUrlField="imagepath" HeaderText="picture">
                    <ControlStyle Height="80px" Width="80px" />
                    <ItemStyle Height="80px" Width="80px" />
                </asp:ImageField>
               <%-- for view--%>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkSelect" runat="server" Text="View" OnClientClick="return GetSelectedRow(this);" />
                    </ItemTemplate>
                </asp:TemplateField>
               <%-- end view--%>
            </Columns>
                </asp:GridView>
    
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Button ID="Button2" runat="server" Text="Back" onclick="Button2_Click" />
            </td>
            <td align="center">
                <asp:Button ID="Button1" runat="server" Text="Print" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
     <%-- script for view--%>
    <script type="text/javascript">
        function GetSelectedRow(e) {
            var row = e.parentNode.parentNode;
            var filepath = row.cells[4].innerHTML;
            var ihost = window.location.hostname + ':' + window.location.port
            var iurl = "http://" + ihost + filepath;
            openUrl(iurl);
            return false;
        }
        function openUrl(iurl) {
            window.open(iurl, "_blank", "width=900,height=600", "menubar=no", "titlebar=no", "toolbar=no").focus(); ;
        }
    </script>
</asp:Content>

