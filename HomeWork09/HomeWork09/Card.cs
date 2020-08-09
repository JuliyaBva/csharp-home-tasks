using System;
using System.Collections.Generic;
namespace HomeWork09
{
    public class Card
    {
        public string Id { get; set; }
        public string Summary { get; set; }
        public string Status { get; set; }
        public string Assignee { get; set; }
        public DateTime DueDate { get; set; }

        public List<Card> cards = new List<Card>();

        public string status1;
        public string status2;
    }
}