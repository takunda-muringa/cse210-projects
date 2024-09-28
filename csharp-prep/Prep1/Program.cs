using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the first name
        Console.Write("What is your first name? ");
        string first = Console.ReadLine(); 

        //Ask the last name  
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        //Display with the required format
        Console.WriteLine($"Your name is {last}, {first} {last}.");


    }
}
