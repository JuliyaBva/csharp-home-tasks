using System;

namespace HomeWork5._1_Strs
{
    class Program
    {
        static void Main(string[] args)
        {
            //option1
            string str = "Interstellar";
            const string lettersToFind = "AaEeIiOoYyUu";
            int count = 0;
            for (int i = 0; i < str.Length; ++i)
                for (int j = 0; j < lettersToFind.Length; ++j)
                    if (str[i] == lettersToFind[j])
                        ++count;
            Console.WriteLine("Count of the /AaEeIiOoYyUu/ letters is {0}", count);

            //option2
            Console.WriteLine("Please enter some word: ");
            string word = Console.ReadLine();
            int count2 = 0;
            for (int i = 0; i < word.Length; ++i)
                for (int j = 0; j < lettersToFind.Length; ++j)
                    if (word[i] == lettersToFind[j])
                        ++count2;
            Console.WriteLine("Count of the /AaEeIiOoYyUu/ letters is {0}", count2);
            Console.ReadLine();
        }
    }
}
