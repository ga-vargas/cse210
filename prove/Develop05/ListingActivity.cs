using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    // class for the listing activity
    public class ListingActivity : Activity
    {
        // list of prompts to guide the user
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are your personal strengths?",
            "Who have you helped this week?",
            "Who are some of your personal heroes?",
            "What are some positive things in your life?"
        };

        // List to track used prompts
        private List<string> _usedPrompts = new List<string>();

        // constructor which initializes and calls the base constructor
        public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        //selects a random prompt
        private string GetRandomPrompt()
        {
            if (_usedPrompts.Count == _prompts.Count)
            {
                _usedPrompts.Clear();
            }

            Random random = new Random();
            string prompt;
            do
            {
                prompt = _prompts[random.Next(_prompts.Count)];
            } while (_usedPrompts.Contains(prompt));

            _usedPrompts.Add(prompt);
            return prompt;
        }

        // implementation of the run method
        public override void Run()
        {
            DisplayStartingMessage();
            string prompt = GetRandomPrompt();
            Console.WriteLine(prompt);
            Console.WriteLine("Start listing items...");

            List<string> items = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

            while (DateTime.Now < endTime)
            {
                Console.Write(">> ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    items.Add(input);
                }
            }

            Console.WriteLine($"You listed {items.Count} items!");
            DisplayEndingMessage();
        }
    }
}