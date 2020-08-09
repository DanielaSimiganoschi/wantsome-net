using System;
using System.Collections.Generic;
using System.Text;
namespace Professor_Student
{
    class Professor
    {
        private string nume;
        private string facultate;
        private string specializare;
        private static int nrProfesori;
        public void PrintProfesor()
        {
            Console.WriteLine($"I am professor {nume} from faculty {facultate}, specialisation {specializare}");
        }
        public Professor()
        {
            nrProfesori++;
        }
        public Professor(string nume, string facultate, string specializare)
        {
            this.nume = nume;
            this.facultate = facultate;
            this.specializare = specializare;
            nrProfesori++;
        }
        public static void PrintNrProfesori()
        {
            Console.WriteLine($"{nrProfesori} profesori");
        }
    }
}