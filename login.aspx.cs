using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
public partial class login : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    SqlDataReader rdr;
    string strl;
    string utyp;
    protected void Page_Load(object sender, EventArgs e)
    {
        strl = ConfigurationManager.ConnectionStrings["w"].ConnectionString;
        con = new SqlConnection(strl);
        TextBox2.Focus();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string un = TextBox1.Text;
        string pw = TextBox2.Text;

        con.Open();
        cmd = new SqlCommand("SELECT * From Login where user_name='" + un + "' and password='" + pw + "'", con);
        rdr = cmd.ExecuteReader();
        if (rdr.Read())
        {
            utyp = rdr["post"].ToString();
            
        }
        con.Close();
        Session["x"] = un;
        Session["utyp"] = utyp;
        if (utyp == "Doctor")
        {
            Response.Redirect("program/DoctorHome.aspx");

        }
        else if (utyp == "Superintent")
        {
            Response.Redirect("program/SupHome.aspx");
        }
        else if (utyp == "Librarian")
        {
            Response.Redirect("program/LibHome.aspx");
        }
        else if (utyp == "Counter")
        {
            Response.Redirect("program/CounHome.aspx");
        }
        else if (utyp == "admin")
        {
            Response.Redirect("program/adminHome.aspx");
        }
        else
        {
            Label3.Text = "Invalid User Name or Password";
        }
        
    
    }
}