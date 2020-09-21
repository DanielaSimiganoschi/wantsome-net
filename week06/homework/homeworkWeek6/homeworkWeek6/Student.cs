using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkWeek6
{
    class Student : Human, ICloneable, IComparable
    {

        public Student(string firstName, string middleName, string lastName, string SSN, string permanentAddress, string phoneNumber, string email, string course)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = SSN;
            this.PermanentAddress = permanentAddress;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Course = course;
        }

        public override string ToString()
        {
            return String.Concat(this.FirstName, this.MiddleName, this.LastName, this.SSN);
        }

        public override bool Equals(object obj)
        {
            string jsonString;
            jsonString = JsonConvert.SerializeObject(obj);

            Student deepcopyStudent = JsonConvert.DeserializeObject<Student>(jsonString);

            if (deepcopyStudent.SSN == this.SSN)
            {
                return true;
            }
                return false;
        }

        public override int GetHashCode()
        {
            return SSN.GetHashCode();
        }



        public static bool operator !=(Student student1, Student student2)
        {
            return !student1.Equals(student2);
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }



        public object Clone()
        {
            string jsonString;
            jsonString = JsonConvert.SerializeObject(this);

            Student deepcopyStudent = JsonConvert.DeserializeObject<Student>(jsonString);
            return deepcopyStudent;
        }

        public int CompareTo(object obj)
        {

            string jsonString;
            jsonString = JsonConvert.SerializeObject(obj);

            Student deepcopyStudent = JsonConvert.DeserializeObject<Student>(jsonString);
            if (string.Compare(this.LastName, deepcopyStudent.LastName) < 0 || string.Compare(this.LastName, deepcopyStudent.LastName) > 0)
            {
                return string.Compare(this.LastName, deepcopyStudent.LastName);
            }
            else
            {
                return string.Compare(this.SSN, deepcopyStudent.SSN);
            }

        }



    }
}
