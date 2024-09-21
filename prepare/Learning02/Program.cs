using System;

class Program
{
    static void Main(string[] args)
    {
        // 1 : Display the welcome message
        Console.WriteLine("WELCOME TO THE BYUI GRADING PROGRAMME!");

        //  2: Ask the user for the percentage
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        // 3: Add to your code the ability to include a "+" or "-" next to the letter grade
        string letter = "";
        string sign = "";

        // 4: Determine the letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // 5: Determine if the grade has a + or -
        int lastDigit = percentage % 10;
        if (letter != "A" && letter != "F")  // A+ and F+/- do not exist
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && lastDigit < 3)
        {
            sign = "-";  // A- exists
        }

        // 6: Print the letter grade with sign
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // 7: Check if the user passed or failed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep working hard and you'll get it next time.");
        }
    }
}
