using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class program_Adolddetails1 : System.Web.UI.Page
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


            comm = new SqlCommand("select * from reg where uid=" + id + "", con);
            reader = comm.ExecuteReader();
            if (reader.Read() == true)
            {
                post.Text = reader["post"].ToString();
                name.Text = reader["name"].ToString();
                user_name.Text = reader["user_name"].ToString();
                password.Text = reader["password"].ToString();
                addressinfo.Text = reader["addressinfo"].ToString();
                phone.Text = reader["phone"].ToString();
                email.Text = reader["email"].ToString();
                boj.Text = reader["boj"].ToString();
                reg_no.Text = reader["reg_no"].ToString();




            }

        }

        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Adolddetails.aspx");
    }
}