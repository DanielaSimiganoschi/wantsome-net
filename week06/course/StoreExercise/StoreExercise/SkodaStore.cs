using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExercise
{
    class SkodaStore : Store
    {
        public string Name { get => typeof(SkodaStore).Name; }

        public override void CancelOrder(IOrder order, ICustomer customer)
        {
            if (OrdersList[customer].Contains(order))
            {
                OrdersList[customer].Remove(order);
            }
            else
            {
                Console.WriteLine("the order does not exist");
            }
        }

        public override void ProcessOrder(IOrder order, ICustomer customer)
        {
            order.NumberOfWeeks = new Random().Next();
            if (!OrdersList.ContainsKey(customer))
            {
                OrdersList.Add(customer, new List<IOrder> { order });
            }
            else
            {
                OrdersList[customer].Add(order);
            }

        }
    }
}
