using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {


        public int Age { get; set; }
        protected string Name { get; set; }
        protected string Sex { get; set; }
        public List<Animal> listAnimal;
        public abstract void MakeSound();

        public Animal(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        public void AddAnimal(Animal animal)
        {
            listAnimal.Add(animal);
        }

        public static double CalculateAverage(List<Animal> animals, string TypeAnimal)
        {

            List<Frog> ofTypeFrog;
            List<Dog> ofTypeDog;
            List<Cat> ofTypeCat;
            List<Kitten> ofTypeKitten;
            List<Tomcat> ofTypeTomcat;


            if (TypeAnimal == "AnimalHierarchy.Frog")
            {
                ofTypeFrog = animals.OfType<Frog>().ToList();
                var sum = 0;
                var count = 0;
                foreach (var i in ofTypeFrog)
                {
                    sum += i.Age;
                    count++;
                }
                return sum / count;

            }
            else if (TypeAnimal == "AnimalHierarchy.Dog")
            {
                ofTypeDog = animals.OfType<Dog>().ToList();
                var sum = 0;
                var count = 0;
                foreach (var i in ofTypeDog)
                {
                    sum += i.Age;
                    count++;
                }
                return sum / count;
            }
            else if (TypeAnimal == "AnimalHierarchy.Cat")
            {
                ofTypeCat = animals.OfType<Cat>().ToList();
                var sum = 0;
                var count = 0;
                foreach (var i in ofTypeCat)
                {
                    sum += i.Age;
                    count++;
                }
                return sum / count;
            }
            else if (TypeAnimal == "AnimalHierarchy.Kitten")
            {
                ofTypeKitten = animals.OfType<Kitten>().ToList();
                var sum = 0;
                var count = 0;
                foreach (var i in ofTypeKitten)
                {
                    sum += i.Age;
                    count++;
                }
                return sum / count;
            }
            else
            {
                ofTypeTomcat = animals.OfType<Tomcat>().ToList();
                var sum = 0;
                var count = 0;
                foreach (var i in ofTypeTomcat)
                {
                    sum += i.Age;
                    count++;
                }
                return sum / count;
            }


        }

    }
}
