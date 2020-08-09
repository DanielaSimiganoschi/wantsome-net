using System;
using System.Collections.Generic;
using System.Text;

namespace week4course
{
    class Library
    {
        string address;
        DateTime openingHour;
        DateTime closingHour;
        List<Book> books;
        public Library()
        {
            this.address = "Iasi";
            this.openingHour = new DateTime(2020, 07, 28, 7, 0, 0);
            this.closingHour = new DateTime(2020, 07, 28, 18, 0, 0);
            this.books = new List<Book>();
        }
        public Library(string address, Book book)
        {
            this.address = address; 
            this.openingHour = new DateTime(2020, 07, 28, 7, 0, 0);
            this.closingHour = new DateTime(2020, 07, 28, 18, 0, 0);
            //this.books = new List<Book>();
            //this.books.Add(book);
            this.books = new List<Book> { book };
        }
    }
}
