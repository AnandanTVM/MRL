using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class program_LibserBbook1 : System.Web.UI.Page
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


            comm = new SqlCommand("select * from brith where bid=" + id + "", con);
            reader = comm.ExecuteReader();
            if (reader.Read() == true)
            {
                ipno.Text = reader["ipno"].ToString();
                name.Text = reader["name"].ToString();
                genter.Text = reader["genter"].ToString();
                mother.Text = reader["mother"].ToString();
                father.Text = reader["father"].ToString();
                address.Text = reader["address"].ToString();
                Phone.Text = reader["phone"].ToString();
                dob.Text = reader["dob"].ToString();
                dobt.Text = reader["dobt"].ToString();
                unit.Text = reader["unit"].ToString();
                doctor.Text = reader["doctor"].ToString();



            }

        }

        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("LibserBbook.aspx");
    }
}