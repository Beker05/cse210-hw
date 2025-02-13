using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "4")
            {
                Console.WriteLine("Goodbye! Stay mindful. 😊");
                break;
            }

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                _ => null
            };

            if (activity != null)
            {
                Console.Clear();
                activity.ShowIntroduction(); 
                Console.Write("How long, in seconds, would you like for your session: ");
                if (!int.TryParse(Console.ReadLine(), out int duration) || duration <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Thread.Sleep(2000);
                    continue;
                }
                
                activity.SetDuration(duration); 
                activity.StartActivity();
                activity.RunActivity();
                activity.EndActivity();
            }
        }
    }
}
