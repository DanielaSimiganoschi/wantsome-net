﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    class Dog : Animal
    {
        public Dog(string name, string sex, int age) : base(name, sex, age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Ham Ham");
        }


    }
}
