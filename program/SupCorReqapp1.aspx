<%@ Page Title="" Language="C#" MasterPageFile="~/program/Hsuperant.master" AutoEventWireup="true" CodeFile="SupCorReqapp1.aspx.cs" Inherits="program_SupCorReqapp1" %>

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
            <td  colspan="3" align="center" valign="middle" bgcolor="" class="text-white">
                Correction Request Approval</td>
            
        </tr>
        <tr>
            <td>
                IP No</td>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Name</td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                Parent Name</td>
            <td class="style1">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
            <td class="style1">
                </td>
        </tr>
        <tr>
            <td>
                Relationship</td>
            <td>
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Address</td>
            <td>
                <asp:Label ID="Label5" runat="server"></asp:Label>
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
            <tr bgcolor="#003366">
            <td  colspan="3" align="center" valign="middle" bgcolor="" class="text-white">
                Correption data</td>
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
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
       <tr bgcolor="#003366">
            <td  colspan="3"align="center" valign="middle" bgcolor="" class="text-white">
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
                Date</td>
            <td>
                <asp:Label ID="Label19" runat="server"></asp:Label>
             </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td>
                Document</td>
            <td>
                <asp:Label ID="Label20" runat="server"></asp:Label>
             </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td>
                Scaned Document</td>
            <td>
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
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td align=right>
                <asp:Button ID="Button3" runat="server" Text="Reject" onclick="Button3_Click" />
             </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Apporval" 
                    onclick="Button2_Click" />
             </td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label18" runat="server" Text="Rejection Resone" Visible="False"></asp:Label>
             </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Visible="False"></asp:TextBox>
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
                <asp:Button ID="Button4" runat="server" Text="Update" Visible="False" 
                    onclick="Button4_Click" />
             </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
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

