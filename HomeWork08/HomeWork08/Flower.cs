using System;
namespace HomeWork08
{
    public class Flower
    {
        public string name;
        public string kind;
        public int size; //average size in centimeters
        public string name1;
        public string name2;
        public string Domain { get; set; } = "Rosaceae";
        public int Count { get; set; } = 3000;
        public Flower(string n, string k, int s) { name = n; kind = k; size = s; }
        public string[] flowers = new string[] { "Orchid", "Chamomile", "Rosa" };

        public void GetInfo()
        {
            Console.WriteLine("\nExample1. Flower: name: {0}, kind: {1}, size: {2}", name, kind, size);
        }

        public void Concat()
        {
            string flowerInfo = "\nExample2. Flower information: " + name + ", " + kind + ", " + size;
            Console.WriteLine(flowerInfo);
        }

        public void Replace()
        {
            for (int i = 0; i < flowers.Length; i++)
            {
                if (flowers[i] == name1)
                {
                    flowers[i] = name2;
                }
                Console.WriteLine(flowers[i]);
            }
        }
        public void Replace2()
        {
            Console.Write("\nReplace method with char example.");
            Console.Write("\nPlease enter word which contains 'k' letter: ");
            string word = Console.ReadLine();
            char[] array = word.ToCharArray();
            Console.WriteLine("New word:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 'k')
                {
                    array[i] = 'K';
                }
                Console.Write("{0}\n", array[i]);
            }
        }

        private int month;
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if ((value <= 9) && (value >=4))
                {
                    month = value;
                }
                else
                {
                    throw new ArgumentException("Flowers don't grow in winter");
                }
            }
        }
    }
}