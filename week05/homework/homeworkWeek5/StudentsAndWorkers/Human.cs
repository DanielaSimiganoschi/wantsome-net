using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    public abstract class Human
    {
        protected string FirstName { set; get; }
        protected string LastName { set; get; }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public static void OrderAndPrintHumans(List<Human> listOFHumans)
        {
            var orderedList = listOFHumans.OrderBy(person => person.FirstName).ThenBy(person => person.LastName).ToList();
            foreach (var human in orderedList)
            {
                Console.WriteLine($"First Name: {human.FirstName}, Last Name: {human.LastName}.");
            }


        }
    }
}
