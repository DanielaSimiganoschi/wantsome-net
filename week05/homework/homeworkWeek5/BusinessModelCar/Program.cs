using System;

namespace BusinessModelCar
{
    class Program
    {
        static void Main(string[] args)
        {

            IStore FordStore = new Store("FordStore","Bucuresti");
            IStore SkodaStore = new Store("SkodaStore", "Bucuresti");

            IProducer Skoda = new Producer("Skoda");


            IVehicle SkodaOctavia = new Vehicle(Skoda,"Octavia", 2013, 15000);
            IVehicle SkodaFabia = new Vehicle(Skoda, "Fabia", 2016, 17000);
            IVehicle SkodaRapid = new Vehicle(Skoda, "Rapid", 2017, 9000);
           
            IPerson alex = new Person("Alex");
            IOrder orderAlexFordStore = new Order(alex, FordStore, SkodaOctavia);
            FordStore.AskForDelivery(orderAlexFordStore);
            FordStore.PlaceOrder(orderAlexFordStore);

            IOrder orderAlexSkodaStore = new Order(alex, SkodaStore, SkodaOctavia);

            SkodaStore.PlaceOrder(orderAlexSkodaStore);
            FordStore.CancelOrder(orderAlexFordStore);




        }
    }
}
