using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
public partial class program_LibUpcurrcasesheet : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    string strcon, d1 , sta;
    SqlDataReader rdr;
    int rid;
    protected void Page_Load(object sender, EventArgs e)
    {
        strcon = ConfigurationManager.ConnectionStrings["w"].ConnectionString;
        con = new SqlConnection(strcon);
         sta = "Pending";
     
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile && System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName) == ".pdf")
        {
            string fileName = FileUpload1.FileName;

            // string image = "/Images/" + fileName;
            //string storeImage = folderPath + fileName;
            if (!Directory.Exists(Server.MapPath("~/Images/uploads")))
            {
                Directory.CreateDirectory(Server.MapPath("~/Images/uploads"));
            }
            FileUpload1.SaveAs(System.IO.Path.Combine(Server.MapPath("~/Images/uploads"), fileName));
            var filePath = string.Format(@"\MRL\Images\uploads\{0}", fileName);
            con.Open();
            cmd = new SqlCommand("insert into Correction values(" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "','" + TextBox16.Text + "','" + TextBox17.Text + "','" + TextBox19.Text + "','" + TextBox18.Text + "','" + fileName + "','" + filePath + "','" + sta + "',0,null)", con);
            cmd.ExecuteNonQuery();

            //cmd = new SqlCommand("insert into imagetest1 (ImageName,ImagePath) values('" + fileName + "','" + filePath + "')", con);
            //cmd.ExecuteNonQuery();
            Label2.Text = "pdf upload successfully";
            // Label1.ForeColor = Color.Green;
            con.Close();
            // Image1.ImageUrl = fileName;

            //picture.Image = new Bitmap(fileName);
            /* con.Open();
             cmd = new SqlCommand("Select id, imagename, imagepath from imagetest1", con);
             SqlDataReader reader = cmd.ExecuteReader();
             GridView1.DataSource = reader;
             GridView1.DataBind();
             con.Close();*/

        }
        else
        {
            // Label1.ForeColor = Color.Red;
            Label1.Text = "Please select pdf";
        }
       // con.Open();
        //d1 = DateTime.Now.ToString("dd-MM-yyyy");
        //cmd = new SqlCommand("insert into Correction values(" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "','" + TextBox16.Text + "','" + TextBox17.Text + "','" + TextBox19.Text + "','" + TextBox18.Text + "','" + FileUpload1.FileName + "','" + sta + "',0,null)", con);
        //cmd.ExecuteNonQuery();
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
        TextBox12.Text = "";
        TextBox13.Text = "";
        TextBox14.Text = "";
        TextBox15.Text = "";
        TextBox16.Text = "";
        TextBox17.Text = "";
        TextBox18.Text = "";
        TextBox19.Text = "";
        Label1.Text = "Succesfully Added Your Information.. ";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("LiHome.aspx");
    }
}