using System;
using System.Linq;
using System.Text;

namespace HomeWork10
{
    class ProjectBoardApp
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Board board = new Board();
            board.Name = "Project1 board";
            board.Status = "Active";
            Console.WriteLine("Board name: {0}, board status: {1}", board.Name, board.Status);

            //Inheritance example1
            CardAddField cardAddField = new CardAddField("Task", "Major");
            cardAddField.DisplayDefaultCardFields();
            cardAddField.DisplayAddCardFields();

            //Inheritance example2
            Employee emp1 = new Employee("Denis", "Ivanov", "developer");
            string person1 = string.Join(" ", emp1.firstName, emp1.lastName, "-", emp1.position);
            
            Employee emp2 = new Employee("Petr", "Petrov", "architect");
            string person2 = string.Join(" ", emp2.firstName, emp2.lastName, "-", emp2.position);

            Employee emp3 = new Employee("Anton", "Sobolev", "developer");
            string person3 = string.Join(" ", emp3.firstName, emp3.lastName, "-", emp3.position);

            Employee emp4 = new Employee("Ruslan", "Orlov", "architect");
            string person4 = string.Join(" ", emp4.firstName, emp4.lastName, "-", emp4.position);

            Employee emp5 = new Employee("Unassigned", "n/a", "n/a");
            string person5 = string.Join(" ", emp5.firstName, emp5.lastName, "-", emp5.position);

            Person person = new Person();
            person.persons.Add(new Person() { FirstAndLastName = person1 });
            person.persons.Add(new Person() { FirstAndLastName = person2 });
            person.persons.Add(new Person() { FirstAndLastName = person3 });
            person.persons.Add(new Person() { FirstAndLastName = person4 });
            person.persons.Add(new Person() { FirstAndLastName = person5 });

            //Override example
            BoardAddInfo b = new BoardAddInfo("general", "100", "approved" );
            Console.WriteLine($"\nAdditional information about board: {b.type} - {b.Info()}");

            //create cards
            Card card = new Card();
            Console.WriteLine("\nPlease enter first card id: ");
            string card1Id = Console.ReadLine();
            Console.WriteLine("Please enter second card id: ");
            string card2Id = Console.ReadLine();
            Console.WriteLine("Please enter third card id: ");
            string card3Id = Console.ReadLine();

            //enter card summary
            Console.WriteLine("Please enter first card summary: ");
            string card1Summary = Console.ReadLine();
            Console.WriteLine("Please enter second card summary: ");
            string card2Summary = Console.ReadLine();
            Console.WriteLine("Please enter third card summary: ");
            string card3Summary = Console.ReadLine();

            //enter card status
            Console.WriteLine("Please enter first card status: ");
            string card1Status = Console.ReadLine();
            Console.WriteLine("Please enter second card status: ");
            string card2Status = Console.ReadLine();
            Console.WriteLine("Please enter third card status: ");
            string card3Status = Console.ReadLine();

            //enter card due date
            Console.WriteLine("Please enter first card due date: ");
            DateTime card1DueDt = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Please enter second card due date: ");
            DateTime card2DueDt = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Please enter third card due date: ");
            DateTime card3DueDt = Convert.ToDateTime(Console.ReadLine());

            card.cards.Add(new Card() { Id = card1Id, Summary = card1Summary, Status = card1Status, Assignee = person1, DueDate = card1DueDt });
            card.cards.Add(new Card() { Id = card2Id, Summary = card2Summary, Status = card2Status, Assignee = person2, DueDate = card2DueDt });
            card.cards.Add(new Card() { Id = card3Id, Summary = card3Summary, Status = card3Status, Assignee = person3, DueDate = card3DueDt });

            Menu menu = new Menu();
            //cards operations
            while (true)
            {
                menu.Command();
                switch (menu.command)
                {
                    case "f1":
                        card.Filter("New");
                        break;
                    
                    case "f2":
                        card.Filter("Resolved", "Closed");
                        break;

                    case "f3":
                        card.Filter("Resolved", "Closed", "Canceled");
                        break;

                    case "d1":
                        //display all cards with specified status
                         Console.WriteLine("Please select card status: ");
                         string cardStatus = Console.ReadLine();
                         foreach (Card cd in card.cards)
                         {
                             if (cd.Status == cardStatus)
                             {
                                 Console.WriteLine("Card Id: {0}, summary: {1}, status: {2}, assignee: {3}, due date: {4}", cd.Id, cd.Summary, cd.Status, cd.Assignee, cd.DueDate);
                             }
                         }
                        break;

                    case "d2":
                        // display all cards with specified assignee
                        Console.WriteLine("Please select card assignee: ");
                        string cardAssignee = Console.ReadLine();
                        foreach (Card cd2 in card.cards)
                        {
                            if (cd2.Assignee == cardAssignee)
                            {
                                Console.WriteLine("Card Id: {0}, summary: {1}, status: {2}, assignee: {3}, due date: {4}", cd2.Id, cd2.Summary, cd2.Status, cd2.Assignee, cd2.DueDate);
                            }
                        }
                        break;

                    case "r1":
                        //report1
                        Console.WriteLine("The following cards are expired:");
                        foreach (Card r1 in card.cards)
                        {
                            if (r1.DueDate <= new DateTime(2020, 07, 01))
                            {
                                Console.WriteLine("id: {0}, assignee: {1}, due date: {2}", r1.Id, r1.Assignee, r1.DueDate);
                            }
                        }
                        break;

                    case "r2":
                        //report2
                        Console.WriteLine("Cards for all users:");
                        foreach (Card r2 in card.cards)
                        {
                            if (person.persons.Any(c => c.FirstAndLastName == r2.Assignee))
                            {
                                Console.WriteLine("id: {0}, assignee: {1}", r2.Id, r2.Assignee);
                            }
                        }
                        break;

                    case "u1":
                        //update card summary
                        card.cards
                            .FindAll(s => s.Summary == "s1")
                            .ForEach(x => x.Summary = "summary1");

                        foreach (Card cd3 in card.cards)
                        {
                            Console.WriteLine("Card Id: {0}, summary: {1}, status: {2}, assignee: {3}, due date: {4}", cd3.Id, cd3.Summary, cd3.Status, cd3.Assignee, cd3.DueDate);
                        }
                        break;

                    case "u2":
                        //update card status
                        card.cards
                            .FindAll(s => s.Status == "New")
                            .ForEach(x => x.Status = "Resolved");

                        foreach (Card cd4 in card.cards)
                        {
                            Console.WriteLine("Card Id: {0}, summary: {1}, status: {2}, assignee: {3}, due date: {4}", cd4.Id, cd4.Summary, cd4.Status, cd4.Assignee, cd4.DueDate);
                        }
                        break;

                    case "u3":
                        //update card assignee
                        card.cards
                            .FindAll(s => s.Assignee == "Petrov Petr - architect")
                            .ForEach(x => x.Assignee = "Orlov Ruslan - architect");

                        foreach (Card cd5 in card.cards)
                        {
                            Console.WriteLine("Card Id: {0}, summary: {1}, status: {2}, assignee: {3}, due date: {4}", cd5.Id, cd5.Summary, cd5.Status, cd5.Assignee, cd5.DueDate);
                        }
                        break;

                    case "d":
                        //delete specified card from the list of cards
                        card.cards.RemoveAll(r => r.Status == "Closed");
                        foreach (Card cd6 in card.cards)
                        {
                            Console.WriteLine("Card Id: {0}, summary: {1}, status: {2}, assignee: {3}, due date: {4}", cd6.Id, cd6.Summary, cd6.Status, cd6.Assignee, cd6.DueDate);
                        }
                        break;

                    case "q":
                        return;

                    default:
                        Console.WriteLine("Command is not valid");
                        break;
                }
            }
        }
    }
}