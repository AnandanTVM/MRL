using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class program_SupCorreqapp2 : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand comm, commm;
    SqlDataReader reader;
    String strcon;
    string utyp;
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Convert.ToInt32(Request.QueryString.ToString());
        strcon = ConfigurationManager.ConnectionStrings["w"].ConnectionString;
        con = new SqlConnection(strcon);

        
        if (!Page.IsPostBack)
        {
            con.Open();
            comm = new SqlCommand("select * from correction where ipno=" + id + "", con);
            reader = comm.ExecuteReader();
            {
                if (reader.Read() == true)
                {


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
                    comm.Dispose();
                    con.Close();
                     }
            }
             con.Open();
             comm = new SqlCommand("select * from casesheet where ip=" + id + "", con);
             reader = comm.ExecuteReader();
             if (reader.Read() == true)
             {
                 Label2.Text = reader["ip"].ToString();
                 TextBox1.Text = reader["name"].ToString();
                 TextBox2.Text = reader["gender"].ToString();
                 TextBox3.Text = reader["dob"].ToString();
                 Label5.Text = reader["doa"].ToString();
                 Label18.Text = reader["dog_d"].ToString();
                 TextBox4.Text = reader["father"].ToString();
                 TextBox5.Text = reader["mother"].ToString();
                 TextBox6.Text = reader["address"].ToString();
                 Label22.Text = reader["phone"].ToString();
                 Label23.Text = reader["disease"].ToString();
                 Label24.Text = reader["mrl_code"].ToString();
                 Label25.Text = reader["doctor"].ToString();
                 Label26.Text = reader["ward"].ToString();
                 Label27.Text = reader["currentstatus"].ToString();

                 comm.Dispose();
                 con.Close();

             }
         }
        }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String sta = "Approval";
        con.Open();
        comm = new SqlCommand("UPDATE casesheet  SET name ='" + TextBox1.Text + "', gender = '" + TextBox2.Text + "', dob = '" + TextBox3.Text + "', father = '" + TextBox4.Text + "' , mother ='" + TextBox5.Text + "', address ='" + TextBox6.Text + "' where ip=" + id + " ", con);
        comm.ExecuteNonQuery();

        comm.Dispose();
        con.Close();
        con.Open();
        comm = new SqlCommand("UPDATE correction  SET ststusap = '" + sta + "'  ,status = " + 1 + "  where  ipno=" + id + "", con);
        comm.ExecuteNonQuery();
        comm.Dispose();
        con.Close();
       
   
    }
}

            
           
            
        

    