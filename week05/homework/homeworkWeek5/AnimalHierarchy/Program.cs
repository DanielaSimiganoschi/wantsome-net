using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal frog1 = new Frog("Jeremiah", "Male", 8);
            Animal frog2 = new Frog("Kermit", "Female", 9);
            Animal frog3 = new Frog("Lollihops", "Male", 8);
            Animal frog4 = new Frog("Ribbit", "Male", 11);

            Animal cat1 = new Cat("Leo", "Male", 10);
            Animal cat2 = new Cat("Milo", "Female", 3);
            Animal cat3 = new Cat("Ollie", "Male", 7);

            Animal kitten1 = new Kitten("Oreo", 8);
            Animal kitten2 = new Kitten("Winston", 5);

            Animal dog1 = new Dog("Bailey", "Male", 8);
            Animal dog2 = new Dog("Kobe", "Female", 16);

            List<Animal> listAnimals = new List<Animal>();

            listAnimals.AddRange(new List<Animal>() { frog1, frog2, frog3, frog4, cat1, cat2, cat3, kitten1, kitten2, dog1, dog2 });


            Console.WriteLine(Animal.CalculateAverage(listAnimals, typeof(Dog).ToString()));
        }
    }
}
