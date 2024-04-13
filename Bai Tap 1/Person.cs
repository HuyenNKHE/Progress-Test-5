using System;
namespace BaiTap1;
class Person
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }

    // Constructor without parameters
    public Person()
    {
    }

    // Constructor with parameters
    public Person(string name, string gender, DateTime dateOfBirth, string address)
    {
        Name = name;
        Gender = gender;
        DateOfBirth = dateOfBirth;
        Address = address;
    }

    // Input information from console
    public virtual void InputInfo()
    {
        Console.Write("Enter name: ");
        Name = Console.ReadLine();

        Console.Write("Enter gender: ");
        Gender = Console.ReadLine();

        Console.Write("Enter date of birth (yyyy-MM-dd): ");
        DateOfBirth = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter address: ");
        Address = Console.ReadLine();
    }

    // Show information
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"Date of Birth: {DateOfBirth.ToString("yyyy-MM-dd")}");
        Console.WriteLine($"Address: {Address}");
    }
}


