<%@ Page Title="" Language="C#" MasterPageFile="~/program/Hadmin.master" AutoEventWireup="true" CodeFile="Adolddetails1.aspx.cs" Inherits="program_Adolddetails1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="a1">
    <table style="width:60%" frame="hsides" align=center  id="t1">
        <tr bgcolor="#003366">
        
               
            <td colspan="3" align="center" valign="middle" bgcolor="" class="text-white" >
                Staff Info <br /></td>
        </tr>
        <tr>
            <td>
              <br />  Post &nbsp;&nbsp;&nbsp;</td>
            <td>
                <asp:Label ID="post" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
              <br />  Name&nbsp;&nbsp;&nbsp;</td>
            <td>
                <asp:Label ID="name" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
               <br /> User Name&nbsp;&nbsp;&nbsp;</td>
            <td>
                <asp:Label ID="user_name" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <br />Password&nbsp;&nbsp;&nbsp;</td>
            <td>
                <asp:Label ID="password" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
               <br /> Address&nbsp;&nbsp;&nbsp;</td>
            <td>
                <asp:Label ID="addressinfo" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
               <br /> Phone&nbsp;&nbsp;&nbsp;</td>
            <td>
                <asp:Label ID="phone" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
               <br /> Email Id&nbsp;&nbsp;&nbsp;</td>
            <td>
                <asp:Label ID="email" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
               <br /> Date Of Join&nbsp;&nbsp;&nbsp;</td>
            <td>
                <asp:Label ID="boj" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
              <br />  Reg.No&nbsp;&nbsp;&nbsp;</td>
            <td>
                <asp:Label ID="reg_no" runat="server"></asp:Label>
            </td>
            
               
        </tr>
        </table>
         </div>
        <table>
        <tr>
            <td align=right>
                <asp:Button ID="Button1" runat="server" BackColor="Red" BorderColor="Red" 
                    BorderStyle="Solid" ForeColor="White" Text="Back" 
                    onclick="Button1_Click1" />
            </td>
            <td>
                    <%--<asp:Button ID="Button2" runat="server" Text="Print"  OnClientClick="print()"/>--%>
                    <button id="btn" type="button" onclick="print()" >
                        Print</button>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <script type="text/javascript">
        function print() {
            var newWin;
            //debugger;
            newWin = window.open("", '_blank', 'location=yes,channelmode=yes,fullscreen=yes,scrollbars=yes,status=yes,top=0,left=0');
            //newWin.document.body.innerHTML = '<body></body>';    
            //document.getElementById("t1").innerHTML

            newWin.document.body.innerHTML = '<body>' + document.getElementById("a1").innerHTML + '</body>';
            //debugger;

            newWin.document.close();
            newWin.focus();
            newWin.print();
            newWin.close();


        }
        function btn_onclick() {

        }

function btn_onclick() {

}

    </script>
</asp:Content>

