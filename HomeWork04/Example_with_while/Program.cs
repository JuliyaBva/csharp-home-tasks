using System;
using System.Text;

namespace HomeWork04_Example_with_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Please enter integer number which more than 0: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                if (number1 > 0)
                {
                    Console.WriteLine("Number {0} is correct", number1);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
