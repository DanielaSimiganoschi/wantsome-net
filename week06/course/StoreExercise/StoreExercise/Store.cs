using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExercise
{
     abstract class Store
    {
        protected Dictionary<ICustomer, List<IOrder>> OrdersList;
        string Name { get; }
        public abstract void ProcessOrder(IOrder order, ICustomer customer);

        public Store()
        {
            OrdersList = new Dictionary<ICustomer, List<IOrder>>();
        }
        public void AskForDeliveryTime(IOrder order)
        {
            Console.WriteLine("Your product will be delivered in " + order.NumberOfWeeks);
        }
        public abstract void CancelOrder(IOrder order, ICustomer customer);


    }
}
