public class ListingActivity : Activity
{
    //Attributes:
    private List<string> _prompts;
    private Random _random;
    private List<string> _items;

    //Constructors
    public ListingActivity()
    : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0) //This is to pass the information to the parent class
    {
        _random = new Random();
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _items = new List<string>();
    }

    //Methods
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        string prompt = _prompts[_random.Next(_prompts.Count)]; //find a random prompt
        Console.Clear();
        Console.WriteLine("List as many responses you can to the follwoing prompt: ");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            
            //count the times
            if (response != "")
            {
                _items.Add(response); //add the response to the list 
            }
        }
        Console.WriteLine($"You lsited {_items.Count} items."); //Need to add the list items together
        DisplayEndingMessage();
    }
}