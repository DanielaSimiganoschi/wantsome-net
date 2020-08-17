using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    internal class Student : Human
    {
        public decimal Grade { private set; get; }
  
        public Student(string firstName, string lastName, decimal grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public static void OrderAndPrintStudents(List<Student> listOFStuds)
        {
            var orderedList = listOFStuds.OrderBy(x => x.Grade).ToList();
            foreach (var stud in orderedList)
            {
                Console.WriteLine($"First NaemL {stud.FirstName}, Last Name: {stud.LastName}, Grade: {stud.Grade}");
            }
            
  
        }
       
    }
}
