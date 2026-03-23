using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Activities Stats: ");
        Console.WriteLine();

        List<Activity> activities = new List<Activity>();

        //activites

        //Running
        Running r1 = new Running("03 Nov 2022", 30, 9);
        activities.Add(r1);

        //Cycling
        Cycling c1 = new Cycling("02 Nov 2022", 45, 20);
        activities.Add(c1);

        //Swimming
        Swimming s1 = new Swimming("04 Nov 2022", 60, 90);
        activities.Add(s1);

        //loop through to display all the summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}