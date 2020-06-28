using System.Web.Configuration;
using WebApplication1.Data;
using System.Web.UI;
using System;

public  partial class BookList : System.Web.UI.Page
{

    private string connectionString = WebConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ConnectionString;

    void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillBookGrid();
        }

    }

    private void FillBookGrid()
    {
        List<Book> BookList = new List<Book>();
        Book book = new Book();

        Booklist = book.GetBooks(connectionString);

        gridBookList.DataSource = BookList;
        gridBookList.DataBind();

    }

}
