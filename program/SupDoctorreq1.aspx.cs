using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class program_SupDoctorreq1 : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand comm;
    SqlDataReader reader;
    String strcon;
    int id;
    string a, b, c, d, e1, f, g, h, i, j, k, l, m,n, o, p,qq,p5="Approval",p6="Rejection";
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Convert.ToInt32(Request.QueryString.ToString());
        strcon = ConfigurationManager.ConnectionStrings["w"].ConnectionString;
        con = new SqlConnection(strcon);
       // string uname = Session["x"].ToString();
       // Label1.Text = uname.ToString();Label2.Text = reader["regno"].ToString();
        //string utyp = Session["utyp"].ToString();
        con.Open();
        if (!Page.IsPostBack)
        {
           

            comm = new SqlCommand("select * from drequ where  rid= '" + id + "' ", con);
            reader = comm.ExecuteReader();
            if (reader.Read() == true)
            {

                
                Label1.Text = reader["drname"].ToString();
                Label2.Text = reader["regno"].ToString();
                Label4.Text = reader["reqipno"].ToString();
                Label5.Text = reader["reqipno"].ToString();
                Label6.Text = reader["reson"].ToString();
                Label7.Text = reader["remark"].ToString();
                Label8.Text = reader["reqtime"].ToString();
            }

        }

        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label9.Visible = true;
        Label10.Visible = true;
        TextBox1.Visible = true;
        TextBox2.Visible = true;
        Button3.Visible = true;
        
       


            }

    protected void Button3_Click(object sender, EventArgs e)
    {
        p5 = "Approval";
        con.Open();



        comm = new SqlCommand("select * from casesheet where ip ='" + Label4.Text + "' ", con);
        reader = comm.ExecuteReader();
        if (reader.Read() == true)
        {
            a = reader["ip"].ToString();
            b = reader["name"].ToString();
            c = reader["gender"].ToString();
            d = reader["dob"].ToString();
            e1 = reader["doa"].ToString();
            f = reader["dog_d"].ToString();
            g = reader["father"].ToString();
            h = reader["mother"].ToString();
            i = reader["address"].ToString();
            j = reader["phone"].ToString();
            k = reader["disease"].ToString();
            o = reader["mrl_code"].ToString();
            n = reader["doctor"].ToString();
            m = reader["ward"].ToString();
            p = reader["currentstatus"].ToString();
            qq = reader["scandata"].ToString();

            comm.Dispose();

            con.Close();

            con.Open();

            //d1 = DateTime.Now.ToString("dd-MM-yyyy");
            comm = new SqlCommand("insert into appreqdoctor values(" + a + ",'" + b + "','" + c + "','" + d + "','" + e1 + "','" + f + "','" + g + "','" + h + "','" + i + "'," + j + ",'" + k + "','" + o + "','" + n + "','" + m + "','" + p + "','" + qq + "',' " + Label1.Text + " '," + Label2.Text + ",' " + TextBox1.Text + " ',' " + p5 + " ',' " + TextBox2.Text + " ',0)", con);
            comm.ExecuteNonQuery();

            comm.Dispose();

            con.Close();

            con.Open();
            comm = new SqlCommand("UPDATE drequ  SET reqstatus ='" + p5 + "',status ='" + 1 + "' where rid=" + id + " ", con);
            comm.ExecuteNonQuery();

            comm.Dispose();
            con.Close();
            Response.Redirect("SupHome.aspx");
           

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label9.Visible = true;
        TextBox1.Visible = true;
        Button4.Visible = true;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        p6 = "Rejection";
        con.Open();
        comm = new SqlCommand("UPDATE drequ  SET reqstatus ='" + p6 + "',status ='" + 2 + "',supreqremark='" +  TextBox1.Text + "'  where rid=" + id + " ", con);
        comm.ExecuteNonQuery();

        comm.Dispose();
        con.Close();
        Response.Redirect("SupHome.aspx");
    }
}

        

    
