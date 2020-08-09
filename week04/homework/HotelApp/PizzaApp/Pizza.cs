using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    class Pizza
    {

    public PizzaBase pizzaBase { private set; get; }
        public string toppingsMeat;
        public string toppingsVegetable;
        public string toppingsCheese;
        public string name;

        public List<PizzaTopping> toppings = new List<PizzaTopping>();
        public static int totalCost;
  

        public void AddTopping(PizzaTopping topping)
        {
            this.toppings.Add(topping);
            
        }

        public void CalculateTotalCost(int toppingsCost, int baseCost)
        {
            var totalCostPizza = toppingsCost + baseCost;
            Console.WriteLine($"Total cost of the pizza will be {totalCostPizza}");
        }

        public Pizza (PizzaBase basePizza)
        {
            this.pizzaBase = basePizza;
        }

        public void Print()
        {
            Console.WriteLine($"Pizza name {this.name}");
            Console.WriteLine($"Pizza base {this.pizzaBase.name}");
            Console.WriteLine("---------");
            Console.WriteLine("Toppings:");
            foreach (var i in toppings)
            {
                Console.WriteLine(i.name);
            }
           
        }

    }
}
