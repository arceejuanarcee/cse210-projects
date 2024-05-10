public class Reference
{
    private string book;
    private int chapter;
    private int verse;
    private int? endVerse;  // Nullable to handle single verse references

    public Reference(string book, int chapter, int verse, int? endVerse = null)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (endVerse.HasValue)
            return $"{book} {chapter}:{verse}-{endVerse}";
        else
            return $"{book} {chapter}:{verse}";
    }
}
