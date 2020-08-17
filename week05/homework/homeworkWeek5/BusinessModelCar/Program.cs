using System;

namespace BusinessModelCar
{
    class Program
    {
        static void Main(string[] args)
        {

            Store FordStore = new Store("FordStore","Bucuresti");
            Store SkodaStore = new Store("SkodaStore", "Bucuresti");

            Producer Skoda = new Producer("Skoda");


            FordStore.AddProducer(Skoda);
            SkodaStore.AddProducer(Skoda);

            Vehicle SkodaOctavia = new Vehicle(Skoda,"Octavia", 2013, 15000);
            Vehicle SkodaFabia = new Vehicle(Skoda, "Fabia", 2016, 17000);
            Vehicle SkodaRapid = new Vehicle(Skoda, "Rapid", 2017, 9000);
           

            FordStore.AddVehicle(SkodaOctavia);
            FordStore.AddVehicle(SkodaFabia);

            SkodaStore.AddVehicle(SkodaOctavia);
            SkodaStore.AddVehicle(SkodaFabia);
            SkodaStore.AddVehicle(SkodaRapid);
    
            Person Alex = new Person()

        }
    }
}
