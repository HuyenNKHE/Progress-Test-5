using System;
using System.Collections;

// Interface INews
interface INews
{
    void Display();
}

// Class News implements interface INews
class News : INews
{
    // Properties
    public int ID { get; set; }
    public string Title { get; set; }
    public string PublishDate { get; set; }
    public string Author { get; set; }
    public string Content { get; set; }
    public float AverageRate { get; private set; }

    // RateList array
    private int[] RateList = new int[3];

    // Constructor
    public News()
    {
        ID = 0;
        Title = "";
        PublishDate = "";
        Author = "";
        Content = "";
        AverageRate = 0;
    }

    // Method to display news details
    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Publish Date: {PublishDate}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Content: {Content}");
        Console.WriteLine($"Average Rate: {AverageRate}");
    }

    // Method to calculate AverageRate
    public void Calculate()
    {
        float sum = 0;
        foreach (int rate in RateList)
        {
            sum += rate;
        }
        AverageRate = sum / RateList.Length;
    }

    // Method to input rates
    public void InputRates()
    {
        for (int i = 0; i < RateList.Length; i++)
        {
            Console.Write($"Enter rate {i + 1}: ");
            RateList[i] = int.Parse(Console.ReadLine());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArrayList newsList = new ArrayList();
        while (true)
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("1. Insert news");
            Console.WriteLine("2. View list news");
            Console.WriteLine("3. Average rate");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            String option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    News news = new News();
                    Console.WriteLine("Enter news details:");
                    Console.Write("Title: ");
                    news.Title = Console.ReadLine();
                    Console.Write("Publish Date: ");
                    news.PublishDate = Console.ReadLine();
                    Console.Write("Author: ");
                    news.Author = Console.ReadLine();
                    Console.Write("Content: ");
                    news.Content = Console.ReadLine();
                    news.InputRates();
                    news.Calculate();
                    newsList.Add(news);
                    break;
                case "2":
                    Console.WriteLine("List of news:");
                    foreach (News n in newsList)
                    {
                        n.Display();
                    }
                    break;
                case "3":
                    Console.WriteLine("Average rate of news:");
                    foreach (News n in newsList)
                    {
                        n.Calculate();
                        n.Display();
                    }
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }
}
