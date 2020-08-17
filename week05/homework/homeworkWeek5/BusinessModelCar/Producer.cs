using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModelCar
{
    class Producer : IProducer
    {
        public string NameProducer { get; set; }

        
        public Producer(string name)
        {
            this.NameProducer = name;
        }
    }
}
