using System;

namespace Week01Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Display even numbers between 0, 100




            // 2.
            /*
             * Read 2 number from the keyboard and create mathematical operations for
                -division
                -multiplication
                -on division if the number is 0 display a message that it is not possible
                -calculate the minimum and maximum
             */

            //3
            /*
             * Read a number from the keyboard and
                -it is the temperature in C, convert it to F
                -it is the temperature in F, convert it to C
                -it is a number of days, convert it to years, months, weeks and days
                Conventions - year: 365 days, month: 30 days, week: 7 days, use only numbers
                bigger than 1000
            */




            //4. Print to console all even numbers between 15 and 97.


            //5. Print all numbers divisible by 3 between 20 and 65.
            //6. Count all numbers divisible by 7 and multiple of 5, from 1400 to 2300 and print the result to console.
            //7. Write a program to guess a number between 1 and 10. To generate a random number, use Random class from .NET Framework.


            //9. Read a text from console and print it reversed.
            //10. Print numbers from 1 to 10 except 4 and 7.
            Ex16();
            //11. Print the Fibonacci sequence from 0 to 50. (i.e. Exery next number is found by adding up those two before it: 0, 1, 1, 2, 3, 5, 8, 13, ..


        }

        public static void Ex01(int a, int b)
        {
            if (a % 2 == 0)
            {
                for (int i = a; i <= b; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = a + 1; i <= b; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Ex2()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (b != 0 && a != 0)
            {
                float c = (float)a / (float)b;
                Console.WriteLine(c);
            }
            int d = a * b;
            Console.WriteLine(d);
            if (a > b)
            {
                Console.WriteLine("The greatest number is: " + a);
            }
            else
            {
                Console.WriteLine("The greatest number is: " + b);
            }

        }

        public static void Ex3()
        {
            Console.WriteLine("Insert a number greater than 1000:");
            int a = Convert.ToInt32(Console.ReadLine());
            double tempC = ((double)a - 32) / 1.8000;
            double tempF = (double)a * 1.8000 + 32.00;


            int numberOfYears = a / 365;
            int numberOfMonths = (a - numberOfYears * 365) / 30;
            int numberOfWeeks = (a - numberOfYears * 365 - numberOfMonths * 30) / 7;
            int numberOfDays = a - numberOfYears * 365 - numberOfMonths * 30 - numberOfWeeks * 7;

            Console.WriteLine("C temperature: " + tempC);
            Console.WriteLine("'F temperature: " + tempF);
            Console.WriteLine("'Number of years: " + numberOfYears);
            Console.WriteLine("'Number of months: " + numberOfMonths);
            Console.WriteLine("'Number of weeks: " + numberOfWeeks);
            Console.WriteLine("'Number of days: " + numberOfDays);

        }

        public static void Ex04(int a, int b)
        {
            if (a % 2 == 0)
            {
                for (int i = a; i <= b; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = a + 1; i <= b; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Ex5(int a, int b)
        {

            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }

        public static void Ex6(int a, int b)
        {
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0 && i % 7 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static void Ex7()
        {
            int x = new Random().Next(1, 10);
            int y = Convert.ToInt32(Console.ReadLine());

            while (y != x)
            {
                Console.WriteLine("Wrong number, try again:");
                Console.WriteLine(x);
                y = Convert.ToInt32(Console.ReadLine());
            }

        }

        public static void Ex9()
        {
            string y = Console.ReadLine();
            string reverseY = "";

            for (int i = y.Length - 1; i >= 0; i--)
            {
                reverseY = reverseY + y[i];
            }
            Console.WriteLine(reverseY);
        }

        public static void Ex10(int x, int y)
        {
            for (int i = x; i <= y; i++)
            {
                if (i == 4 || i == 7)
                {

                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }

        public static void Ex11(int max)
        {
            Console.WriteLine(0);
            Console.WriteLine(1);
            Console.WriteLine(1);

            int a = 1, b = 1, c = 0;


            while ((a + b) < max)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            };


        }

        public static void Ex12()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);


        }


        public static void Ex13(int x, int firstN)
        {

            int res = 0;
            for (int i = 0; i <= firstN; i++)
            {
                res = x * i;
                Console.WriteLine(x + " * " + i + " = " + res);
            }

        }

        public static void Ex14(int x, int y, int z, int w)
        {
            int result = (x + y + z + w) / 4;
            Console.WriteLine("The average is: " + result + ".");
        }

        public static void Ex15(string w)
        {
            string newW = w[0] + w + w[0];
            Console.WriteLine(newW);
        }

        public static void Ex16()
        {
            int[] i = { 10, 22, 2, 3, 5, 12, 32 };
            int count = 1;

            while (count != 0)
            {
                count = 0;
                for (int j = 1; j < i.Length; j++)
                {
                    
                    if (i[j] < i[j - 1])
                    {
                        int aux = i[j];
                        i[j] = i[j - 1];
                        i[j - 1] = aux;
                        count++;
                    }
                }
            }
            for (int k = 0; k < i.Length; k++)
            {
                Console.Write("{0}  ", i[k]);
            }
          
        }
    }
}
