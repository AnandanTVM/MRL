using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class program_SupserDbook : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand comm;
    SqlDataReader reader;

    //SqlDataReader rdr;
    SqlDataAdapter da;
    DataSet ds;
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
        string from = TextBox2.Text;
        string to = TextBox3.Text;
        string name = TextBox4.Text;
        string caseofdath = TextBox7.Text;
        string datedeath = TextBox5.Text;
        string dateadmit = TextBox6.Text;
        string address = TextBox8.Text;
        string IP = TextBox9.Text;
        con.Open();
        comm = new SqlCommand("SELECT * From death where datedeath between '" + TextBox3.Text + "' and '" + TextBox2.Text + "' or caseofdath = '" + caseofdath + "' or name = '" + name + "' or dateadmit = '" + dateadmit + "' or address = '" + address + "' or datedeath ='" + datedeath + "'  ", con);
        reader = comm.ExecuteReader();
        if (reader.Read() == true)
        {
            con.Close();
            con.Open();
            da = new SqlDataAdapter("SELECT * From death where datedeath between '" + to + "' and '" + from + "'  or caseofdath = '" + caseofdath + "' or name = '" + name + "' or dateadmit = '" + dateadmit + "' or address = '" + address + "' or datedeath ='" + datedeath + "'  ", con);
            ds = new DataSet();


            da.Fill(ds, "death");
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            Label1.Text = "Result Found......";
        }
        else
        {
            Label1.Text = "Not Found......";
        }
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
    }
}