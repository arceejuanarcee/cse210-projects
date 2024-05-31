public class Comment
{
    private string _commenterName;
    private string _text;

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public string CommenterName
    {
        get { return _commenterName; }
    }

    public string Text
    {
        get { return _text; }
    }

    public override string ToString()
    {
        return $"{_commenterName}: {_text}";
    }
}
