using System;
using System.Collections.Generic;

namespace homeworkWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // searchIndex();
            // insertElement();
            // Fuzz();

            // Frequency();

            // sortEvenOdd();

            // commonEl();

            // UniqueCh();
            // removeDupl();
            // primeNr();\
            // palindromeCheck();

        }

        static void searchIndex()
        {
            int[] arr1 = new int[6] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Type the element you want the index for: ");
            int val = int.Parse(Console.ReadLine());
            int index = -1;

            for(int i = 0; i<=arr1.Length-1; i++)
            {
                if(arr1[i] == val)
                {
                    index = i;
                    break;
                } else
                {
                    continue;
                }
            }

            if(index!= -1)
            {
                Console.WriteLine("The element was found at index " + index);
            }
            else
            {
                Console.WriteLine("The element was not found");
            }
        }

        static void insertElement()
        {

            List<int> insertLi = new List<int> { 2, 5, 342, 312, 32, 2, 4, 4, 42 };
            Console.WriteLine("Type the position you want to insert the element on: ");
            int val = int.Parse(Console.ReadLine());
            while (val <0 || val > insertLi.Count)
            {
                Console.WriteLine("The number has to be greater than 0 and smaller than the length-1");
                 val = int.Parse(Console.ReadLine());

            }

            insertLi.Insert(val, 1000);
            foreach(int value in insertLi)
            {
                Console.WriteLine(value);
            }
        }

        static void Fuzz()
        {
            List<int> fuzzLi = new List<int>();
            for(int i=0; i <= 999; i++)
            {
                fuzzLi.Add(i + 1);
            }

            foreach(int val in fuzzLi)
            {
                if(val % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                } else if ( val % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } else if (val % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                } else
                {
                    Console.WriteLine(val);
                }
            }
        }

        static void Frequency()
        {
            int[] arr1 = new int[] { 1, 4, 5, 2, 1, 4, 3, 1, 2 };
            List<int> listF = new List<int>();
            foreach (int val in arr1)
            {
                if (!listF.Contains(val))
                {
                    listF.Add(val);
                }
            }

            
            int i = listF.Count-1;

            while (i >= 0)
            {
                int freq = 0;
                for (int j = 0; j<=arr1.Length-1; j++)
                {
                    if (arr1[j] == listF[i])
                    {
                        freq++;
                    }
                }
                Console.WriteLine($"the frequency for {listF[i]} is {freq}");
                i--;
            }
        }

        static void sortEvenOdd()
        {
            Console.WriteLine("Please insert the number of elements:");
            int numberOfVal = int.Parse(Console.ReadLine());
            int countOdd = 0, countEven = 0;

            int[] arr1 = new int[numberOfVal];
            int[] arrOdd = new int[numberOfVal];
            int[] arrEven = new int[numberOfVal];

            for (int i = 0; i <= numberOfVal - 1; i++)
            {
                Console.WriteLine("Please insert the elements:");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            foreach(int val in arr1)
            {
                if (val % 2 == 0)
                {
                    arrEven[countEven] = val;
                    countEven++;
                }
                else
                {
                    arrOdd[countOdd] = val;
                    countOdd++;
                }
            }

            

            for(int j=0; j<=countEven-1; j++)
            {

                Console.WriteLine($"Even element {arrEven[j]} on position {j}");
            }
            for (int j = 0; j <= countOdd - 1; j++)
            {
                Console.WriteLine($"Even element {arrOdd[j]} on position {j}");
            }
        }

       static void commonEl()
        {
            Console.WriteLine("Number of elements 1st array");
            int numberOfVal1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[numberOfVal1];
            Console.WriteLine("Number of elements 2nd array");
            int numberOfVal2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[numberOfVal2];

            List<int> listCommonEl = new List<int>();

            Console.WriteLine("The elements of the first array:");
            for (int i = 0; i <= numberOfVal1 - 1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The elements of the second array:");

            for (int i = 0; i <= numberOfVal2 - 1; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            foreach (int i in arr1)
            {
                foreach(int j in arr2)
                {
                    if ( i == j)
                    {
                        listCommonEl.Add(i);
                    }
                }
            }

            foreach(int k in listCommonEl)
            {
                Console.WriteLine("Common elements:");
                Console.WriteLine(k);
            }
        }

        static void UniqueCh()
        {
            Console.WriteLine("Please insert a string:");
            string word = Console.ReadLine();
            List<char> listCommonEl = new List<char>();
           for( int i =0; i <= word.Length - 1; i++)
            {
                if (!listCommonEl.Contains(word[i]))
                {
                    listCommonEl.Add(word[i]);
                }
                
            }

            if(listCommonEl.Count < word.Length)
            {
                Console.WriteLine("The string has letters which repeat.");

            }
            else
            {
                Console.WriteLine("The string has unique letters.");
            }

        }

        static void removeDupl()
        {
            
            List<int> ListWithDupl = new List<int>() { 2, 5, 6, 43, 3, 4, 2, 6, 32, 41, 43, 41, 4, 6, 6, 6 };
            List<int> ListWithoutDupl = new List<int>() ;

            for (int i = 0; i <= ListWithDupl.Count - 1; i++)
            {
                if (!ListWithoutDupl.Contains(ListWithDupl[i]))
                {
                    ListWithoutDupl.Add(ListWithDupl[i]);
                }

            }

            for(int i=0; i <= ListWithoutDupl.Count - 1; i++)
            {
                for(int j=0; j <= ListWithDupl.Count - 1; j++)
                {
                    if (ListWithoutDupl[i] == ListWithDupl[j])
                    {
                        for( int k = j+1; k<=ListWithDupl.Count-1; k++)
                        {
                            if(ListWithDupl[k]== ListWithoutDupl[i])
                            {
                                ListWithDupl.RemoveAt(k);
                            }
                        }
                    }
                }
            }

            Console.WriteLine("List without duplicates:");
            foreach (int k in ListWithDupl)
            {
                 Console.WriteLine(k);
            }

        }

        static void primeNr()
        {
            Console.WriteLine("Please insert number:");
            int m = int.Parse(Console.ReadLine());
            int countDiv = 0;

            for (int j = 2; j <= m / 2; j++)
            {

                if (m % j == 0)
                {
                    countDiv++;
                }


            }
            if (countDiv == 0)
            {
                Console.WriteLine("The number is prime.");
            }
            else
            {
                Console.WriteLine("The number is not prime.");
            }
        }

        static void palindromeCheck()
        {
            Console.WriteLine("Please insert a string.");
            string word = Console.ReadLine();
            int ok = 1;

            for ( int i = word.Length-1; i >= (word.Length - 1)/2; i--)
            {
                if(word[i] == word[word.Length - i - 1])
                {
                    continue;
                }
                else
                {
                    ok = 0;
                    break;
                }

             

            }
            if (ok == 1)
            {
                Console.WriteLine("The provided string is palindrome.");

            }
            else
            {
                Console.WriteLine("The provided string is not palindrome.");
            }
        }

    }
}
