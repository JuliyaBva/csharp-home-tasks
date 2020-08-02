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
            const int n = 4;
            student.grades[0] = 7;
            student.grades[1] = 8;
            student.grades[2] = 9;
            student.grades[3] = 9;
            while (true)
            {
                Console.WriteLine("Please enter command: d - display student grades, c - calculate averge grade, q - quit");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "d":
                        Console.WriteLine("Student {0} {1} grades are: ", student.FirstName, student.LastName);
                        foreach (int i in student.grades)
                        {
                            Console.WriteLine(i);
                        }
                        continue;

                    case "c":
                        int sum = 0;
                        float average = 0;
                        for (int i = 0; i < student.grades.Length; i++)
                        {
                            sum += student.grades[i];
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
                        group.students[0] = "Ivanov";
                        group.students[1] = "Petrov";
                        group.students[2] = "Sobolev";
                        const int g = 7;
                        int[] gradesStudent1 = new int[g] { 4, 5, 6, 6, 7, 8, 9 };
                        int[] gradesStudent2 = new int[g] { 5, 6, 6, 7, 8, 9, 10 };
                        int[] gradesStudent3 = new int[g] { 9, 8, 8, 9, 10, 7, 9 };
                        Console.WriteLine("Please enter command: s - display all students, d - display grades of each student, c - calculate averge grade of each student, q - quit");
                        string command2 = Console.ReadLine();

                        switch (command2)
                        {
                            case "s":
                                Console.WriteLine("Students of {0}: ", group.GroupName);
                                foreach (string i in group.students)

                                {
                                    Console.WriteLine(i);
                                }
                                break;

                            case "d":
                                Console.WriteLine("Grades of student {0}: ", group.students[0]);
                                foreach (int i in gradesStudent1)
                                {
                                    Console.WriteLine(i);
                                }

                                Console.WriteLine("Grades of student {0}: ", group.students[1]);
                                foreach (int i in gradesStudent2)
                                {
                                    Console.WriteLine(i);
                                }

                                Console.WriteLine("Grades of student {0}: ", group.students[2]);
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
                                    sum += gradesStudent1[i];
                                    average = (float)sum / g;
                                }
                                Console.WriteLine("Average grade of student {0} is {1}", group.students[0], Math.Round(average, 2));

                                int sum2 = 0;
                                float average2 = 0;
                                for (int i = 0; i < gradesStudent2.Length; i++)
                                {
                                    sum2 += gradesStudent2[i];
                                    average2 = (float)sum2 / g;
                                }
                                Console.WriteLine("Average grade of student {0} is {1}", group.students[1], Math.Round(average2, 2));

                                int sum3 = 0;
                                float average3 = 0;
                                for (int i = 0; i < gradesStudent3.Length; i++)
                                {
                                    sum3 += gradesStudent3[i];
                                    average3 = (float)sum3 / g;
                                }
                                Console.WriteLine("Average grade of student {0} is {1}", group.students[2], Math.Round(average3, 2));
                                break;

                            case "q":
                                return;

                            default:
                                Console.WriteLine("Command is not valid. Please enter command s, d, c or q (exit)");
                                break;
                        }
                    }
                case "g2":
                    while (true)
                    {
                        group.GroupName = "Group No.2";
                        group.students[0] = "Leonov";
                        group.students[1] = "Orlov";
                        group.students[2] = "Ruslanov";
                        const int g = 8;
                        int[] gradesStudent1 = new int[g] { 4, 5, 6, 6, 7, 8, 9, 10 };
                        int[] gradesStudent2 = new int[g] { 5, 6, 6, 7, 8, 9, 10, 10 };
                        int[] gradesStudent3 = new int[g] { 9, 8, 8, 9, 10, 7, 9, 10 };
                        Console.WriteLine("Please enter command: s - display all students, d - display grades of each student, c - calculate averge grade of each student, q - quit");
                        string command2 = Console.ReadLine();

                        switch (command2)
                        {
                            case "s":
                                Console.WriteLine("Students of {0}: ", group.GroupName);
                                foreach (string i in group.students)
                                {
                                    Console.WriteLine(i);
                                }
                                break;

                            case "d":
                                Console.WriteLine("Grades of student {0}: ", group.students[0]);
                                foreach (int i in gradesStudent1)
                                {
                                    Console.WriteLine(i);
                                }

                                Console.WriteLine("Grades of student {0}: ", group.students[1]);
                                foreach (int i in gradesStudent2)
                                {
                                    Console.WriteLine(i);
                                }

                                Console.WriteLine("Grades of student {0}: ", group.students[2]);
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
                                    sum += gradesStudent1[i];
                                    average = (float)sum / g;
                                }
                                Console.WriteLine("Average grade of student {0} is {1}", group.students[0], Math.Round(average, 2));

                                int sum2 = 0;
                                float average2 = 0;
                                for (int i = 0; i < gradesStudent2.Length; i++)
                                {
                                    sum2 += gradesStudent2[i];
                                    average2 = (float)sum2 / g;
                                }
                                Console.WriteLine("Average grade of student {0} is {1}", group.students[1], Math.Round(average2, 2));

                                int sum3 = 0;
                                float average3 = 0;
                                for (int i = 0; i < gradesStudent3.Length; i++)
                                {
                                    sum3 += gradesStudent3[i];
                                    average3 = (float)sum3 / g;
                                }
                                Console.WriteLine("Average grade of student {0} is {1}", group.students[2], Math.Round(average3, 2));
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