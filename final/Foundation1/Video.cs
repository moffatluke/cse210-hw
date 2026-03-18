public class Video
{
    //Attibutes
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _commments;

    //Constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;

        List<Comment> comment = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        
    }
    
}