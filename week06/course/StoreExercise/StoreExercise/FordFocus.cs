using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExercise
{
    class FordFocus:Vehicle
    {
        public FordFocus(int yearBuild, double price)
        {
            this.BuildYear = yearBuild;
            this.Price = price;
            this.Producer = new FordProducer();
            this.ModelName = "Ford Focus";
        }
    }
}
