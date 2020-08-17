using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, "Female", age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meow Meow");
        }


     
    }
}

