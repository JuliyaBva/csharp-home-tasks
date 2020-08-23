using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork10
{
    public class Card
    {
        public string ProjectName { get; set; }
        public string Admin { get; set; }
        public string Id { get; set; }
        public string Summary { get; set; }
        public string Status { get; set; }
        public string Assignee { get; set; }
        public DateTime DueDate { get; set; }

        public List<Card> cards = new List<Card>();
        public string status1;
        public string status2;

        //Inheritance example1
        public void DisplayDefaultCardFields()
        {
            ProjectName = "Project1";
            Admin = "Anton Sobolev";
            Console.WriteLine("\nCards defauld values. Project name: {0}, admin: {1}", ProjectName, Admin);
        }

        //Method overloading example, it is used in ProjectBoardApp > case "f1", case "f2", case "f3"
        public void Filter(string cStatus)
        {
            foreach (Card cd in cards)
            {
                if (cd.Status == cStatus)
                {
                    Console.WriteLine("Card Id: {0}, summary: {1}, status: {2}, assignee: {3}, due date: {4}", cd.Id, cd.Summary, cd.Status, cd.Assignee, cd.DueDate);
                }
            }
        }
        public void Filter(string cStatus, string cStatus2)
        {
            foreach (Card cd in cards)
            {
                if (cd.Status == cStatus || cd.Status == cStatus2)
                {
                    Console.WriteLine("Card Id: {0}, summary: {1}, status: {2}, assignee: {3}, due date: {4}", cd.Id, cd.Summary, cd.Status, cd.Assignee, cd.DueDate);
                }
            }
        }
        public void Filter(string cStatus, string cStatus2, string cStatus3)
        {
            int count = cards.Count();
            count = cards.Count(s => s.Status == cStatus || s.Status == cStatus2 || s.Status == cStatus3);
            Console.WriteLine("Count of cards with status {0}, {1} and {2} is {3}", cStatus, cStatus2, cStatus3, count);
        }
    }
}