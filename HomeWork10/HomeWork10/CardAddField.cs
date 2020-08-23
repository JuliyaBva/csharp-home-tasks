using System;
namespace HomeWork10
{
    class CardAddField : Card
    {
        public string Type { get; set; }
        public string Priority { get; set; }

        public CardAddField(string type, string priority)
            : base()
        {
            Type = type;
            Priority = priority;
        }
        public void DisplayAddCardFields()
        {
            Console.WriteLine("Values of the additional fields. Type: {0}, priority: {1}", Type, Priority);
        }
    }
}