using System;

class Program
{
    static void Main(string[] args)
    {
        // Create address instances
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Oak St", "Seattle", "WA", "USA");

        // Create event instances
        Lecture lecture = new Lecture("Advanced C# Techniques", "A deep dive into C# programming.", "2024-10-15", "10:00 AM", address1, "Dr. Smith", 100);
        Reception reception = new Reception("Company Annual Meeting", "Annual meeting with shareholders.", "2024-11-01", "1:00 PM", address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Community BBQ", "A fun BBQ for the community.", "2024-09-05", "3:00 PM", address3, "Sunny");

        // Create a list of events
        Event[] events = { lecture, reception, outdoorGathering };

        // Display the details of each event
        foreach (Event e in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine("Full Details:");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine("Short Description:");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine(new string('-', 40));
            Console.WriteLine();
        }
    }
}
