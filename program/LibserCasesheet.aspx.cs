using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class program_LibserCasesheet : System.Web.UI.Page
{
    SqlCommand comm;
    SqlDataReader reader;
    SqlConnection con;
    //SqlDataReader rdr;
    SqlDataAdapter da;
    DataSet ds;
    string strl;
    string utyp;
    protected void Page_Load(object sender, EventArgs e)
    {
        strl = ConfigurationManager.ConnectionStrings["w"].ConnectionString;
        con = new SqlConnection(strl);
        
    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        string from = TextBox2.Text;
        string to = TextBox1.Text;
        string name = TextBox4.Text;
        string doa = TextBox5.Text;
        string ip = TextBox3.Text;
        
        string diseas = TextBox8.Text;
        string addr = TextBox7.Text;
        con.Open();
        comm = new SqlCommand("SELECT * From casesheet where doa between'" + to + "' and '" + from + "' or name = '" + name + "' or doa ='" + doa + "' or disease ='" + diseas + "' or address='" + addr + "'", con);
        reader = comm.ExecuteReader();
        if (reader.Read() == true)
        {
            con.Close();
            con.Open();
            da = new SqlDataAdapter("SELECT * From casesheet where doa between'" + to + "' and '" + from + "' or name ='" + name + "' or doa ='" + doa + "' or disease ='" + diseas + "' or address='" + addr + "' ", con);
            ds = new DataSet();
            da.Fill(ds, "casesheet");
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            Label1.Text = "Result Fount......";
        }
        else
        {
            Label1.Text = "Not Found......";
        }
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox7.Text = "";
            TextBox8.Text = "";
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}