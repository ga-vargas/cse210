// Changes to Exceed Core Requirements:
// 1. Scripture List: 
//    Designed a list of scriptures that includes passages from both the New Testament and the Book of Mormon. 
//    The program selects a scripture at random, providing variety to the user each time they practice.
//
// 2. Loop Functionality: 
//    Added a loop that prompts the user to decide if they want to practice another scripture 
//    or exit the program once a scripture is fully hidden. This eliminates the need to 
//    restart the program manually after each scripture, making a better experience.
//
// These changes increase the program's usability and interactivity, allowing users to practice multiple scriptures 
// in one session and exit whenever they choose.


using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //List of Scriptures
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish but have everlasting life."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("Romans", 8, 28), "And we know that all things work together for good to them that love God, to them who are the called according to his purpose."),
            new Scripture(new Reference("Matthew", 5, 9), "Blessed are the peacemakers: for they shall be called the children of God."),
            new Scripture(new Reference("Hebrews", 11, 1), "Now faith is the substance of things hoped for, the evidence of things not seen."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Ether", 12, 27), "And if men come unto me I will show unto them their weakness then will I make weak things become strong unto them."),
            new Scripture(new Reference("Mormon", 9, 27), "Doubt not, but be believing, and begin as in times of old, and come unto the Lord with all your heart."),
            new Scripture(new Reference("Alma", 37, 6), "By small and simple things are great things brought to pass and small means in many instances doth confound the wise"),
            new Scripture(new Reference("Helaman", 5, 12), "Remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation."),
            new Scripture(new Reference("3 Nephi", 12, 14), "I give unto you to be the light of this people. A city that is set on a hill cannot be hid")
        };

        // Loop starting

        while (true)
        {
            // Select a random scripture
            Random random = new Random();
            Scripture selectedScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

            // Practice with selected scripture
            PracticeScripture(selectedScripture);

            // Do you wnat to continue practicing option
            Console.WriteLine("\nDo you want to practice another scripture? (yes/no)");
            string choice = Console.ReadLine().ToLower();

            if (choice != "yes")
            {
                Console.WriteLine("Thank you for using Scripture Memorizer. Goodbye!");
                break;
            }
        }

    }
    static void PracticeScripture(Scripture scripture)
    {
        // Main Loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(1);  // this will hide 1 random word 
        }
    }
}
