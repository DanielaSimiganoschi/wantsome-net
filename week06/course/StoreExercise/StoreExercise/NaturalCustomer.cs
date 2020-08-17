using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExercise
{
    class NaturalCustomer : ICustomer, IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public NaturalCustomer(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
