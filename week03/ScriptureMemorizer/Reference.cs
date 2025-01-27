public class Reference
{
    public string Text { get; private set; }

    public Reference(string text)
    {
        Text = text;
    }

    public Reference(string startVerse, string endVerse)
    {
        Text = $"{startVerse}-{endVerse}";
    }

    public override string ToString()
    {
        return Text;
    }
}
