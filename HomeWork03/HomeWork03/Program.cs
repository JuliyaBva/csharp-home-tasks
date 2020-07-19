using System;
using System.Text;

namespace HomeWork03
{
    class Program
    {
        static void Main(string[] args)
        //detemine which values should be entered on screen
        //display text with infromation which values should be entered on screen
        //add an ability to enter required values on screen
        //determine formulas to calculate deposit increase per month and total deposit for deposit period
        //determine cycle to be able to calculate deposit for any deposit period
        //display results on screen
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
            double percentPerMonth = (double) percentPerYear / monthsPerYear;
            double depositIncreasePerMonthCalc = (initialRate + depositReplenishment) * percentPerMonth / 100;
            double totalDeposit = initialRate + depositReplenishment + depositIncreasePerMonthCalc * depositPeriod;

            Console.WriteLine("Deposit increase by months: ");
            int i = 0;
            while (++i <= depositPeriod)
            {
                double depositIncreasePerMonth = depositIncreasePerMonthCalc + (initialRate + depositReplenishment + depositIncreasePerMonthCalc * (i-1));
                Console.WriteLine("Month {0}: {1}$", i, Math.Round(depositIncreasePerMonth,2));
            }
            Console.WriteLine("Total deposit for {0} months of deposit period is {1}$", depositPeriod, Math.Round(totalDeposit,2));
            Console.ReadKey();
        }
    }
}
