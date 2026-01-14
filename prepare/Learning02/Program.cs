using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Here we have the instances for the job class
        //first job info
        Job job1 = new Job();

        job1._company = "Ubuntu";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2014";
        job1._endYear = "2024";

        //Second job
        Job job2 = new Job();

        job2._jobTitle = "Senior Product Manager";
        job2._startYear = "2024";
        job2._endYear = "Present";
        job2._company = "Apple";


        //Resume part
        Resume myResume = new Resume();

        //set name in the object ._name to access the name variable
        myResume._name = "Allison Rose";

        //fill the job boxes
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        //display all info (object within a object)
        myResume.Display();
    }
}