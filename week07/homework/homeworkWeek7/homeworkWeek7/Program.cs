using System;
using System.Collections.Generic;
using System.IO;

namespace homeworkWeek7
{
    class Program
    {
        static void Main(string[] args)
        {

            /// ex 1
            //try
            //{
            //    Console.WriteLine("please enter full path of file:");
            //    var filePath = Console.ReadLine();
            //    string text = System.IO.File.ReadAllText(@filePath);
            //    System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
            //}
            //catch (UnauthorizedAccessException)
            //{
            //    Console.WriteLine("Unauthorized Access to file.");
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("The file has not been found.");
            //}
            //catch (DirectoryNotFoundException)
            //{
            //    Console.WriteLine("The directory has not been found.");
            //}
            //catch (PathTooLongException)
            //{
            //    Console.WriteLine("The path you entered is too long.");
            //}
            //catch (NotSupportedException)
            //{
            //    Console.WriteLine("The Path is not in a valid format.");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);  
            //}

            ///ex2
            ///

           int a = 1;
            List<int> listNumbers = new List<int>();
            for(int i = 0; i< 10; i++)
            {
                var x = ReadNumber(a, 100);
                a = x;
                listNumbers.Add(x);
                
            }


        }

        public static int ReadNumber(int min, int max)
        {

            try
            {
                Console.WriteLine($"insert a number between {min} and {max}");
                var number = Int32.Parse(Console.ReadLine());
                if (number < min || number > max)
                {
                    throw new FormatException("The number you entered is out of range.");
                 
                }
                return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("The input was not in a correct format. ");
             
            }

            return 0;
                
          

        }
    }
}
