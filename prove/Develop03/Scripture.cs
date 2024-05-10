using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(string scriptureText, Reference reference)
    {
        this.reference = reference;
        words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
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
}
