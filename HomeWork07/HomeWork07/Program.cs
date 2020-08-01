using System;

namespace HomeWork07
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.FirstName = "Devid";
            student.LastName = "Stiven";
            const int n = 8;
            int[] grades = new int[n] { 4, 5, 6, 6, 7, 8, 9, 10 };
            while (true)
            {
                Console.WriteLine("Please enter command: d - display student grades, c - calculte averge grade, q - quit");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "d":
                        Console.WriteLine("Student {0} {1} grades are: ", student.FirstName, student.LastName);
                        foreach (int i in grades)
                        {
                            Console.WriteLine(i);
                        }
                        continue;

                    case "c":
                        int sum = 0;
                        float average = 0;
                        for (int i = 0; i < grades.Length; i++)
                        {
                            sum += grades[i];
                            average = (float)sum / n;
                        }
                        Console.WriteLine("Average grade of student {0} {1} is {2}", student.FirstName, student.LastName, average);
                        break;

                    case "q":
                        return;

                    default:
                        Console.WriteLine("Command is not valid. Please enter command d, c or q (exit)");
                        break;
                }
                break;
            }
            Group group = new Group();
            Console.WriteLine("Please enter group number: g1 (Group No.1) or g2 (Group No.2)");
            string number = Console.ReadLine();
            switch (number)
            {
                case "g1":
                    while (true)
                    {
                        group.GroupName = "Group No.1";
                        string[] students = new string[] { "Ivanov", "Petrov", "Sobolev" };
                        const int g = 9;
                        int[] gradesStudent1 = new int[g] { 6, 6, 7, 8, 9, 10, 9, 8, 9 };
                        int[] gradesStudent2 = new int[g] { 7, 7, 8, 9, 10, 10, 8, 7, 8 };
                        int[] gradesStudent3 = new int[g] { 8, 8, 9, 10, 7, 9, 10, 8, 10 };
                        Console.WriteLine("Please enter command: s - display all students, d - display grades of each student, c - calculte averge grade of each student, q - quit");
                        string command2 = Console.ReadLine();

                        switch (command2)
                        {
                            case "s":
                                Console.WriteLine("Students of {0}: ", group.GroupName);
                                foreach (string i in students)
                                {
                                    Console.WriteLine(i);
                                }
                                break;

                            case "d":
                                Console.WriteLine("Grades of student {0}: ", students[0]);
                                foreach (int i in gradesStudent1)
                                {
                                    Console.WriteLine(i);
                                }
                                
                                Console.WriteLine("Grades of student {0}: ", students[1]);
                                foreach (int i in gradesStudent2)
                                {
                                    Console.WriteLine(i);
                                }
                                
                                Console.WriteLine("Grades of student {0}: ", students[2]);
                                foreach (int i in gradesStudent3)
                                {
                                    Console.WriteLine(i);
                                }
                                break;

                            case "c":
                                int sum = 0;
                                float average = 0;
                                for (int i = 0; i < gradesStudent1.Length; i++)
                                {
                                    sum += grades[i];
                                    average = (float)sum / n;
                                }
                                Console.WriteLine("Average grade of student {0} is {1}", students[0], average);
                                
                                for (int i = 0; i < gradesStudent2.Length; i++)
                                {
                                    sum += grades[i];
                                    average = (float)sum / n;
                                }
                                Console.WriteLine("Average grade of student {0} is {1}", students[1], average);
                                
                                for (int i = 0; i < gradesStudent3.Length; i++)
                                {
                                    sum += grades[i];
                                    average = (float)sum / n;
                                }
                                Console.WriteLine("Average grade of student {0} is {1}", students[2], average);
                                break;

                            case "q":
                                return;

                            default:
                                Console.WriteLine("Command is not valid. Please enter command s, c, d or q (exit)");
                                break;
                        }
                    }
                case "g2":
                    while (true)
                    {
                        group.GroupName = "Group No.2";
                        string[] students = new string[] { "Leonov", "Orlov", "Ruslanov" };
                        const int g = 8;
                        int[] gradesStudent1 = new int[g] { 4, 5, 6, 6, 7, 8, 9, 10 };
                        int[] gradesStudent2 = new int[g] { 5, 6, 6, 7, 8, 9, 10, 10 };
                        int[] gradesStudent3 = new int[g] { 9, 8, 8, 9, 10, 7, 9, 10 };
                        Console.WriteLine("Please enter command: s - display all students, d - display grades of each student, c - calculte averge grade of each student, q - quit");
                        string command2 = Console.ReadLine();

                        switch (command2)
                        {
                            case "s":
                                Console.WriteLine("Students of {0}: ", group.GroupName);
                                foreach (string i in students)
                                {
                                    Console.WriteLine(i);
                                }
                                break;

                            case "d":
                                Console.WriteLine("Grades of student {0}: ", students[0]);
                                foreach (int i in gradesStudent1)
                                {
                                    Console.WriteLine(i);
                                }
                                
                                Console.WriteLine("Grades of student {0}: ", students[1]);
                                foreach (int i in gradesStudent2)
                                {
                                    Console.WriteLine(i);
                                }
                                
                                Console.WriteLine("Grades of student {0}: ", students[2]);
                                foreach (int i in gradesStudent3)
                                {
                                    Console.WriteLine(i);
                                }
                                break;

                            case "c":
                                int sum = 0;
                                float average = 0;
                                for (int i = 0; i < gradesStudent1.Length; i++)
                                {
                                    sum += grades[i];
                                    average = (float)sum / n;
                                }
                                Console.WriteLine("Average grade of student {0} is {1}", students[0], average);
                                
                                for (int i = 0; i < gradesStudent2.Length; i++)
                                {
                                    sum += grades[i];
                                    average = (float)sum / n;
                                }
                                Console.WriteLine("Average grade of student {0} is {1}", students[1], average);
                                
                                for (int i = 0; i < gradesStudent3.Length; i++)
                                {
                                    sum += grades[i];
                                    average = (float)sum / n;
                                }
                                Console.WriteLine("Average grade of student {0} is {1}", students[2], average);
                                break;

                            case "q":
                                return;

                            default:
                                Console.WriteLine("Command is not valid. Please enter command s, d, c or q (exit)");
                                break;
                        }
                    }
            }
        }
    }
}
