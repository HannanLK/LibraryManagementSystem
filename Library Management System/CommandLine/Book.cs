using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    private string title;
    private string author;
    private string isbn;
    private double price;
    private int quantity;

    public string Title { get { return title; } set { title = value; } }
    public string Author { get { return author; } set { author = value; } }
    public string ISBN { get { return isbn; } set { isbn = value; } }
    public double Price { get { return price; } set { price = value; } }
    public int Quantity { get { return quantity; } set { quantity = value; } }

    public Book(string title, string author, string isbn, double price, int quantity)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Price = price;
        Quantity = quantity;
    }

    public Student BorrowedBy { get; set; }
}

