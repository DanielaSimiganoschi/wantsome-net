using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModelCar
{
    class Store : IStore
    {
        public string NameStore { get; set; }
        public string LocationStore { get; set; }
        public int NumberOfWeeksDelivery { get; set; }

        public List<Producer> ListOfProducers = new List<Producer>();
        public List<Vehicle> ListOfVehicles = new List<Vehicle>();

        public Store(string name, string location)
        {
            this.NameStore = name;
            this.LocationStore = location;
        }

        public void AddProducer(Producer producer)
        {
            ListOfProducers.Add(producer);
        }

        public void AddVehicle(Vehicle vehicle)
        {
            ListOfVehicles.Add(vehicle);
        }
    }
}
