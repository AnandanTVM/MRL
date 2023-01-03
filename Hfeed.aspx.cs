using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Hfeed : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    string strcon, d1;
    SqlDataReader rdr;
    int rid;
    protected void Page_Load(object sender, EventArgs e)
    {
        strcon = ConfigurationManager.ConnectionStrings["w"].ConnectionString;
        con = new SqlConnection(strcon);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        d1 = DateTime.Now.ToString("dd-MM-yyyy");
        cmd = new SqlCommand("insert into feedback values('" + TextBox1.Text + "','" + TextBox2.Text + "'," + TextBox3.Text + ",'" + TextBox4.Text + "','" + TextBox5.Text + "',0)", con);
        cmd.ExecuteNonQuery();
        con.Close();
        TextBox1.Text = "";
        TextBox2.Text = "";

        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox3.Text = "";
        Label1.Text = "Feedback Send Successfully!!";
    }
}