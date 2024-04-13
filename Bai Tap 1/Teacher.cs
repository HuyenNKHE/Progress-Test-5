using BaiTap1;
using System;

namespace BaiTap1;

class Teacher : Person
{
    public double netSalary;

    public string TeachingClass { get; set; }
    public double HourlyWage { get; set; }
    public int HoursTaughtPerMonth { get; set; }

    public override void InputInfo()
    {
        base.InputInfo();

        Console.Write("Enter teaching class (starting with G, H, I, K, L, or M): ");
        TeachingClass = Console.ReadLine();

        Console.Write("Enter hourly wage: ");
        HourlyWage = double.Parse(Console.ReadLine());

        Console.Write("Enter hours taught per month: ");
        HoursTaughtPerMonth = int.Parse(Console.ReadLine());
    }

    public override void ShowInfo()
    {
        base.ShowInfo();

        Console.WriteLine($"Teaching class: {TeachingClass}");
        Console.WriteLine($"Hourly wage: {HourlyWage}");
        Console.WriteLine($"Hours taught per month: {HoursTaughtPerMonth}");

    }

    public double CalculateNetSalary()
    {

        if (TeachingClass.StartsWith("G") || TeachingClass.StartsWith("H") || TeachingClass.StartsWith("I") ||
            TeachingClass.StartsWith("K"))
        {
            netSalary = HourlyWage * HoursTaughtPerMonth;
        }
        else if (TeachingClass.StartsWith("L") || TeachingClass.StartsWith("M"))
        {
            netSalary = (HourlyWage * HoursTaughtPerMonth) + 200000;
        }

        return netSalary;
    }
}


