using System;
using System.Collections.Generic;
using System.Linq;

//We need to get a new random prompt without using the same one twice
//We need to design it so that if all them get used then there should be a message
public class PromptGenerator
{

    //Creative Part:
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
        _availablePrompts = _availablePrompts
        .OrderBy(p => _random.Next())
        .ToList();
    }

//Shuffle the list 
    public string GetRandomPrompt()
    {
        //make sure there are prompts to use
        if (_availablePrompts.Count ==0)
        {
            return null;
        }

        //draw the top card of the prompts and then remove them
        string prompt = _availablePrompts[0];
        _availablePrompts.RemoveAt(0);
        _usedPrompts.Add(prompt);

        return prompt;
    }

    public void ResetPrompts()
    {
        _availablePrompts.AddRange(_usedPrompts);
        _usedPrompts.Clear();
        ShufflePrompts();
    }
}