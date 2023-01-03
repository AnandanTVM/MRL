using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class program_Doccasser1 : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand comm;
    SqlDataReader reader;
    String strcon;
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Convert.ToInt32(Request.QueryString.ToString());
        strcon = ConfigurationManager.ConnectionStrings["w"].ConnectionString;
        con = new SqlConnection(strcon);
        string uname = Session["x"].ToString();
        Label1.Text = uname.ToString();
        string utyp = Session["utyp"].ToString();
        con.Open();
        if (!Page.IsPostBack)
        {
            Label4.Text = id.ToString();
            Label5.Text = id.ToString();
          
            comm = new SqlCommand("select * from reg where user_name = '" + uname +"' ", con);
            reader = comm.ExecuteReader();
            if (reader.Read() == true)
            {
                
                Label2.Text = reader["reg_no"].ToString();


            }

        }
       
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ap = "pending";
        con.Open();
        comm = new SqlCommand("insert into drequ values('" + Label1.Text + "'," + Label2.Text + "," + Label4.Text + ",'" + TextBox5.Text + "','" + TextBox4.Text + "','" + TextBox6.Text + "','"+ ap + "',null,0)", con);
        comm.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Your Request Send For Apporavil...')", true);
        
      
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("DoctorHome.aspx");
    }

}