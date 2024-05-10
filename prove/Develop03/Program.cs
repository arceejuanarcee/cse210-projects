//The program supports continuous memorization of scriptures. After a user completes the memorization of one scripture,
// they are prompted to decide whether they wish to continue with another randomized scripture or exit the program.

class Program
{
    static void Main(string[] args)
    {
        PopulateLibrary();

        bool continueMemorizing = true;

        while (continueMemorizing)
        {
            // Select a random scripture from the library
            Scripture selectedScripture = Scripture.GetRandomScripture();

            DisplayScripture(selectedScripture);

            string input = Console.ReadLine();

            while (input.ToLower() != "quit" && !selectedScripture.IsCompletelyHidden())
            {
                selectedScripture.HideRandomWords(1);
                Console.Clear();
                DisplayScripture(selectedScripture);
                input = Console.ReadLine();
            }

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Exiting program...");
                continueMemorizing = false;
            }
            else
            {
                Console.WriteLine("All words are hidden! Would you like to try another scripture? (yes/no)");
                string choice = Console.ReadLine();
                continueMemorizing = choice.Trim().ToLower() == "yes";
                if (!continueMemorizing)
                {
                    Console.WriteLine("Thank you for using the Scripture Memorizer. Goodbye!");
                }
            }
        }
    }

    static void PopulateLibrary()
    {
        // This resets the library each time the application is started to avoid unintended state retention.
        Scripture.ClearLibrary();
        Scripture.AddToLibrary("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.", new Reference("Proverbs", 3, 5, 6));
        Scripture.AddToLibrary("I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.", new Reference("1 Nephi", 3, 7));
        Scripture.AddToLibrary("Look unto me in every thought; doubt not, fear not.", new Reference("D&C", 6, 36));
        Scripture.AddToLibrary("Pray always, that you may come off conqueror; yea, that you may conquer Satan, and that you may escape the hands of the servants of Satan that do uphold his work.", new Reference("D&C", 10, 5));
        Scripture.AddToLibrary("Feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.", new Reference("2 Nephi", 32, 3));
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
    }
}
