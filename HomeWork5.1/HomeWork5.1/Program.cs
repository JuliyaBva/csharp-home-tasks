using System;

namespace HomeWork5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 9;
            int[] array = new int[n] { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int max = int.MinValue;
            foreach (int number in array)
            {
             if (number < 0 && number > max) max = number;
            }
            Console.WriteLine("Number of the last negative value of the given array is {0}", max);
            var index = Array.IndexOf(array, max);
            Console.WriteLine("Index of the last negative value of the given array is {0}", index);
        }
    }
}

