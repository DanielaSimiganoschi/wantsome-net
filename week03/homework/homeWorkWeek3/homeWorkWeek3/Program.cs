using System;
using System.Collections.Generic;


namespace homeWorkWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var listPairs = EX2(new[] { 1, 21, 6, 3, 23, 5, 2 }, 8);
            //    foreach(var el in listPairs)
            //{
            //    Console.WriteLine(el);
            //}

            //int k = recursivFactorial(9);
            //   Console.WriteLine(k);

            // long sum = sumDigits(12345678);
            // Console.WriteLine(sum);

            //long fib = nthFibonacci(7);
            //Console.WriteLine(fib);

            //var s =   removeDuplicates("dujhasduasj");
            //  Console.WriteLine(s);

            //var c = checkArmstrong(3711);
            //Console.WriteLine(c);

            //var rotate = Rotate(new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },3);

            //foreach(int val in rotate)
            //{
            //    Console.WriteLine(val); 
            //}

            //int[] sorted = sortSelection(new int[] { 436, 43, 1, 4, 6, 2, 4, 23, 454, 53, 2 });
            //foreach(int val in sorted)
            //{
            //    Console.WriteLine(val) ;
            //}
          int k =  CountBits(9);
            Console.WriteLine(k);
        }

        //2.Find all pairs(2 elements) of elements in an integer array, whose sum is equal to a given number

        static List<int> EX2(int[] array, int sum)
        {
            List<int> sumPairs = new List<int>();  

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == sum)
                    {
                       sumPairs.Add(array[i]);
                        sumPairs.Add(array[j]);

                    }
                }
               
            }
            return sumPairs;
        }


        // 3.How to calculate factorial using recursion in C# + iterative + time difference.

        // iterativ

        static int iterativFactorial (int number)
        {
            int factorial = number;

            for( int i = number-1; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        // recursiv

        static int recursivFactorial (int number)
        {
            if (number == 1)
                return 1;
            else
                return number * recursivFactorial(number - 1);
        }

        // 5.How to find sum of digits of a number using Recursion?

        static long sumDigits (long number)
        {
            if (number >=0 && number <= 9)
            {
                return number;
            } else
            {
                return (number % 10) + sumDigits(number / 10); 
            }
        }

        //6.Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number?

        static int Ex6(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                if (count > array.Length / 2)
                    return i;
            }
            return -1;
        }

        // 8.Write a function to print the nth number in Fibonacci series?

        static long nthFibonacci(int n)
        {

            if (n <= 1)
            {
                return n;
            }
            else
            {
                return nthFibonacci(n - 1) + nthFibonacci(n - 2);
            }
        }

        // 9.Write a function to count a total number of set bits in a 32-bit Integer?

            static int CountBits(int number)
        {
            string binary = Convert.ToString(number, 2);
            int binaryNumber = Convert.ToInt32(binary);
            int Count = 0;
            while(binaryNumber > 0)
            {
                if (binaryNumber % 2 == 1)
                {
                    Count++;
                  
                }
                binaryNumber /= 10;
            }
            return Count;
        }


        //10. Write a function to remove duplicate characters from String?

        static string removeDuplicates (string word)
        {

           
            List<char> finalList = new List<char>();
            for (int i = 0; i <= word.Length - 1; i++)
            {
                if (!finalList.Contains(word[i]))
                {
                    finalList.Add(word[i]);
                }

            }
            string listString = string.Join(",", finalList);
            return listString;
        }

        //11. How to find the 3rd element from the end, in a singly linked, in a single pass?

        //12. C# program to check if a number is Armstrong number or not?

        static bool checkArmstrong(int number)
        {  // 371 sum= 1 37 sum 
            double sum = 0;
            int numberCopy = number;
            while( number > 0)
            {
                sum += Math.Pow((number % 10), 3);
                number = number / 10;
            }
            if( sum == numberCopy)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //13.Algorithm to check if a number is Prime or not? -- e deja facut intr-o tema anterioara

        //14.Algorithm to check if a number is a Palindrome? -- e deja facut intr-o tema anterioara

        // 16.How to rotate an array by a given pivot?

        public static int[] Rotate(int[] x, int pivot)
        {
           pivot = pivot % x.Length;

            x = RotateSub(x, 0, pivot - 1);

            x = RotateSub(x, pivot, x.Length - 1);

            x = RotateSub(x, 0, x.Length - 1);

            return x;
        }

         static int[] RotateSub(int[] x, int start, int end)
        {
            while (start < end)
            {
                int temp = x[start];
                x[start] = x[end];
                x[end] = temp;
                start++;
                end--;
            }
            return x;
        }

        // 18.Sorting an Array using Selection Sort;

        static int[] sortSelection(int[] arr)
        {
            for(int i=0; i <= arr.Length - 2; i++)
            {
                int minimPos = i;
                for ( int j=i+1; j <= arr.Length - 1; j++)
                {
                    if (arr[j] < arr[minimPos])
                    {
                        minimPos = j;
                    }
                }
                int aux = arr[i];
                arr[i] = arr[minimPos];
                arr[minimPos] = aux;

            }
            return arr;
        }
    }
}

