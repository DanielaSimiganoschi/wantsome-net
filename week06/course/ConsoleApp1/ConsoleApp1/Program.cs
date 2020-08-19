using System;

namespace ConsoleApp1
{
    public abstract class Shape
    {
        protected string Name { get; set; }
        private Shape(string name)
        {
            Name = name;
        }
    }
    public class Circle : Shape
    {
        protected void Print()
        {
        }
        public Circle(string name) : base(name)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle("circle 1");
            circle.Print();
        }
    }

}
