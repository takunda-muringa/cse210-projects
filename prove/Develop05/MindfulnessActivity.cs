using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    public int Duration { get; set; }

    public void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");//Allow the user to enter the time which he requires for the excercise
        Duration = int.Parse(Console.ReadLine());
    }

    public virtual void DisplayStartMessage(string activityName, string description)
    {
        Console.WriteLine($"\nStarting {activityName}...");
        Console.WriteLine(description);
        SetDuration();
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3); // Pauses for 3 seconds with animation
    }

    public virtual void DisplayEndMessage()
    {
        Console.WriteLine("\nGood job!");
        Console.WriteLine($"You completed the activity for {Duration} seconds.");
        PauseWithAnimation(3);
    }

    public void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void StartActivity();
}
