using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModelCar
{
    class Vehicle : IVehicle
    {
        public string NameModel { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public Producer Producer { get; private set; }

        public Vehicle(Producer producer, string name, int year, double price)
        {
            this.Producer = producer;
            this.NameModel = name;
            this.Year = year;
            this.Price = price;
        }
    }
}
