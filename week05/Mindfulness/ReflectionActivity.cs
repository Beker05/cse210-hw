class ReflectionActivity : Activity
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
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public override void ShowIntroduction()
    {
        Console.WriteLine("Welcome to the Reflection Activity");
        Console.WriteLine("");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("By remembering these moments, you can gain confidence and learn valuable lessons for the future.");
        Console.WriteLine("Let's begin your reflection journey!\n");
    }

    public override void RunActivity()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"Consider the following prompt:\n\n--- {prompt} ---");

        Console.WriteLine("\nWhen you have something in mind, press enter to continue...");
        Console.ReadLine();

        Console.Write("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("\nYou may begin in: ");

        for (int i = 5; i > 0; i--)
        {
            Console.Write($"\rYou may begin in: {i}   ");
            Thread.Sleep(1000);
        }
        Console.Clear();

        HashSet<int> usedIndexes = new HashSet<int>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        bool isFirstQuestion = true;

        while (DateTime.Now < endTime && usedIndexes.Count < questions.Count)
        {
            int index;
            do
            {
                index = random.Next(questions.Count);
            } while (usedIndexes.Contains(index));

            usedIndexes.Add(index);

            if (!isFirstQuestion)
            {
                Console.WriteLine();
            }
            isFirstQuestion = false;

            Console.Write($"> {questions[index]} ");

            int spinnerLeft = Console.CursorLeft;
            int spinnerTop = Console.CursorTop;

            CancellationTokenSource cts = new CancellationTokenSource();
            Task spinnerTask = Task.Run(() => ShowSpinner(cts.Token, spinnerLeft, spinnerTop));

            Console.ReadLine();
            cts.Cancel();
            spinnerTask.Wait();

            Console.SetCursorPosition(spinnerLeft, spinnerTop);
            Console.Write("  ");
            Console.SetCursorPosition(spinnerLeft, spinnerTop);
        }

        Console.WriteLine("\n");
    }

    private void ShowSpinner(CancellationToken token, int left, int top)
    {
        string[] spinner = { "- ", "\\ ", "| ", "/ " };
        int index = 0;

        Console.CursorVisible = false;

        while (!token.IsCancellationRequested)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(spinner[index++ % 4]);
            Thread.Sleep(500);
        }

        Console.SetCursorPosition(left, top);
        Console.Write("  ");
        Console.CursorVisible = true;
    }
}
