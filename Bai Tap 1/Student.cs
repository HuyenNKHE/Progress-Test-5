using BaiTap1;
using System;

class Student : Person
{
    private string studentId;
    private double gpa;
    private string email;

    public string StudentId
    {
        get { return studentId; }
        set
        {
            if (value.Length == 8)
            {
                studentId = value;
            }
            else
            {
                throw new ArgumentException("Student ID must contain exactly 8 characters.");
            }
        }
    }

    public double GPA
    {
        get { return gpa; }
        set
        {
            if (value >= 0.0 && value <= 10.0)
            {
                gpa = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("GPA must be between 0.0 and 10.0.");
            }
        }
    }

    public string Email
    {
        get { return email; }
        set
        {
            if (value.Contains("@") && !value.Contains(" "))
            {
                email = value;
            }
            else
            {
                throw new ArgumentException("Invalid email format.");
            }
        }
    }

    // Override InputInfo method to input student information
    public override void InputInfo()
    {
        base.InputInfo(); // Call base class method to input person information

        Console.Write("Enter student ID (8 characters): ");
        StudentId = Console.ReadLine();

        Console.Write("Enter GPA (0.0 - 10.0): ");
        GPA = double.Parse(Console.ReadLine());

        Console.Write("Enter email: ");
        Email = Console.ReadLine();
    }

    // Override ShowInfo method to display student information
    public override void ShowInfo()
    {
        base.ShowInfo(); // Call base class method to display person information

        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"GPA: {GPA}");
        Console.WriteLine($"Email: {Email}");
    }

    // Method to check if student qualifies for scholarship (GPA > 8.0)
    public bool HasScholarship()
    {
        return GPA > 8.0;
    }
}

