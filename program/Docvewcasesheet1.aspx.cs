using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class program_Docvewcasesheet1 : System.Web.UI.Page
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


            comm = new SqlCommand("select * from casesheet where ip=" + id + "", con);
            reader = comm.ExecuteReader();
            if (reader.Read() == true)
            {
                Label1.Text = reader["ip"].ToString();
                Label2.Text = reader["name"].ToString();
                Label3.Text = reader["gender"].ToString();
                Label4.Text = reader["dob"].ToString();
                Label5.Text = reader["doa"].ToString();
                Label6.Text = reader["dog_d"].ToString();
                Label7.Text = reader["father"].ToString();
                Label8.Text = reader["mother"].ToString();
                Label9.Text = reader["address"].ToString();
                Label10.Text = reader["phone"].ToString();
                Label11.Text = reader["disease"].ToString();
                Label12.Text = reader["mrl_code"].ToString();
                Label13.Text = reader["doctor"].ToString();
                Label14.Text = reader["ward"].ToString();
                Label15.Text = reader["currentstatus"].ToString();



            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Docvewcasesheet.aspx");
    }
}