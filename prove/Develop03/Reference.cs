public class Reference
{

    //This class is to store the scripture found and handle the verse range
    //Member Variables
    private string _book;
    private int _startVerse;
    private int _endVerse;

    private int _chapter;
    
    //CONSTRUCTORS:
    public Reference(string book, int chapter, int verse)
    {
        //todo
        book = _book;
        chapter = _chapter;
        
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        book = _book;
        chapter = _chapter;
        startVerse = _startVerse;
        endVerse = _endVerse;
    }

    //getter/setters?


//Methods
    public void GetDisplayText(string book, int chapter, int endVerse)
        {
            Console.WriteLine($" {_book} {_chapter}:{_endVerse}");
        }

        public void GetDisplayText(string book, int chapter, int startVerse, int endVerse)
        {
            Console.WriteLine($" {_book} {_chapter}:{_startVerse}-{_endVerse}");
        }
}