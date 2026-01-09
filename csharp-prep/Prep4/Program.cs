using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of whole numbers, type 0 when finished.");
        //create list to add values to
        List<int> numbers = new List<int>();
        int userNumber = -1;
        do
        {
            Console.Write("Enter a Number ");
            userNumber = int.Parse(Console.ReadLine());
            //add the number form the user to the list. 
            numbers.Add(userNumber);
        } while (userNumber != 0);

        //to check to see if the numbers were stored in the list properly
        /*for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }*/



        //Math time!
        //We should add all values to get sum

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        //average time have to make it  float to not a true average
        //casting to make sure it is a float but we can still use the int version of sum later
        float average = ((float)sum) / numbers.Count;

        //Max time
        //declare varaible
        int max = numbers[0];

        foreach(int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        //print statements
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {max}");
    }

}