//cmt all of statements in this class if u want to run TeacherTest
using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiTap1;


class StudentTest
{
    static List<Student> students = new List<Student>();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("1. Input N students");
            Console.WriteLine("2. Display all students");
            Console.WriteLine("3. Display student with highest and lowest GPA");
            Console.WriteLine("4. Search student by ID");
            Console.WriteLine("5. Display all students in alphabetical order");
            Console.WriteLine("6. Display scholarship students in descending GPA order");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            Console.WriteLine();

            switch (option)
            {
                case "1":
                    InputStudents();
                    break;
                case "2":
                    DisplayAllStudents();
                    break;
                case "3":
                    DisplayMinMaxGPAStudents();
                    break;
                case "4":
                    SearchStudentById();
                    break;
                case "5":
                    DisplayStudentsAlphabetically();
                    break;
                case "6":
                    DisplayScholarshipStudents();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void InputStudents()
    {
        Console.Write("Enter number of students (N): ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter information for student {i + 1}:");
            Student student = new Student();
            student.InputInfo();
            students.Add(student);
        }
    }

    static void DisplayAllStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No student information available.");
        }
        else
        {
            Console.WriteLine("All students:");
            foreach (Student student in students)
            {
                student.ShowInfo();
            }
        }
    }

    static void DisplayMinMaxGPAStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No student information available.");
        }
        else
        {
            Student highestGPAStudent = students.OrderByDescending(s => s.GPA).First();
            Student lowestGPAStudent = students.OrderBy(s => s.GPA).First();

            Console.WriteLine($"Student with highest GPA:");
            highestGPAStudent.ShowInfo();
            Console.WriteLine($"Student with lowest GPA:");
            lowestGPAStudent.ShowInfo();
        }
    }

    static void SearchStudentById()
    {
        Console.Write("Enter student ID to search: ");
        string id = Console.ReadLine();

        Student foundStudent = students.FirstOrDefault(s => s.StudentId == id);

        if (foundStudent != null)
        {
            Console.WriteLine("Found student:");
            foundStudent.ShowInfo();
        }
        else
        {
            Console.WriteLine($"No student with ID '{id}' found.");
        }
    }

    static void DisplayStudentsAlphabetically()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No student information available.");
        }
        else
        {
            Console.WriteLine("Students in alphabetical order:");
            foreach (Student student in students.OrderBy(s => s.Name))
            {
                student.ShowInfo();
            }
        }
    }

    static void DisplayScholarshipStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No student information available.");
        }
        else
        {
            List<Student> scholarshipStudents = students.Where(s => s.GPA > 8.0).OrderByDescending(s => s.GPA).ToList();
            if (scholarshipStudents.Count == 0)
            {
                Console.WriteLine("No scholarship students found.");
            }
            else
            {
                Console.WriteLine("Scholarship students:");
                foreach (Student student in scholarshipStudents)
                {
                    student.ShowInfo();
                }
            }
        }
    }
}
