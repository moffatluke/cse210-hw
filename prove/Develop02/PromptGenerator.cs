using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;

//We need to get a new random prompt without using the same one twice
//We need to design it so that if all them get used then there should be a message
public class PromptGenerator
{

//Attributes
public List<string> Prompts = new List<string>
    {
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Who was the most interesting person I interacted with today?"
    };

//Shuffle the list 
public string GetRandomPrompt()
    {
        Random random = new Random();
        string randomPrompt = Prompts[random.Next(Prompts.Count)];
        return randomPrompt;
    }
}