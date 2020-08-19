using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModelCar
{
    class Vehicle : IVehicle, IProducer
    {
        public string NameModel { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public IProducer Producer { get; private set; }
        public string NameProducer { get; set; }

        public Vehicle(IProducer producer, string name, int year, double price)
        {
            this.Producer = producer;
            this.NameModel = name;
            this.Year = year;
            this.Price = price;
        }
    }
}
