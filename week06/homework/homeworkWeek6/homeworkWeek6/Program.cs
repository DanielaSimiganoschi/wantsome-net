using System;

namespace homeworkWeek6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Daniela", "Maria", "Popescu", "15616515EL", "Egalitatii", "0754613651", "d.sad@yahoo.com", ".Net");
            Student student2 = new Student("Ioana", "Maria", "Stupica", "6465464AB", "Zorilor", "0756223215", "i.apkd@yahoo.com", ".Net");


            var string1 = student1.ToString();
            Console.WriteLine(string1);

            var equals = student2.Equals(student2);

            Console.WriteLine(equals);

            var hash = student2.GetHashCode();
            Console.WriteLine(hash);

            if (student1 != student2)
            {
                Console.WriteLine(true);
            }
            else { Console.WriteLine(false); }

            var student3 = student2.Clone();
            student2.FirstName = "Georgeta";
            var student3String = student3.ToString();
            Console.WriteLine(student3String);



        }
    }
}
