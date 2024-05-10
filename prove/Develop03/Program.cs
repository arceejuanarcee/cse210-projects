class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.", reference);

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");

        string input = Console.ReadLine();

        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            scripture.HideRandomWords(1); // This hides one random word each loop iteration
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();
        }

        if (input.ToLower() == "quit")
        {
            Console.WriteLine("Exiting program...");
        }
        else
        {
            Console.WriteLine("All words are hidden!");
        }
    }
}
