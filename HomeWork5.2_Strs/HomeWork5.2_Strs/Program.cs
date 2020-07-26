using System;

namespace HomeWork5._2_Strs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter word which contains 'a' letter: ");
            string word = Console.ReadLine();
            char[] array = word.ToCharArray();
            Console.WriteLine("New word:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 'a')
                {
                    array[i] = 'A';
                }
                Console.Write(array[i]);
            }
        }
    }
}
