using System;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] array = new int[3, 5] { { 1, 2, 5, 4, 3 }, { 10, 7, 8, 9, 6 }, { 11, 15, 13, 14, 12 } };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            //initialize array
            Console.WriteLine("Initial array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                { 
                    Console.Write("{0}\t", array[i, j]); 
                }
                Console.WriteLine();
            }
            //find max number and related index in each row
            Console.WriteLine("\nmax numbers and related index in rows: ");
            for (int i = 0; i < rows; i++)
            {
                int max = array[i, 0];
                int maxIndex = 0;
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxIndex = j;
                    }
                }
                Console.WriteLine("Row {0}, number: {1}, index: {2}", i, max, maxIndex);
                Console.WriteLine();
                //replace numbers which located after max number on 0
                for (int j = maxIndex + 1; j < columns; j++)
                {
                    array[i, j] = 0;
                }
            }
            //display modified array
            Console.WriteLine("Modified array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}