using System.IO; 
public class Journal
{
    DateTime _currentDate = DateTime.Now;
    string _dateString = DateTime.Now.ToString("dd-MM-yyyy"); 
    public List<Entry> _ListOfEntries = new List<Entry>();
    
    public void AddEntry(Entry entry)
    {
        _ListOfEntries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach(Entry entry in _ListOfEntries)
        {
            entry.DisplayEntry();
            Console.WriteLine(" ");
        }
    }

    public void SaveToFile(string fileName)
    {
    using (StreamWriter outputFile = new StreamWriter(fileName))
        {
        foreach (Entry journalEntry in _ListOfEntries)
            {
            string line = $"{_dateString}|{journalEntry._prompt}|{journalEntry._response}";
                outputFile.WriteLine(line);
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Entry journalEntry = new Entry();
            string[] values = line.Split("|");
            journalEntry._prompt = values[1];
            journalEntry._response = values [2];
            _ListOfEntries.Add(journalEntry);


        }

    }

    public void SearchForFile(string directory)
    {
        string path = directory;
        string[] files = Directory.GetFiles(path, "*.txt");
        foreach (string file in files)
        {
          Console.WriteLine(Path.GetFileName(file));
        }
    }
}