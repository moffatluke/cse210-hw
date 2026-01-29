using System;
using System.Collections.Generic;
using System.Linq;


public class PromptGenerator
{

    //CREATIVE PART:
    //Build the prompts like a deck of cards
    //draw pile and the move to a discard pile

    public List<string> _availablePrompts;
    public List<string> _usedPrompts = new List<string>();
    public Random _random = new Random();


//Attributes
    public PromptGenerator()
    {
        _availablePrompts = new List<string>
        {
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Who was the most interesting person I interacted with today?",
        "Why did I do the things I did today?",
        "Who in my life can help tommorrow?"
        };

        ShufflePrompts();
    }

    public void ShufflePrompts()
    {
        //This takes the prompts and shuffles the list. 
        //Had to add System.Linq
        //Did some research on simplist shuffle ideas and Linq seemed to be the easiest to implement with the current code. 

        _availablePrompts = _availablePrompts
        
        //OrderBy with the Next method greats a random value that gets assigned to each string. Then sorts by those numbers.

        .OrderBy(p => _random.Next())
        //The ToList converts the list back into a string list and reassigns the prompts to the shuffled list
        .ToList();
    }

    public string GetRandomPrompt()
    {
        //make sure there are prompts to use
        if (_availablePrompts.Count ==0)
        {
            return null;
        }

        //draw the 'top card' of the prompts and then remove and add them to the used list.
        string prompt = _availablePrompts[0];
        _availablePrompts.RemoveAt(0);
        _usedPrompts.Add(prompt);

        return prompt;
    }

    public void ResetPrompts()
    {
        //This resets the list and clears the old list then it reshuffles.
        _availablePrompts.AddRange(_usedPrompts);
        _usedPrompts.Clear();
        ShufflePrompts();
    }
}