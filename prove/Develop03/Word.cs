public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;  // Words are visible by default
    }

    public void Hide()
    {
        isHidden = true;
    }

    public void Show()
    {
        isHidden = false;
    }

    public string GetDisplayText()
    {
        return isHidden ? new string('_', text.Length) : text;
    }

    public bool IsHidden()
    {
        return isHidden;
    }
}
