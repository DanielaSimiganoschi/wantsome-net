using System;

namespace StoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IPerson alex = new NaturalCustomer("Alex","Popescu",30);
            ICustomer alexAutoConsult = new JuridicalCustomer(alex, "alexAutoConsult");

            Store fordStore = new FordStore();
            IVehicle fordVehicle = new FordFocus(2016, 15000);
            IOrder order1 = new Order(fordVehicle, alexAutoConsult);
            fordStore.ProcessOrder(order1, alexAutoConsult);
            fordStore.AskForDeliveryTime(order1);

            Store skodaStore = new SkodaStore();
            IVehicle skodaVehicle = new SkodaOctavia(2017, 17000);
            IOrder order2 = new Order(skodaVehicle, alexAutoConsult);
            skodaStore.ProcessOrder(order2, alexAutoConsult);
            fordStore.CancelOrder(order1, alexAutoConsult);
            
        }
    }
}
