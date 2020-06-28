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

        SqlCommand cmd = new SqlCommand(selectSQL, con);

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr != null)
        {
            while (dr.Read())
            {
                Book book = new Book();
                book.BookId = Convert.ToInt32(dr["BookId"]);
                book.Title = dr["Title"].ToString();
                book.Isbn = dr["ISBN"].ToString();
                book.PublisherName = dr["PublisherName"].ToString();
                book.AuthorName = dr["AuthorName"].ToString();
                book.CategoryName = dr["CategoryName"].ToString();
                bookList.Add(book);
            }
        }

        return bookList;
    }



   
    
}
