using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class program_LibserBbook : System.Web.UI.Page
{
    SqlCommand comm;
    SqlConnection con;
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
        string father = TextBox7.Text;
        string dob = TextBox5.Text;
        string mother = TextBox6.Text;
        string addr = TextBox8.Text;

        con.Open();
        comm = new SqlCommand("SELECT * From brith where dob between'" + to + "' and '" + from + "' or name ='" + name + "' or father ='" + father + "' or dob ='" + dob + "' or mother ='" + mother + "' or address='" + addr + "'  ", con);
        reader = comm.ExecuteReader();
        if (reader.Read() == true)
        {
            con.Close();
            con.Open();
            da = new SqlDataAdapter("SELECT * From brith where dob between'" + to + "' and '" + from + "' or name ='" + name + "' or father ='" + father + "' or dob ='" + dob + "' or mother ='" + mother + "' or address='" + addr + "' ", con);
            ds = new DataSet();


            da.Fill(ds, "brith");
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
        //TextBox9.Text = "";
    }
}