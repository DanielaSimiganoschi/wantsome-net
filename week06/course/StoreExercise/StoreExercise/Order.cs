namespace StoreExercise
{
    internal class Order : IOrder
    {
        private IVehicle vehicle;
        private ICustomer customer;
       public int NumberOfWeeks { get; set; }

        public Order(IVehicle vehicle, ICustomer customer)
        {
            this.vehicle = vehicle;
            this.customer = customer;
        }
    }
}