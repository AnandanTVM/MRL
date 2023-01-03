using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class program_Adolddetails : System.Web.UI.Page
{

    SqlConnection con;
    //SqlDataReader rdr;
    SqlDataAdapter da;
    DataSet ds;
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

        string name = TextBox4.Text;
        string to = TextBox2.Text;
        string from = TextBox3.Text;

        con.Open();
        da= new SqlDataAdapter("SELECT * From reg where boj between'" + to + "' and '" + from + "'", con);
        ds = new DataSet();
        da.Fill(ds, "reg");
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();
    }
}