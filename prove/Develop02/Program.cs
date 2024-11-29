using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string userChoice = "";

        while (userChoice != "5")
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry:");
            Console.WriteLine("2. Display the journal:");
            Console.WriteLine("3. Save the journal to a file:");
            Console.WriteLine("4. Load the journal from a file:");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Choose an Option:");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("Your Response: ");
                    string response = Console.ReadLine();
                    myJournal.AddEntry(prompt, response);
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter the filename to save to: ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter the filename to load from: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    break;

                case "5":
                    Console.WriteLine("GoodBye!");
                    break;

                default:
                    Console.WriteLine("Invalid Choice. Please Try Again");
                    break;
            }

        }
    }
}