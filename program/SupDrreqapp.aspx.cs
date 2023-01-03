using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class program_SupDrreqapp : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataAdapter da;
    DataSet ds;
    String strcon;
    protected void Page_Load(object sender, EventArgs e)
    {
        string asg = "Approval";
        strcon = ConfigurationManager.ConnectionStrings["w"].ConnectionString;
        con = new SqlConnection(strcon);
        con.Open();
        da = new SqlDataAdapter("select * from drequ  where reqstatus='" + asg + "' ", con);
        ds = new DataSet();
        da.Fill(ds, "drequ");
        GridView2.DataSource = ds;
        GridView2.DataBind();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupDrreqapprej.aspx");
    }
}