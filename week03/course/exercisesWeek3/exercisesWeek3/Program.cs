using System;
using System.Text;
using System.Collections.Generic;

namespace exercisesWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
                                       0  1   2   3  4   
            var array = MinMax(new[] { 1, 2, -4, -2, 3 });
            
            5 - 4 -1 = 0
                5- 3-1 = 1
                5-2-1=2


        }
      

        static int[] MinMax(int[] arr)
        {
            int min1=arr[0],min1pos=-1, min2 = arr[0], max1 = arr[0],max1pos=-1, max2 = arr[0], sumMin,sumMax;
            int[] arrayMinMax = new int[2];
            for( int i= 1; i<=arr.Length-1; i++)
            {
                if (arr[i] < min1)
                {
                    min1 = arr[i];
                    min1pos = i;
                }
            }

            for (int i = 1; i <= arr.Length - 1; i++)
            {
                if (arr[i] < min2 && min1pos!= i)
                {
                    min2 = arr[i];
                  
                }
            }

            for (int i = 1; i <= arr.Length - 1; i++)
            {
                if (arr[i] > max1)
                {
                    max1 = arr[i];
                    max1pos = i;
                }
            }

            for (int i = 1; i <= arr.Length - 1; i++)
            {
                if (arr[i] > min2 && max1pos != i)
                {
                    max2 = arr[i];

                }
            }
            sumMin = min1 + min2;
            sumMax = max1 + max2;

            arrayMinMax[0] = sumMin;
            arrayMinMax[1] = sumMax;

            return arrayMinMax;


        }
    }
}

