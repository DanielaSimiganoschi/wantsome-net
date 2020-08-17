using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExercise
{
    class Vehicle : IVehicle
    {
        public string ModelName { get; set; }
        public int BuildYear { get; set; }
        public IProducer Producer { get; set; }
        public double Price { get; set; }
    }
}
