using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array -

            int[] arr1 = new int[] { 67, 34, 89, 122, 45 };
            int max = arr1[0];

            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
            }

            Console.WriteLine($"max element is {max}");


            //-----------------------------------------------------------------------------------

            // sorting numbers

            int[] arr2 = new int[] { 67, 34, 89, 122, 45 };

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    int temp;
                    if (arr2[i] > arr2[j])
                    {
                        temp = arr2[i];
                        arr2[i] = arr2[j];
                        arr2[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted elements");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine($"{arr2[i]}");
            }

            // 2D Arry

            // Matrix → 3 * 3 and addtion of matrixs 

            int[,] m1 = new int[3, 3];
            int[,] m2 = new int[3, 3];


            // Accept form user 
            Console.WriteLine("Enter the 12 values");

            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(0); j++)
                {
                    m1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Accept form user 
            Console.WriteLine("Enter the 12 values");

            for (int i = 0; i < m2.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(0); j++)
                {
                    m2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("-------------------------------------------");

            // Addition of two materix
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(0); j++)
                {
                    Console.Write($"m1[{i},{j}] + m2[{i},{j}] = {m1[i, j] + m2[i, j]}");
                }
                Console.WriteLine();
            }

            /*  Jagged Array:

              When column size is not fixed, we can use jagged array
              In jagged array row size is fixed, but for each row, how many column we want that can be vary.

             */

            // Jagged array

            int[][] jaggedArray = new int[4][];

            jaggedArray[0] = new int[3] { 1, 2, 3 };
            jaggedArray[1] = new int[5] { 10, 20, 30, 40, 50 };
            jaggedArray[2] = new int[2] { 100, 200 };
            jaggedArray[3] = new int[4] { 11, 22, 33, 44 };

            for (int i = 0; i < jaggedArray.Length; i++) // 4
            {
                Console.WriteLine($"elements at row {i + 1}");
                for (int j = 0; j < jaggedArray[i].Length; j++) // column Length
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();





            }
        }
    }
}
