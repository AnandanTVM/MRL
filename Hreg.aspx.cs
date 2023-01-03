using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Hreg : System.Web.UI.Page
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
        if (DropDownList1.SelectedItem.Text == "Doctor")
        {
            TextBox11.Enabled = true;
            //Label3.Text = "";
            //Label3.Visible = true;
            //Label2.Visible = true;

            //TextBox3.Visible = true;
            //rfdep.Visible = true;
            //rfdesi.Visible = true;
            con.Open();
            d1 = DateTime.Now.ToString("dd-MM-yyyy");
            cmd = new SqlCommand("insert into reg values('" + DropDownList1.SelectedItem.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "'," + TextBox7.Text + ",'" + TextBox8.Text + "','" + RadioButtonList1.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "'," + TextBox11.Text + ",0)", con);
            cmd.ExecuteNonQuery();
            con.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";

            Label3.Text = "Succesfully Added Your Information..";
        }
        else
        {
            TextBox11.Enabled = false;
            con.Open();
            d1 = DateTime.Now.ToString("dd-MM-yyyy");
            cmd = new SqlCommand("insert into reg values('" + DropDownList1.SelectedItem.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "'," + TextBox7.Text + ",'" + TextBox8.Text + "','" + RadioButtonList1.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "',0,0,null,null)", con);
            cmd.ExecuteNonQuery();
            con.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            Label3.Text = "Succesfully Added Your Information.. ";
        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Text == "Doctor")
        {
            TextBox11.Enabled = true;

        }
        else if (DropDownList1.SelectedItem.Text == "Superintent")
        {
            TextBox11.Enabled = false;
       }
        else if (DropDownList1.SelectedItem.Text == "Librarian")
        {
            TextBox11.Enabled = false;
        }
        else if (DropDownList1.SelectedItem.Text == "Counter")
        {
            TextBox11.Enabled = false;
        }
        
    }
}