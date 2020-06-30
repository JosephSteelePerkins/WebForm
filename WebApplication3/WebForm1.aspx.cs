using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Data.SqlClient;


namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection SQLConn = new SqlConnection("Persist Security Info = False; Integrated Security = true; Initial Catalog = Books; server = (local)");
            SqlDataAdapter SQLAdaptor = new SqlDataAdapter("select * from dbo.Book", SQLConn);
            DataTable DT = new DataTable();
            SQLAdaptor.Fill(DT);
            GridView1.DataSource = DT;
            GridView1.DataBind();

        }

        protected void btnView_Click(object sender, EventArgs e)
        {

        }
    }
}