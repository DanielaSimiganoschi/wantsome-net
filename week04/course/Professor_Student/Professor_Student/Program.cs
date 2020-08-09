using System;
namespace Professor_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p1 = new Professor();
            Professor p2 = new Professor("Ionescu", "FEAA", "AgroEconomie");
            Professor.PrintNrProfesori();
        }
    }
}