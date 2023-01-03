using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
public partial class foegotpassword : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    SqlDataReader rdr;
    string strl;
    string utyp;
    protected void Page_Load(object sender, EventArgs e)
    {
        strl = ConfigurationManager.ConnectionStrings["w"].ConnectionString;
        con = new SqlConnection(strl);
        TextBox2.Focus();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string na = TextBox1.Text;
        string un = TextBox2.Text;
        string ph = TextBox3.Text;
        string db = TextBox4.Text;
        con.Open();
        cmd = new SqlCommand("SELECT * From reg where name='" + na + "' and username='" + un + "'" , con);
        rdr = cmd.ExecuteReader();
    }
}