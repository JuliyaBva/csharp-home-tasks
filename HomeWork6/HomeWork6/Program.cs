using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Please select Stack or Queue. For this, please enter number 1 or 2 correspondingly: ");
            var number = Console.ReadLine();
            int num = Convert.ToInt32(number);
            switch (num)
            {
                case 1:
                    //Stack
                    //Note: number of students from which home tasks are expected to be received is 3
                    Stack<Person> personsInStack = new Stack<Person>();
                    Console.WriteLine("Stack was selected");
                    Console.WriteLine("Please enter name of the first student: ");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("Please enter name of the second student: ");
                    string name2 = Console.ReadLine();
                    Console.WriteLine("Please enter name of the third student: ");
                    string name3 = Console.ReadLine();

                    personsInStack.Push(new Person() { Name = name1 });
                    personsInStack.Push(new Person() { Name = name2 });
                    personsInStack.Push(new Person() { Name = name3 });
                    Console.WriteLine("\nTask from student {0} is received", name1);
                    Console.WriteLine("Task from student {0} is received", name2);
                    Console.WriteLine("Task from student {0} is received", name3);
            
                    Person person1InStack = personsInStack.Pop();
                    Person person2InStack = personsInStack.Pop();
                    Person person3InStack = personsInStack.Pop();
                    Console.WriteLine("\nStudent {0} got a cup of coffee", person1InStack.Name);
                    Console.WriteLine("Student {0} got a cup of coffee", person2InStack.Name);
                    Console.WriteLine("Student {0} got a cup of coffee", person3InStack.Name);
                break;
                case 2:
                    //Queue
                    //Note: number of students from which home tasks are expected to be received is 3
                    Queue<Person> personsInQueue = new Queue<Person>();
                    Console.WriteLine("Queue was selected");
                    Console.WriteLine("Please enter name of the first student: ");
                    string stName1 = Console.ReadLine();
                    Console.WriteLine("Please enter name of the second student: ");
                    string stName2 = Console.ReadLine();
                    Console.WriteLine("Please enter name of the third student: ");
                    string stName3 = Console.ReadLine();

                    personsInQueue.Enqueue(new Person() { Name = stName1 });
                    personsInQueue.Enqueue(new Person() { Name = stName2 });
                    personsInQueue.Enqueue(new Person() { Name = stName3 });
                    Console.WriteLine("\nTask from student {0} is received", stName1);
                    Console.WriteLine("Task from student {0} is received", stName2);
                    Console.WriteLine("Task from student {0} is received", stName3);

                    Person person1InQueue = personsInQueue.Dequeue();
                    Person person2InQueue = personsInQueue.Dequeue();
                    Person person3InQueue = personsInQueue.Dequeue();
                    Console.WriteLine("\nStudent {0} got a cup of coffee", person1InQueue.Name);
                    Console.WriteLine("Student {0} got a cup of coffee", person2InQueue.Name);
                    Console.WriteLine("Student {0} got a cup of coffee", person3InQueue.Name);
               break;
            }
           Console.ReadLine();
        }
    }
    class Person
    {
        public string Name { get; set; }
    }
}
