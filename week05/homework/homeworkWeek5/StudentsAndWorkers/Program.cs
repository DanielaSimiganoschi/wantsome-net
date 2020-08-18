using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Human stud1 = new Student("Maria", "Ionescu", 7.21m);
            Human stud2 = new Student("Marius", "Popescu", 8.24m);
            Human stud3 = new Student("Ioana", "Constantinescu", 9.06m);
            Human stud4 = new Student("Ionut", "David", 5.19m);
            Human stud5 = new Student("Claudiu", "Botez", 4.88m);
            Human stud6 = new Student("Claudia", "Popescu", 7.91m);
            Human stud7 = new Student("Mirela", "Sirghe", 6.47m);
            Human stud8 = new Student("Dominic", "Iftodi", 9.13m);
            Human stud9 = new Student("Paul", "Lupascu", 5.79m);
            Human stud10 = new Student("Andreea", "Isarie", 7.90m);

            List<Human> listStudentsH = new List<Human>();
            listStudentsH.AddRange(new List<Human>() { stud1, stud2, stud3, stud4, stud5, stud6, stud7, stud8, stud9, stud10});


            List<Student> studentList = listStudentsH.OfType<Student>().ToList();

           Student.OrderAndPrintStudents(studentList);

            Human worker1 = new Worker("Maria", "Constantinescu", 520,5);
            Human worker2 = new Worker("Marius", "Popa", 620, 6);
            Human worker3 = new Worker("Ioana", "Sadoveanu", 459, 7);
            Human worker4 = new Worker("Mirela", "David", 780, 4);
            Human worker5 = new Worker("Diana", "Botez", 654, 9);
            Human worker6 = new Worker("Claudia", "Schipor", 420, 3);
            Human worker7 = new Worker("Mirela", "Sirghe", 800, 7);
            Human worker8 = new Worker("Maria", "Gabor", 120, 2);
            Human worker9 = new Worker("Sonia", "Andronic", 1000, 8);
            Human worker10 = new Worker("Andreea", "Gherca", 456, 4);

            List<Human> listWorkersH = new List<Human>();
            listWorkersH.AddRange(new List<Human>() { worker1, worker2, worker3, worker4, worker5, worker6, worker7, worker8, worker9, worker10 });


            List<Worker> listOfWorkers = listWorkersH.OfType<Worker>().ToList(); 


           Worker.OrderAndPrintWorkers(listOfWorkers);


            var allHumans = listWorkersH.Concat(listStudentsH).ToList();

            Human.OrderAndPrintHumans(allHumans);


        }
    }
}
