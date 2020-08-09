using System;

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBase basePizza1 = new PizzaBase("Italian");
            Pizza pizza1 = new Pizza(basePizza1);
            pizza1.name = "Umami";
            PizzaTopping t1 = new PizzaTopping("Mozzarella", "Cheese");
            PizzaTopping t2 = new PizzaTopping("Ham", "Meat");
            PizzaTopping t3 = new PizzaTopping("Tomato", "Vegetable");
            PizzaTopping t4 = new PizzaTopping("Chicken", "Meat");
            pizza1.AddTopping(t1);
            pizza1.AddTopping(t2);
            pizza1.AddTopping(t3);
            pizza1.AddTopping(t4);



            PizzaBase basePizza2 = new PizzaBase("Italian");
            Pizza pizza2 = new Pizza(basePizza2);
            pizza2.name = "Greek";
            PizzaTopping t5 = new PizzaTopping("Feta", "Cheese");
            PizzaTopping t6 = new PizzaTopping("Olives", "Vegetable");
          
            pizza2.AddTopping(t5);
            pizza2.AddTopping(t6);


            pizza2.Print();

            var totalCostToppings = 0;
            foreach(var i in pizza2.toppings)
            {
                totalCostToppings += i.costTopping;
            }
           
            pizza2.CalculateTotalCost(totalCostToppings, PizzaBase.cost);
           

        }
    }
}
