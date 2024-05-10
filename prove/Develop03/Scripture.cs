using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    // Static list to manage a collection of Scriptures
    private static List<Scripture> scriptureLibrary = new List<Scripture>();
    private static Random rand = new Random();

    public Scripture(string scriptureText, Reference reference)
    {
        this.reference = reference;
        words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Method to add scriptures to the library
    public static void AddToLibrary(string scriptureText, Reference reference)
    {
        scriptureLibrary.Add(new Scripture(scriptureText, reference));
    }

    // Method to get a random scripture from the library
    public static Scripture GetRandomScripture()
    {
        int index = rand.Next(scriptureLibrary.Count);
        return scriptureLibrary[index];
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int index = rand.Next(words.Count);
            words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = reference.GetDisplayText() + ": ";
        displayText += string.Join(" ", words.Select(word => word.GetDisplayText()));
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        return words.All(word => word.IsHidden());
    }

    public static void ClearLibrary()
{
    scriptureLibrary.Clear();
}

}
