using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApp
{
    class Room
    {

        private string name;
        private int adults;
        private int children;
        public Rate rate { get; private set; }

        public Room (string name, int adults, int children, Rate rate)
        {
            this.name = name;
            this.adults = adults;
            this.children = children;
            this.rate = rate;
        }
        public void GetPriceForDays(int numberOfDays)
        {
            var amount = numberOfDays * rate.ammount;

            Console.WriteLine(amount);
        }

        public void Print()
        {
            Console.WriteLine($"Room {this.name}, it fits {this.adults} adults and {this.children}, and the price per night is:");
            rate.PrintRate();
       

        }
    }
}
