using System;
using System.Collections.Generic;
using System.Text;

namespace week4course
{
    class Author
    {
        private string name;
        private string email;
        private int noOfVolume;
        public Author()
        {
            this.name = "default name";
            this.email = " default email";
            this.noOfVolume = 2;
        }
        public Author(string name, string email, int noOfVolume)
        {
            this.name = name;
            this.email = email;
            this.noOfVolume = noOfVolume;
        }
        public void PrintAuthor()
        {
            Console.WriteLine($"My name is: {this.name}, adress: {this.email}, volumes: {this.noOfVolume}");
        }
    }
}
