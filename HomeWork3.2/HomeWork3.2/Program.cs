using System;
using System.Text;

namespace HomeWork3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            const int monthsPerYear = 12;

            Console.WriteLine("Please enter initial rate: ");
            var initialDeposit = Console.ReadLine();
            double initialRate = Convert.ToDouble(initialDeposit);

            Console.WriteLine("Please enter monthly replenishment: ");
            var monthlyRate = Console.ReadLine();
            double depositReplenishment = Convert.ToDouble(monthlyRate);

            Console.WriteLine("Please enter refinancing rate: ");
            var rateRf = Console.ReadLine();
            double refinancingRate = Convert.ToDouble(rateRf);

            Console.WriteLine("Please enter interest rate: ");
            var rateInt = Console.ReadLine();
            double interestRate = Convert.ToDouble(rateInt);

            Console.WriteLine("Please enter deposit period (count of months): ");
            var countOfMonths = Console.ReadLine();
            int depositPeriod = Convert.ToInt32(countOfMonths);

            double percentPerYear = refinancingRate + interestRate;
            double percentPerFirstMonth = (double)interestRate / monthsPerYear;
            double percentPerMonth = (double)percentPerYear / monthsPerYear;
            double depositIncreasePerFirstMonth = (initialRate + depositReplenishment) * percentPerFirstMonth / 100;
            double depositIncreasePerMonthCalc = (initialRate + depositReplenishment) * percentPerMonth / 100;
            double depositPerFirstMonth = initialRate + depositReplenishment + depositIncreasePerFirstMonth;
            double totalDeposit = initialRate + depositReplenishment + depositIncreasePerFirstMonth + depositIncreasePerMonthCalc * (depositPeriod - 1);

            Console.WriteLine("Deposit increase by months: ");
            Console.WriteLine("Month 1: {0}$", Math.Round(depositPerFirstMonth, 2));
            int i = 0;
            while (++i < depositPeriod)
            {
                double depositIncreasePerMonth = depositIncreasePerMonthCalc + (initialRate + depositReplenishment + depositIncreasePerMonthCalc * (i - 1));
                Console.WriteLine("Month {0}: {1}$", i+1, Math.Round(depositIncreasePerMonth, 2));
            }
            Console.WriteLine("Total deposit for {0} months of deposit period is {1}$", depositPeriod, Math.Round(totalDeposit, 2));
            Console.ReadKey();
        }
    }
}
