using static System.Console;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video()
    {
        
    }

    public int CommentNum(List<Comment> myList)
    {
        return myList.Count();
    }

    public void GetVideo()
    {
        WriteLine($"Title: {_title}");
        WriteLine($"-{_author}, {_length} mins");
        WriteLine($"Comments ({CommentNum(_comments)})");
        
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}