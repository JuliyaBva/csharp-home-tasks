using System;

namespace HomeWork5._2_Strs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter word which contain 'a' letters: ");
            string word = Console.ReadLine();
            string str = word;
            FindAllChar('a', str);
        }
        static void FindAllChar(Char target, String enteredWord)
        {
            int startIndex = -1;
            int hitCount = 0;
            // Search for all occurrences of the target.
            while (true)
            {
                startIndex = enteredWord.IndexOf(
                    target, startIndex + 1,
                    enteredWord.Length - startIndex - 1);
                // Exit the loop if the target is not found.
                if (startIndex < 0)
                    break;
                hitCount++;
            }
            Console.WriteLine("occurrences of 'a' in {0}: {1}", enteredWord, hitCount);


        }
    }
}
