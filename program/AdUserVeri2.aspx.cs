using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class program_AdUserVeri2 : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand comm;
    SqlDataReader reader;
    String strcon;
    string utyp,sot;
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Convert.ToInt32(Request.QueryString.ToString());
        strcon = ConfigurationManager.ConnectionStrings["w"].ConnectionString;


        // Name = Session["x"].ToString();
        //utyp = Session["utyp"].ToString();
        // ids = Session["id"].ToString();

        // Label1.Text = Name;


        con = new SqlConnection(strcon);
        string uname = Session["x"].ToString();
        //Label2.Text = uname.ToString();
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

        Response.Redirect("AdUserVeri1.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //Label1.Visible = true;
        //TextBox1.Visible = true;
        // Button1.Visible = true;
        // Button2.Visible = true;
        // RequiredFieldValidator1.Visible = true;
        // RequiredFieldValidator1.Enabled = true;

        //RequiredFieldValidator1.Visible = true;
        //RequiredFieldValidator1.Enabled = true;
        con.Open();
        comm = new SqlCommand("update reg set status =1 where uid=" + id + "", con);
        comm.ExecuteNonQuery();
        con.Close();
        sot = "Doctor";
        con.Open();
        if (post.Text == sot)
        {
            comm = new SqlCommand("insert into login values('" + post.Text + "','" + user_name.Text + "','" + password.Text + "', " + reg_no.Text + ",0)", con);
            comm.ExecuteNonQuery();
            con.Close();
        }
        else
        {
            comm = new SqlCommand("insert into login values('" + post.Text + "','" + user_name.Text + "','" + password.Text + "',null,0)", con);
            comm.ExecuteNonQuery();
            con.Close();
        }

        Response.Redirect("AdUserVeri1.aspx");
        


    }
}