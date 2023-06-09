public class Reference
{
    private string _book;
    private string _chapter;
    private string _endVerse;
    private string _startVerse;

    public Reference(string book, string chapter, string startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = "";
    }

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        string startVerse = $"{_book} {_chapter}:{_startVerse }";
        string endVerse = $"{_startVerse }-{_endVerse }";
        if (_endVerse.Length == 0)
        {
            return startVerse;
        }
        else
        {
            return endVerse;
        }
    }
}