public class BreathingActivity : MindfulnessActivity
{
    public override void StartActivity()
    {
        DisplayStartMessage("Breathing Activity", 
            "This activity will help you relax by guiding you to breathe in and out slowly.");

        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.Write("Breathe in...");
            PauseWithAnimation(3);
            Console.Write("Breathe out...");
            PauseWithAnimation(3);
            elapsed += 6;
        }

        DisplayEndMessage();
    }
}
