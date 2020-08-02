using System;
using System.Text;

namespace HomeWork08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Flower flower = new Flower("Rosa", "Rose", 50);

            //Auto - property usage example
            Console.WriteLine("Domain: {0}", flower.Domain);
            Console.WriteLine("Count: {0}", flower.Count);

            //Property usage example
            Console.WriteLine("\nNumber of month when such flowers bloom is {0}", flower.Month = 7);

            //Flower class methods usage
            flower.GetInfo();
            flower.Concat();

            Console.WriteLine("\nPlease enter flower name from the following list: Orchid, Chamomile, Rosa which you would like to replace");
            string enteredName1 = Console.ReadLine();
            Console.WriteLine("Please enter new flower name");
            string enteredName2 = Console.ReadLine();
            flower.name1 = enteredName1;
            flower.name2 = enteredName2;
            flower.Replace();
            flower.Replace2();

            //Override operator "+" example
            Counter c1 = new Counter { Value = 50 };
            Counter c2 = new Counter { Value = 45 };
            Counter c3 = c1 + c2;
            Console.WriteLine("\nOperator /+/ override example.");
            Console.WriteLine("Value is {0}", c3.Value);

            //Indexer usage example
            Planet planet = new Planet();
            planet["type"] = "Belerafon";
            planet["description"] = "This is planet outside our galaxy.";
            
            Console.WriteLine("\nIndexer usage example.");
            Console.WriteLine(planet["type"]);
            Console.WriteLine(planet["description"]);
            Console.ReadKey();
        }
    }
}
