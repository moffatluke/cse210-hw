using System;

/*Class: Resume
Responsibilities:
Keeps track of the person's name and a list of their jobs.
Behaviors:
Displays the resume, which shows the name first, followed by displaying each one of the jobs.
*/

public class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();


    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        //loop to get the job data
        foreach (Job job in _jobs)
        {
            //after we get the job we have to display it
            job.Display();
        }
    }
}