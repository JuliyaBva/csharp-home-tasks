using System;
namespace HomeWork09
{
    public class Menu
    {
        public string boardNumber;
        public string command;
        public void Board()
        {
            Console.WriteLine("Please enter board number: b1 (Board No.1) or b2 (Board No.2)");
            string boardNumber1 = Console.ReadLine();
            boardNumber = boardNumber1;
        }
        public void Command()
        {
            Console.WriteLine("\nPlease enter command: d1 - display all cards with specified status, d2 - display all cards with specified assignee, r1 - report1, r2 - report2, u1 - update card summary, u2 - update card status, u3 - update card assignee, d - delete card, q - quit");
            string enteredCommand = Console.ReadLine();
            command = enteredCommand;
        }
    }
}