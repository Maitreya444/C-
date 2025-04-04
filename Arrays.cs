using System;

namespace MyApp
{
    public class Array()
    {
        public void PrintArrayTypes()
        {   
            //Single dimensional array
            int [] arr1 = new int[5];

            //Setting array values
            int [] arr2 = [1,2,3,4,5];
            
            //2 dim array
            int[,]  multiarr1 = new int [2,3];

            //setting array elements
            int [,] multiarr2 = {{1,2,3}, {4,5,6}};

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = [1, 2, 3, 4];

            // Alternative syntax:
            int[] array2 = {1, 2, 3, 4, 5, 6};

            int iCnt = 0;

            for(iCnt = 0; iCnt < 5; iCnt++)
            {
                Console.WriteLine(arr1);
            }
        }
    }
}