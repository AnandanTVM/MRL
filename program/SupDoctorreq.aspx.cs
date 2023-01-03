using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class program_SupDoctorreq : System.Web.UI.Page
{
    SqlConnection con;
    SqlDataAdapter da;
    DataSet ds;
    String strcon,dapp;
    string a, b, c, d, e1, f, g, h, i, j, k, l, m, n, o, p, qq, p5 = "Approval";
    protected void Page_Load(object sender, EventArgs e)
    {
        dapp = "pending";
         strcon = ConfigurationManager.ConnectionStrings["w"].ConnectionString;
        con = new SqlConnection(strcon);
        string uname = Session["x"].ToString();
        // string s1 = "Coordinator";
        // Label1.Text = uname.ToString();
        // string utyp = Session["UserType"].ToString();
        con.Open();
        da = new SqlDataAdapter("select * from drequ where status=0 and reqstatus='" + dapp  + "'", con);
        ds = new DataSet();
        da.Fill(ds, "drequ");
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();
    }
        
    }
