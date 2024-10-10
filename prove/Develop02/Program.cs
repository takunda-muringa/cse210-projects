using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1 : Display the welcome message
        Console.WriteLine("WELCOME TO TAKUNA'S JOURNAL");

        Journal myJournal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person you interacted with today?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "What was the strongest emotion you felt today?",
            "If you had one thing you could do over today, what would it be?"
        };

        // Use the while statement....

        while (true)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            //Use the if statement

            if (choice == "1")
            {
                Random rand = new Random();
                string prompt = prompts[rand.Next(prompts.Count)];
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                myJournal.AddEntry(prompt, response);
            }
            else if (choice == "2")
            {
                myJournal.DisplayJournal();
            }
            else if (choice == "3")
            {
                Console.Write("Enter a filename to save the journal: ");
                string fileName = Console.ReadLine();
                myJournal.SaveJournal(fileName);
                Console.WriteLine("Journal saved.");
            }
            else if (choice == "4")
            {
                Console.Write("Enter a filename to load the journal: ");
                string fileName = Console.ReadLine();
                myJournal.LoadJournal(fileName);
                Console.WriteLine("Journal loaded.");
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}
