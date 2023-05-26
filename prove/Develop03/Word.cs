public class Word
{
    private string _word;
    private bool _isVisible;

    public Word(string word)
    {
        _word = word;
        _isVisible = true;
    }

    public bool getIsVisible()
    {
        return _isVisible;
    }

    public void setIsVisible(bool isVisible)
    {
        _isVisible = isVisible;
    }

    public override string ToString()
    {
        if (_isVisible)
        {
            return _word;
        }
        else
        {
            string words = new string('_', _word.Length);
            return words;
        }
    }
}