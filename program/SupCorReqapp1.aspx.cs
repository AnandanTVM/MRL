using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class program_SupCorReqapp1 : System.Web.UI.Page
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


        con.Open();

        SqlCommand com = new SqlCommand("Select ipno,imagename, imagepath from Correction where ipno = " + id + " ", con);
        SqlDataReader reader = com.ExecuteReader();



        GridView1.DataSource = reader;
        GridView1.DataBind();
        con.Close();
      

        con.Open();
        if (!Page.IsPostBack)
        {


            comm = new SqlCommand("select * from correction where ipno=" + id + "", con);
            reader = comm.ExecuteReader();
            if (reader.Read() == true)
            {
                Label1.Text = reader["ipno"].ToString();
                Label2.Text = reader["name"].ToString();
                Label3.Text = reader["Pname"].ToString();
                Label4.Text = reader["relation"].ToString();
                Label5.Text = reader["address"].ToString();
                Label6.Text = reader["Wname"].ToString();
                Label7.Text = reader["cname"].ToString();
                Label8.Text = reader["wgenter"].ToString();
                Label9.Text = reader["cgenter"].ToString();
                Label10.Text = reader["wdob"].ToString();
                Label11.Text = reader["cdob"].ToString();
                Label12.Text = reader["wfather"].ToString();
                Label13.Text = reader["cfather"].ToString();
                Label14.Text = reader["wmother"].ToString();
                Label15.Text = reader["cmother"].ToString();
                Label16.Text = reader["waddress"].ToString();
                Label17.Text = reader["caddress"].ToString();
                Label19.Text = reader["date"].ToString();
                Label20.Text = reader["doc"].ToString();
            }

        }
        
        con.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        Label18.Visible = true;
        TextBox1.Visible = true;
        Button4.Visible = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupCorreqapp2.aspx?"+id);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        String sta = "Rejection";
        con.Open();
        comm = new SqlCommand("UPDATE correction  SET ststusap = '" + sta + "'  ,status = " + 1 + ",reson='" + TextBox1.Visible + "' where  ipno=" + id + "", con);
        comm.ExecuteNonQuery();
        comm.Dispose();
        con.Close();
    }
}