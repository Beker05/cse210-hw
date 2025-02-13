class BreathingActivity : Activity
{
    public override void ShowIntroduction()
    {
        Console.WriteLine("Welcome to the Breathing Exercise");
        Console.WriteLine("");
        Console.WriteLine("This activity will help you relax by guiding you through deep breathing.");
        Console.WriteLine("Deep breathing can reduce stress, increase focus, and improve your mood.");
        Console.WriteLine("Follow the instructions and focus on your breath. Let's begin!");
        Console.WriteLine("");
    }

    public override void RunActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        Countdown("Breathe in...", 3);
        Countdown("Now Breathe out...", 4); 

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Countdown("Breathe in...", 4); 
            Countdown("Now Breathe out...", 6); 
            Console.WriteLine("");
        }
    }

    private void Countdown(string message, int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{message} {i} "); 
            Thread.Sleep(1000);
        }

        Console.Write($"\r{message}    \r{message}\n"); 
    }
}
