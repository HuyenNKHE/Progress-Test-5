//cmt all of statements in this class if u want to run StudentTest
using BaiTap1;
using System;
using System.Collections.Generic;
using System.Linq;

class TeacherTest
{
    static List<Teacher> teachers = new List<Teacher>();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("1. Input N teachers");
            Console.WriteLine("2. Display all teachers");
            Console.WriteLine("3. Display teacher with highest hours taught per month");
            Console.WriteLine("4. Display teacher with highest net salary");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            Console.WriteLine();

            switch (option)
            {
                case "1":
                    InputTeachers();
                    break;
                case "2":
                    DisplayAllTeachers();
                    break;
                case "3":
                    DisplayTeacherWithHighestHours();
                    break;
                case "4":
                    DisplayTeacherWithHighestSalary();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void InputTeachers()
    {
        Console.Write("Enter number of teachers (N): ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter information for teacher {i + 1}:");
            Teacher teacher = new Teacher();
            teacher.InputInfo();
            teachers.Add(teacher);
        }
    }

    static void DisplayAllTeachers()
    {
        if (teachers.Count == 0)
        {
            Console.WriteLine("No teacher information available.");
        }
        else
        {
            Console.WriteLine("All teachers:");
            foreach (Teacher teacher in teachers)
            {
                teacher.ShowInfo();
            }
        }
    }

    static void DisplayTeacherWithHighestHours()
    {
        if (teachers.Count == 0)
        {
            Console.WriteLine("No teacher information available.");
        }
        else
        {
            Teacher teacherWithHighestHours = teachers.OrderByDescending(t => t.HoursTaughtPerMonth).First();
            Console.WriteLine("Teacher with highest hours taught per month:");
            teacherWithHighestHours.ShowInfo();
        }
    }

    static void DisplayTeacherWithHighestSalary()
    {
        if (teachers.Count == 0)
        {
            Console.WriteLine("No teacher information available.");
        }
        else
        {
            Teacher teacherWithHighestSalary = teachers.OrderByDescending(t => t.CalculateNetSalary()).First();
            Console.WriteLine("Teacher with highest net salary:");
            teacherWithHighestSalary.ShowInfo();
            Console.WriteLine($"Net salary: {teacherWithHighestSalary.CalculateNetSalary()} VND");
        }
    }
}
