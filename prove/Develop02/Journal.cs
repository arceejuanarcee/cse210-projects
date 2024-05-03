using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToCSV(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // Write header line
            writer.WriteLine("Date,Prompt,Entry");

            foreach (var entry in _entries)
            {
                // Escape any quotation marks in entry text
                string escapedEntryText = entry.EntryText.Replace("\"", "\"\"");
                // Enclose entry text in quotes to handle commas
                writer.WriteLine($"\"{entry.Date}\",\"{entry.PromptText}\",\"{escapedEntryText}\"");
            }
        }
    }

    public void LoadFromCSV(string filename)
    {
        _entries.Clear();

        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                // Skip header line
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');

                    if (parts.Length == 3)
                    {
                        string date = parts[0].Trim('"');
                        string promptText = parts[1].Trim('"');
                        string entryText = parts[2].Trim('"').Replace("\"\"", "\"");
                        _entries.Add(new Entry(date, promptText, entryText));
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
