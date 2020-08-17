using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModelCar
{
    interface IOrder
    {
        int OrderNumber { get; set; }
        void PlaceOrder();
        void CancelOrder();
    }
}
