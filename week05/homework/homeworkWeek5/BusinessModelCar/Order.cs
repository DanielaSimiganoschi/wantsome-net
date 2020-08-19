using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModelCar
{
    class Order : IOrder
    {

        public string OrderNumber { get; set; }
        private IPerson person;
        private IStore store;
        private IVehicle vehicle;

        public void CancelOrder()
        {

        }

        public Order (IPerson person, IStore store, IVehicle vehicle)
        {
            this.OrderNumber = Guid.NewGuid().ToString();
            this.person = person;
            this.store = store;
            this.vehicle = vehicle;
        }
    }
}
