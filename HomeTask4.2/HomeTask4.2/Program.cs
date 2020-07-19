 using System;

namespace HomeTask4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display only prime numbers from a given range
            int primeNumber;
            bool isNumberPrime;
            for (primeNumber = 2; primeNumber < 200; primeNumber++)
            {
                isNumberPrime = true;
                for (int i = 2; i <= primeNumber / 2; i++)
                {
                    if ((primeNumber % i) == 0)
                    {
                        isNumberPrime = false;
                    }
                }
                if (isNumberPrime)
                    Console.WriteLine(primeNumber);
            }
            Console.ReadKey();
        }
    }
}
