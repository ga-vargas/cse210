using System;
using System.ComponentModel.DataAnnotations;

namespace MindfulnessApp
{
    // class for the breathing activity
    public class BreathingActivity : Activity
    {
        //constructor which initializes and calls the base constructor
        public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        //run method for the breathing activity
        public override void Run()
        {
            DisplayStartingMessage();
            DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                ShowCountDown(5);
                Console.WriteLine("Breathe out...");
                ShowCountDown(5);
            }
            DisplayEndingMessage();
        }
    }
}