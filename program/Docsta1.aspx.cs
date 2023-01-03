using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class program_Docsta1 : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand comm;
    SqlDataReader reader;
    String strcon;
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        string ipll = "pending";
        string ipl,srej;
        id = Convert.ToInt32(Request.QueryString.ToString());
        
        strcon = ConfigurationManager.ConnectionStrings["w"].ConnectionString;
        con = new SqlConnection(strcon);
        string uname = Session["x"].ToString();

        string utyp = Session["utyp"].ToString();
        if (!Page.IsPostBack)
        {
            con.Open();
            comm = new SqlCommand("select * from drequ where  rid= '" + id + "' ", con);
            reader = comm.ExecuteReader();
            if (reader.Read() == true)
            {
                ipl = reader["status"].ToString();
                srej = reader["supreqremark"].ToString();
                if (ipll == ipl)
                {
                    Label1.Text = " Your Reguest Is processing pls Wait Until You Get Approval ";

                }
                else
                {
                    Label1.Text = " Your Request Is Reject ";
                    Label2.Text = srej;
                }
            }
            con.Close();
        }

    }
}