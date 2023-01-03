using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class program_DocstaRej : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataAdapter da;
    DataSet ds;
    String strcon;
    protected void Page_Load(object sender, EventArgs e)
    {
        string uname = Session["x"].ToString();
        // string s1 = "Doctor";
        // Label1.Text = uname.ToString();
        string utyp = Session["utyp"].ToString();
        string asg = "Rejection";
        strcon = ConfigurationManager.ConnectionStrings["w"].ConnectionString;
        con = new SqlConnection(strcon);
        con.Open();
        da = new SqlDataAdapter("select * from drequ  where reqstatus='" + asg + "' and drname= '" + uname + "' ", con);
        ds = new DataSet();
        da.Fill(ds, "drequ");
        GridView2.DataSource = ds;
        GridView2.DataBind();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Docsta.aspx");
    }
}