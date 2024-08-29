using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.CLASSES
{
    public class Book
    {
        //public int ID {  get; set; }
        //public string Title { get; set; }
        //public string Author { get; set; }
        //public string ISBN { get; set; }
        //public int Quantity { get; set; }
        //public decimal Price { get; set; }

        private string title;
        private string author;
        private string isbn;
        private int quantity;
        private decimal price;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        //constructor class
        public Book(string btitle, string bauthor, string bisbn, int bquanity, decimal bprice)
        {
            //ID = id;
            Title = btitle;
            Author = bauthor;
            ISBN = bisbn;
            Quantity = bquanity;
            Price = bprice;

        }

    }
}
