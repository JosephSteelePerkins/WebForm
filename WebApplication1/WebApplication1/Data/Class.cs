using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

public class Book
{

    public int BookId { get; set; }
    public string Title { get; set; }
    public string Isbn { get; set; }
    public string PublisherName { get; set; }
    public string AuthorName { get; set; }
    public string CategoryName { get; set; }

    public List<Book> GetBooks(string connectionString)

    {
        List<Book> bookList = new List<Book>();
        SqlConnection con = new SqlConnection(connectionString);

        string selectSQL = "select BookId, Title, Isbn, PublisherName, AuthorName, CategoryName  from GetBookData";

        con.Open();

        return bookList;
    }



   
    
}
