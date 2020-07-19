using System;
using System.Text;

namespace HomeWork04
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Example with for:
                //display text with infromation which number should be entered on screen
                //add an ability to enter required number on screen
                //add a cycle to check whether entered number > 0
                //display success message if entered number > 0 and break the cycle
                //display warning message if entered number <= 0
                Console.OutputEncoding = Encoding.UTF8;

                Console.WriteLine("Please enter integer number which more than 0: ");
                int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; ; i++)
                {
                    if (number > 0)
                    {
                        Console.WriteLine("Number {0} is correct", number);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Number {0} is not correct", number);
                        break;
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
