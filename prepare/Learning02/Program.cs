using System;

class Program
{
    static void Main(string[] args)
    {
        // 1: The percantage grade
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        // 2: Add to your code the ability to include a "+" or "-" next to the letter grade
        string letter = "";
        string sign = "";

        // 3: Determine the letter grade
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

        // 4: Determine if the grade has a + or -
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

        // 5: Print the letter grade with sign
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // 6: Check if the student passed or failed/U can also use the letters instead of >70 u can use >C
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("Don't give up! If u are not failing you are not trying, Keep trying u will get it.");
        }
    }
}
