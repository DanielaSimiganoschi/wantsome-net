using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkWeek6
{
    class Person
    {
        Nullable<int> age = null;
        string name;

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            if(this.age == null)
            {
                return String.Concat(this.name, "age not specified");
            }
            else
            {
                return String.Concat(this.name, this.age);
            }
        }
    }
}
