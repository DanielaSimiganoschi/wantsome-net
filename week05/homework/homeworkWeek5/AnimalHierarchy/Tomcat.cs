using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, "Male", age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meow Meowww");
        }

      
    }
}
