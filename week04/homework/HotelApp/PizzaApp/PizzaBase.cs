using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    class PizzaBase
    {

        public string name { private set;  get; }
        public static int cost { private set;  get; }

        private static int costItalian = 12;
        private static int costThick = 15;
        private static int costRegular = 17;

        public PizzaBase(string name)
        {
            this.name = name;
            if(name == "Italian")
            {
                cost = costItalian;
            } else if (name == "Thick")
            {
                cost = costThick;
            } else
            {
                cost = costRegular;
            }
        }
        public void Print()
        {
            Console.WriteLine($"Name of the base: {name}, cost of the base: {cost}.");
        }
    }
}
