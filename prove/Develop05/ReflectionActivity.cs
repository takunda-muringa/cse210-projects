using System.Collections.Generic;

public class ReflectionActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?",
        "What could you learn from this experience that applies to other situations?"
    };

    public override void StartActivity()
    {
        DisplayStartMessage("Reflection Activity",
            "This activity will help you reflect on times in your life when you've shown strength.");

        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);

        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine(questions[rand.Next(questions.Count)]);
            PauseWithAnimation(3);
            elapsed += 3;
        }

        DisplayEndMessage();
    }
}
