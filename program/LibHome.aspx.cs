using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class program_LibHome : System.Web.UI.Page
{
    string utyp, name;
    protected void Page_Load(object sender, EventArgs e)
    {
        name = Session["x"].ToString();
        utyp = Session["utyp"].ToString();
        Label1.Text = name;
    }
}