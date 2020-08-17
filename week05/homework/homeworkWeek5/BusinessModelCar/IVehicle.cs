using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModelCar
{
    interface IVehicle
    {
        string NameModel { get; set; }
        int Year { get; set; }
        double Price { get; set; }
    }
}
