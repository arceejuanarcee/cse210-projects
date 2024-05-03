//I added a feature that would save the journal into a .csv file when you want to. The .csv file will be found
// in the same folder where the program is located. Now, you can have your journal entry and open it using excel without ever running
// to the program again.

using System;

public class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("\n1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to CSV file");
            Console.WriteLine("4. Load journal from CSV file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    Entry entry = new Entry(date, prompt, response);
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.Write("Enter filename to save journal (CSV): ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToCSV(saveFilename);
                    Console.WriteLine("Journal saved successfully as CSV!");
                    break;
                case 4:
                    Console.Write("Enter filename to load journal (CSV): ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromCSV(loadFilename);
                    Console.WriteLine("Journal loaded successfully from CSV!");
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
