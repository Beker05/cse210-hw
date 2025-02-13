class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public override void ShowIntroduction()
    {
        Console.WriteLine("📋Welcome to the Listing Activity 📋");
        Console.WriteLine("");
        Console.WriteLine("This activity will help you focus on the positive aspects of your life.");
        Console.WriteLine("By listing things you are grateful for or strengths you possess, you can boost your mood and develop a positive mindset.");
        Console.WriteLine("Take a deep breath and get ready to start listing!");
        Console.WriteLine("");
    }

    public override void RunActivity()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");

        Console.Write("You may begin in: ");
        CountdownTimer(5); 

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> "); 
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {responses.Count} items.");
        Console.WriteLine("");
    }
    
    private void CountdownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rYou may begin in: {i} "); 
            Thread.Sleep(1000);
        }

        Console.Write("\rYou may begin in:    "); 
        Console.WriteLine("");
    }

}
