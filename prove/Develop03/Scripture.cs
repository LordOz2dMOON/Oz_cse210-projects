public class Scripture
{
    private int _wordsToHide;
    private Random rnd = new Random();
    private Reference _reference;
    private List<Word> verse = new List<Word>();

    public Scripture(string scripture, Reference reference, int wordsToHide)
    {   ParseScripture(scripture);
        _reference = reference;
        _wordsToHide = wordsToHide;
    }

    private void ParseScripture(string scripture)
    {
         string [] words = scripture.Split(" ");
         for (int i = 0; i < words.Count(); i++)
         {
            verse.Add(new Word(words[i]));
         }
        
    }

    public override string ToString()
    {
        string refScript = _reference.ToString();
        refScript = refScript + "\n";
        for (int i = 0; i < verse.Count(); i++)
        {
            refScript = refScript + verse[i].ToString() + " ";
        }
        HideWords();
        return refScript;
    }

    public void HideWords()
    {
        for (int i = 0; i < _wordsToHide; i++)
        {
            int index  = rnd.Next(verse.Count());
            verse[index].setIsVisible(false);
        }
    }

    public bool AllHidden()
    {
        for (int i = 0; i < verse.Count(); i++)
        {
            if (verse[i].getIsVisible())
            {
                return false;
            }
        }
        return true;
    }
}