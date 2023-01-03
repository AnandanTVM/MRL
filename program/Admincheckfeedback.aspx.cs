using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class program_Admincheckfeedback : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataAdapter da;
    DataSet ds;
    String strcon;
    protected void Page_Load(object sender, EventArgs e)
    {
        strcon = ConfigurationManager.ConnectionStrings["w"].ConnectionString;
        con = new SqlConnection(strcon);
        string name = Session["x"].ToString();
        // string s1 = "Coordinator";
        // Label1.Text = uname.ToString();
        // string utyp = Session["UserType"].ToString();
        con.Open();
        da = new SqlDataAdapter("select * from feedback", con);
        ds = new DataSet();
        da.Fill(ds, "feedback");
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged2(object sender, EventArgs e)
    {

    }
}