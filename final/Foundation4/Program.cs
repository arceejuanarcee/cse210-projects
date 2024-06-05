using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Input for Running
        Console.WriteLine("Enter details for Running activity:");
        Console.Write("Enter date (yyyy-mm-dd): ");
        DateTime runningDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter duration in minutes: ");
        int runningDuration = int.Parse(Console.ReadLine());
        Console.Write("Enter distance in miles: ");
        double runningDistance = double.Parse(Console.ReadLine());
        activities.Add(new Running(runningDate, runningDuration, runningDistance));
        Console.WriteLine();

        // Input for Cycling
        Console.WriteLine("Enter details for Cycling activity:");
        Console.Write("Enter date (yyyy-mm-dd): ");
        DateTime cyclingDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter duration in minutes: ");
        int cyclingDuration = int.Parse(Console.ReadLine());
        Console.Write("Enter speed in mph: ");
        double cyclingSpeed = double.Parse(Console.ReadLine());
        activities.Add(new Cycling(cyclingDate, cyclingDuration, cyclingSpeed));
        Console.WriteLine();

        // Input for Swimming
        Console.WriteLine("Enter details for Swimming activity:");
        Console.Write("Enter date (yyyy-mm-dd): ");
        DateTime swimmingDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter duration in minutes: ");
        int swimmingDuration = int.Parse(Console.ReadLine());
        Console.Write("Enter number of laps: ");
        int swimmingLaps = int.Parse(Console.ReadLine());
        activities.Add(new Swimming(swimmingDate, swimmingDuration, swimmingLaps));
        Console.WriteLine();

        // Display the summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
