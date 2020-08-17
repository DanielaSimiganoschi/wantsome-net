using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExercise
{
    class SkodaOctavia:IVehicle
    {

       
        public string ModelName { get; set; }
        public int BuildYear { get; set; }
        public IProducer Producer { get; set; }
        public double Price { get; set; }

        public SkodaOctavia(int year, double price)
        {
            this.BuildYear = year;
            this.Price = price;
            this.ModelName = "Skoda Octavia";
        }
    }
}
