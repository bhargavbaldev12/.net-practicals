using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            ((Site1)Master).BtnSearch.Click += new EventHandler(BtnSearch_Click);
        }

        void BtnSearch_Click(object sender, EventArgs e) {
            getData();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        void getData() {
            string s= ((Site1)Master).TxtSearch.Text;
            Console.WriteLine(s);
            string source = @"Data Source=Mishil-Patel\SQLExpress;Initial Catalog=DemoDb;Integrated Security=True;Pooling=False";
            string select = "select * from tblstudent where fname like '%"+ ((Site1)Master).TxtSearch.Text + "%'";
            SqlConnection con = new SqlConnection(source);
            SqlCommand cmd = new SqlCommand(select, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            grdstudent.DataSource = rdr;
            grdstudent.DataBind();
            con.Close();
        }
    }
}