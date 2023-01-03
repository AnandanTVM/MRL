using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class program_LibserDbook1 : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand comm;
    SqlDataReader reader;
    String strcon;
    string utyp;
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Convert.ToInt32(Request.QueryString.ToString());
        strcon = ConfigurationManager.ConnectionStrings["w"].ConnectionString;

        con = new SqlConnection(strcon);
        string uname = Session["x"].ToString();
        utyp = Session["utyp"].ToString();
        con.Open();
        if (!Page.IsPostBack)
        {


            comm = new SqlCommand("select * from death where did=" + id + "", con);
            reader = comm.ExecuteReader();
            if (reader.Read() == true)
            {
                ipno.Text = reader["IP"].ToString();
                name.Text = reader["name"].ToString();
                genter.Text = reader["genter"].ToString();
                Label1.Text = reader["c_o"].ToString();
                Coname.Text = reader["coname"].ToString();
                address.Text = reader["address"].ToString();
                Phone.Text = reader["phone"].ToString();
                dateadmit.Text = reader["dateadmit"].ToString();
                datedeath.Text = reader["datedeath"].ToString();
                timedath.Text = reader["timedath"].ToString();
                caseofdath.Text = reader["caseofdath"].ToString();
                remark.Text = reader["remark"].ToString();



            }

        }

        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("LibserDbook.aspx");
    }
}