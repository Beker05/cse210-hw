class Activity
{
    protected int Duration { get; private set; }

    public virtual void ShowIntroduction()
    {
        Console.WriteLine("Welcome to the activity!");
    }

    public void SetDuration(int duration)
    {
        Duration = duration;
    }

    public virtual void StartActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3); // Animación de preparación
        Console.WriteLine();
    }

    public virtual void RunActivity()
    {
        Console.WriteLine("Running activity...");
        Thread.Sleep(Duration * 1000);
    }

    public virtual void EndActivity()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine("\nYou have completed another " + Duration + " seconds of this activity.");
        ShowSpinner(4);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "- ", "\\ ", "| ", "/ " };
        int left = Console.CursorLeft;
        int top = Console.CursorTop;

        Console.CursorVisible = false; 

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime)
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
