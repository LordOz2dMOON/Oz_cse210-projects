public class Video
{
    public string _title;
    public string _author;
    public int _seconds;
    public List<Comments> comments = new List<Comments>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _seconds = length;
    }

    public int ReturnNumOfComments()
    {
        return comments.Count();
    }
}