using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    class Worker : Human
    {
        public decimal WeekSalary { private set; get; }
        public int WorkHoursPerDay { private set; get; }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = WeekSalary / (Convert.ToDecimal(WorkHoursPerDay)*7);
            return moneyPerHour;
        }

        public static void OrderAndPrintWorkers(List<Worker> listOFStuds)
        {
            var orderedList = listOFStuds.OrderBy(x => x.MoneyPerHour()).ToList();
            foreach (var worker in orderedList)
            {
                Console.WriteLine($"First Name: {worker.FirstName}, Last Name: {worker.LastName}, Money per Hour: {Math.Round(worker.MoneyPerHour(),2)}");
            }


        }

    }
}
