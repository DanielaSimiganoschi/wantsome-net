using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    class Cat : Animal
    {
      
        public Cat(string name, string sex, int age) : base(name, sex, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
      
    }
}
