using System;
using System.Collections.Generic;
using System.Text;

namespace week4course
{
    class Book
    {
        private string title;
        private Author author;
        private int year;
        private double price;
        public Book()
        {
            this.title = "default title";
            this.author = new Author();
            this.year = 2020;
            this.price = 9.99;
        }
        public Book(string title, int year, double price)
        {
            this.title = title;
            this.author = new Author();
            this.year = year;
            this.price = price;
        }
        public Book(string title, string nameAuthor, string emailAuthor, int noOfVolumesAuthor, int year, double price)
        {
            this.title = title;
            this.author = new Author(nameAuthor, emailAuthor, noOfVolumesAuthor);
            this.year = year;
            this.price = price;
        }
        public Book(string title, Author author, int year, double price)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.price = price;
        }
        public void PrintBook()
        {
            Console.WriteLine($"Title: {this.title}, Year: {this.year}, Price: {this.price}");
            author.PrintAuthor();
        }
    }
}
