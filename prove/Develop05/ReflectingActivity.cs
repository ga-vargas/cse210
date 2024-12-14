using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    // class for the reflecting Activity
    public class ReflectingActivity : Activity
    {
        //list of prompts for reflection
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        //list of questions for more reflection
        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times?",
            "What is your favorite thing about this experience?",
            "What did you learn about yourself?",
            "How can you keep this experience in mind in the future?"
        };

        private List<string> _usedPrompts = new List<string>();
        private List<string> _usedQuestions = new List<string>();

        //constructor which initializes the base constructor
        public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
        }

        // selects a random prompt from the list

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

        //selects a random question from the list
        private string GetRandomQuestion()
        {
            Random random = new Random();
            return _questions[random.Next(_questions.Count)];
        }

        // run method implementation
        public override void Run()
        {
            DisplayStartingMessage();
            string prompt = GetRandomPrompt();
            Console.WriteLine(prompt);

            DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

            while (DateTime.Now < endTime)
            {
                string question = GetRandomQuestion();
                Console.WriteLine(question);
                ShowSpinner(5);
            }

            DisplayEndingMessage();
        }
    }
}