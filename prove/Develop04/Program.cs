// I added a feature wher a user can select an option to view an activity log. This activity log is also saved as a .txt file.

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Activity Log:");
                LoadLog();
                Console.WriteLine("Press any key to return to the menu.");
                Console.ReadKey();
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }

    public static void SaveLog(string activityName, int duration)
    {
        using (StreamWriter sw = new StreamWriter("activity_log.txt", true))
        {
            sw.WriteLine($"{DateTime.Now}: {activityName} for {duration} seconds");
        }
    }

    public static void LoadLog()
    {
        if (File.Exists("activity_log.txt"))
        {
            using (StreamReader sr = new StreamReader("activity_log.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        else
        {
            Console.WriteLine("No log file found.");
        }
    }
}
