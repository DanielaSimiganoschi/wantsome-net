using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApp
{
    class Rate
    {

        public string currency { get; private set; }
      public int ammount {  get; private set; }
            
        public Rate(string currency, int ammount)
        {
            this.currency = currency;
            this.ammount = ammount;
        }


        public void PrintRate()
        {
            Console.WriteLine($"{this.ammount} {this.currency}");
        }
    }
}
