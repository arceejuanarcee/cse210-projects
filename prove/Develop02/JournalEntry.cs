using System;

public class Entry
{
    public string Date { get; }
    public string PromptText { get; }
    public string EntryText { get; }

    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    public override string ToString()
    {
        return $"{Date}: {PromptText}\n{EntryText}\n";
    }
}
