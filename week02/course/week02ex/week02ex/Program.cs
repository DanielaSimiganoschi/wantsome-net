using System;
using System.Collections.Generic;

namespace week02ex
{
    class Program
    {
        static void Main(string[] args)
        {

            /*   reverse array
               var array = new int[5] { 1, 32, 3, 4, 5 };
               var newArray = new int[5];
               for (int i = array.Length - 1; i >= 0; i--)
               {
                   int newPos = array.Length - 1 - i;
                   newArray[newPos] = array[i];

               }
               foreach (int value in newArray)
               {
                   Console.WriteLine(value);
               }*/

            /*  int startNumber = 1;
              int endNumber = 10;
              int counter = 0;
              var array1 = new int[endNumber / 2 + startNumber];
              for (int i = startNumber; i <= endNumber; i++)
              {
                  Console.WriteLine($"i: {i}");
                  if (i % 2 == 0)
                  {
                      array1[counter] = i;
                      Console.WriteLine($"Counter: {counter}, i: {i}, Array1: {array1[counter]}");
                      counter += 1;
                  }
              }
              foreach (int value in array1)
              {
                  Console.WriteLine(value);
              }'*/


            /*  var array = new int[6] { 2, 4, 5, 10, 25, 12 };
              int sum = 0, avr = 0;
             foreach (int val in array)
              {
                  sum = val;
              }

              avr = sum / array.Length;

              Console.WriteLine(avr); */

            /*   var array = new int[] { 1, 23, 10, 23, 2, 2, 2 };
              foreach(int v in array)
              {
                  if(v == 1 || v == 10)
                  {
                      continue;
                  } else
                  {
                      Console.WriteLine(v);
                  }
              } */

            // min an max



            /*        int[] array = new int[] { 20, 11, 45, 2, 55, 62, 1 };
                    int max = -1, min = int.MaxValue;

                    foreach(int val in array)
                    {
                        if(val < min)
                        {
                            min = val;
                        }
                        if(val > max)
                        {
                            max = val;
                        }
                    }

                    Console.WriteLine("max is: "+ max);
                    Console.WriteLine("min is: " + min);
                } */

            // delete element from array


            /*  int[] array = new int[] { 20, 11, 45, 2, 55, 62, 1 };

              int pos = 2;

              for (int i=pos+1; i<=array.Length-1; i++)
              {
                  array[i - 1] = array[i];

              }
              array[array.Length - 1] = 0;

              foreach(int val in array)
              {
                  Console.WriteLine(val);
              } */

            // part two


            //   Console.WriteLine("Default capacity of a List: " + new List<int>().Capacity);

            //List<int> list1 = new List<int>();

            //for( int i=0; i <= 10; i++)
            //{
            //    if(i==4 || i == 7)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        list1.Add(i);
            //    }
            //}

            //foreach(int j in list1)
            //{
            //    Console.WriteLine(j);
            //}

            // Fibonacci

            //int startNumber = 0;
            //int nextNumber = 1;
            //int c = 0;

            //int maxVal = 50;


            //List<int> listaFib = new List<int>();

            //listaFib.Add(startNumber);
            //listaFib.Add(nextNumber);

            //while ((startNumber+nextNumber) <= maxVal)
            //{
            //    c = startNumber + nextNumber;
            //    listaFib.Add(c);
            //    startNumber = nextNumber;
            //    nextNumber = c;

            //}

            //foreach(int val in listaFib)
            //{
            //    Console.WriteLine(val);
            //}


            // remove first occurence

            //  List<int> listaOcc = new List<int>() { 23,11,3,53,34,11,2,3,4};
            //List<int> listaNoOcc = new List<int>();

            //int ok = 1;


            //foreach (int val in listaOcc)
            //{
            //    if(ok == 1 && val == 3)
            //    {
            //        ok = 0;
            //        continue;
            //    }
            //    else
            //    {
            //        listaNoOcc.Add(val);
            //    }
            //}

            //foreach (int val in listaNoOcc)
            //{
            //    Console.WriteLine(val);
            //}

            // max and min

            //List<int> listaMinMax = new List<int>() { 23, 11, 3, 53, 34, 11, 2, 3, 4 };
            //listaMinMax.Sort();

            //    Console.WriteLine("min is: "+ listaMinMax[0]);
            //Console.WriteLine("max is: " + listaMinMax[listaMinMax.Count-1]);

            List<int> listGuess1 = new List<int>();
            List<int> listGuess2 = new List<int>();
            int x = new Random().Next(1, 10);

            int inserted = int.Parse(Console.ReadLine());
            while (inserted != x)
            {
                if (inserted < 5)
                {
                    listGuess1.Add(inserted);
                }
                else
                {
                    listGuess2.Add(inserted);
                }
                inserted = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"You made {listGuess.Count}");
        }
    }
}
