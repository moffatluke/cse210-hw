public class Video
{
    //Attibutes
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    //Constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;

        _comments = new List<Comment>();
    }


// Methods


    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
public void Display()
{
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Length: {_lengthInSeconds} seconds");
    Console.WriteLine($"Number of comments: {GetNumberOfComments()}");

    foreach (Comment c in _comments)
    {
        Console.WriteLine($"  {c.GetCommenterName()}: {c.GetCommentText()}"); 
        // This gets the name and text that we need to put on the video
    }
}

}