using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModelCar
{
    class Store : IStore
    {
        
        public string NameStore { get; set; }
        public string LocationStore { get; set; }
        public int NumberOfWeeksDelivery { get; set; }

       
        public List<IOrder> orderList = new List<IOrder>();

        public Store(string name, string location)
        {
            this.NameStore = name;
            this.LocationStore = location;
        }

        public void PlaceOrder(IOrder order)
        {
            orderList.Add(order);
          
        }

        public void CancelOrder(IOrder order)
        {
            if (orderList.Contains(order))
            {
                orderList.Remove(order);
            }
        }

        public void AskForDelivery(IOrder order)
        {
            Console.WriteLine($"Delivery time for your order will take "+ new Random().Next(1,10)+" weeks.");
        }

    }
}
