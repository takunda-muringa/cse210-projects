public class ListingActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you helped this week?",
        "Who are some of your personal heroes?"
    };

    public override void StartActivity()
    {
        DisplayStartMessage("Listing Activity", 
            "This activity will help you reflect on positive things in your life.");

        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);

        Console.WriteLine("You have a few seconds to start listing...");
        PauseWithAnimation(3);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
        DisplayEndMessage();
    }
}
