
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        // Creativity: This journal includes a daily mood rating
        // from 1 to 5 to help users reflect on their emotional well-being.
        // This is additional information saved with every journal entry.

        while (running)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");

            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine($"\n{prompt}");
                    Console.Write("> ");

                    string response = Console.ReadLine() ?? "";

                    Console.Write("Rate your mood today from 1 to 5: ");
                    string mood = Console.ReadLine() ?? "";

                    Entry newEntry = new Entry();

                    newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
                    newEntry._prompt = prompt;
                    newEntry._response = response;
                    newEntry._mood = mood;

                    journal.AddEntry(newEntry);

                    Console.WriteLine("Your entry has been added!");
                    break;

                case "2":
                    Console.WriteLine("\nYour Journal Entries:");
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter the filename to save: ");
                    string saveFile = Console.ReadLine() ?? "";

                    if (saveFile != "")
                    {
                        journal.SaveToFile(saveFile);
                    }
                    break;

                case "4":
                    Console.Write("Enter the filename to load: ");
                    string loadFile = Console.ReadLine() ?? "";

                    if (loadFile != "")
                    {
                        journal.LoadFromFile(loadFile);
                    }
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Thank you for using the Journal Program!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1-5.");
                    break;
            }
        }
    }
}
