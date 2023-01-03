using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class program_Docvewcasesheet : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataAdapter da;
    DataSet ds;
    String strcon;
    protected void Page_Load(object sender, EventArgs e)
    {
        string uname = Session["x"].ToString();
        
        // string s1 = "Doctor";
        Label1.Text = uname.ToString();
        string utyp = Session["utyp"].ToString();
        //string asg = "pending";
        strcon = ConfigurationManager.ConnectionStrings["w"].ConnectionString;
        con = new SqlConnection(strcon);
        con.Open();
        da = new SqlDataAdapter("select * from appreqdoctor ", con);
        ds = new DataSet();
        da.Fill(ds, "appreqdoctor");
        GridView3.DataSource = ds;
        GridView3.DataBind();
        con.Close();
    }
    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("DoctorHome.aspx");
    }
}