﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModelCar
{
    interface IStore
    {
        string NameStore { get; set; }
        string LocationStore { get; set; }
        int NumberOfWeeksDelivery { get; set; }
     
        void PlaceOrder(IOrder order);
        void CancelOrder(IOrder order);
        void AskForDelivery(IOrder order);
    }
}
