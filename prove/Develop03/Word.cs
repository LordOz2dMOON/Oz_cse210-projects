public class Word
{
    private string _word;
    
    private bool _isVisible;
    //variable to check if word is visible

    public Word(string word)
    {
        _word = word;
        _isVisible = true;
    }

    public bool getIsVisible()
    //get true or false value
    {
        return _isVisible;
    }

    public void setIsVisible(bool isVisible)
    //set true or false value
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