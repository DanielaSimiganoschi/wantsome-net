using System;

namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student(1, "Maria Popescu");
            Student student2 = new Student(1, "Marius Popescu");
            Student student3 = new Student(1, "Mariana Popescu");

            Classes class1 = new Classes("Z2");
            class1.AddStudent(student1);
            class1.AddStudent(student2);
            class1.AddStudent(student3);

            Disciplines matematica = new Disciplines("Matematica", 12, 23);
            Disciplines lbRomana = new Disciplines("Limbra Romana", 12, 23);
            Disciplines informatica = new Disciplines("Informatica", 12, 23);

            Teachers teacher1 = new Teachers("Maria Costin");
            teacher1.AddDiscipline(matematica);
            teacher1.AddDiscipline(lbRomana);
            teacher1.AddDiscipline(informatica);

            Teachers teacher2 = new Teachers("Marius Ignat");
            teacher2.AddDiscipline(matematica);
            teacher2.AddDiscipline(lbRomana);
            teacher2.AddDiscipline(informatica);

            class1.AddTeacher(teacher1);
            class1.AddTeacher(teacher2);

            School school1 = new School();
            school1.AddClasses(class1);

           
        }
    }
}
