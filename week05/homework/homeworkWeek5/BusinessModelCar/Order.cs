using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModelCar
{
    class Order : IOrder
    {

        public string OrderNumber;

        public void CancelOrder()
        {

        }

        public void PlaceOrder(Person person, Store store, Vehicle vehicle)
        { 
            this.OrderNumber = System.Guid.NewGuid().ToString(); 
        }
    }
}
