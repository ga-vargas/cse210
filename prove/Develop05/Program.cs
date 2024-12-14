// Code created to exceed requirements:
// 1. Added a mechanism to ensure prompts do not repeat within a session.
//    - A temporary list (_usedPrompts) tracks used prompts.
//    - The list resets only after all prompts have been used.
// 2. Added counters to track how many times each activity has been performed:
//    - _breathingCount, _listingCount, _reflectingCount.

using System;

namespace MindfulnessApp
{
    class Program
    {

        // counters to track how many times the option has been performed
        private static int _breathingCount = 0;
        private static int _listingCount = 0;
        private static int _reflectingCount = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Activities");
                Console.WriteLine($"1. Breathing Activity (Performed {_breathingCount} times)");
                Console.WriteLine($"2. Listing Activity (Performed {_listingCount} times)");
                Console.WriteLine($"3. Reflecting Activity (Performed {_reflectingCount} times)");
                Console.WriteLine("4. Quit");
                Console.Write("Select an Option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Run();
                        _breathingCount++;
                        break;

                    case "2":
                        ListingActivity listing = new ListingActivity();
                        listing.Run();
                        _listingCount++;
                        break;

                    case "3":
                        ReflectingActivity reflecting = new ReflectingActivity();
                        reflecting.Run();
                        _reflectingCount++;
                        break;

                    case "4":
                        Console.WriteLine("Good Bye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        System.Threading.Thread.Sleep(2000);
                        break;

                }
            }
        }

    }
}