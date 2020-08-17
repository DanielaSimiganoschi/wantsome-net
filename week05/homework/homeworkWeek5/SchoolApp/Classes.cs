using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp
{
    class Classes : Comment
    {
        private static List<string> classIdentifiers = new List<string>();
        private List<Student> listOfStudents = new List<Student>();
        private List<Teachers> listOfTeachers = new List<Teachers>();


        public string Comment { set; get; }

        public Classes(string classIdentifierID)
        {
            if (classIdentifiers.Contains(classIdentifierID))
            {
                throw new ArgumentException("The Class Identifier must be unique.");
            }
            else
            {
                classIdentifiers.Add(classIdentifierID);
            }
        }

        public Classes(string classIdentifier, string comment)
        {
            if (classIdentifier.Contains(classIdentifier))
            {
                throw new ArgumentException("The Class Identifier must be unique.");
            }

            classIdentifiers.Add(classIdentifier);
            this.Comment = comment;
        }

        public void AddStudent(Student student)
        {
            listOfStudents.Add(student);
        }

        public void AddTeacher(Teachers teacher)
        {
            listOfTeachers.Add(teacher);
        }

    }
}
