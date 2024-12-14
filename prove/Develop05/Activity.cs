using System;
using System.Threading;

namespace MindfulnessApp
{
    // base class
    public abstract class Activity
    {
        // private attributes used by all classes
        private string _name;
        private string _description;
        private int _duration;

        //constructor 
        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        //getter to access to name
        public string GetName()
        {
            return _name;
        }

        //getter to access the description
        public string GetDescription()
        {
            return _description;
        }

        //setter for the duration
        public void SetDuration(int duration)
        {
            _duration = duration;
        }

        //getter for the duration
        public int GetDuration()
        {
            return _duration;
        }

        //Starting message of the activity
        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the name {GetName()} Activity.");
            Console.WriteLine(GetDescription());
            Console.Write("Enter the duration of the activity in seconds: ");
            SetDuration(int.Parse(Console.ReadLine()));
            Console.WriteLine("Prepare to Begin...");
            ShowSpinner(5);
        }

        //Displays ending message
        public void DisplayEndingMessage()
        {
            Console.WriteLine("Good job!");
            ShowSpinner(5);
            Console.WriteLine($"You have completed the {GetName()} Activity for {GetDuration()} seconds.");
            ShowSpinner(5);
        }

        //Shows a spinner animation for the time
        protected void ShowSpinner(int seconds)
        {
            string spinner = "|/-\\";
            for (int i = 0; i < seconds * 4; i++)
            {
                Console.Write(spinner[i % spinner.Length]);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }

        //Displays the countdown timer for the specified time
        protected void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        public abstract void Run();
    }
}