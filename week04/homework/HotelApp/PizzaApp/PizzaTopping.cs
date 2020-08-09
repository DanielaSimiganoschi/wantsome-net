using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    class PizzaTopping
    {

        public string name { private set; get; }
        private static int costCheese = 12;
        private static int costVegetable = 8;
        private static int costMeat = 15;
        
        public int costTopping { private set; get; }


        
       

        public PizzaTopping(string name, string typeTopping)
        {
           this.name = name;
            
            if (typeTopping == "Meat")
            {
                this.name = name.ToUpper();
                costTopping = costMeat;
            }
            else if (typeTopping == "Vegetable")
            {
                costTopping = costVegetable;
            }
            else
            {
                costTopping = costCheese;
            }
        
           
        }

      
        public void Print()
        {
            Console.WriteLine($"Name of the topping: {name}, cost of the toppings: {costTopping}.");
        }
    }
}
