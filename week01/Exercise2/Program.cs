using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user
        Console.Write("Enter your percentage grade (0-100): ");
        int percentage = int.Parse(Console.ReadLine());

        string letter = ""; 
        string sign = "";   

        // Determine the letter grade using if, else if, else
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

        // Determine the + or - sign
        if (letter != "F" && percentage < 97) 
        {
            int lastDigit = percentage % 10; 

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Print the letter grade and sign
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Determine if the user passed or failed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("You did not pass this time, but don't give up. Keep trying!");
        }
    }
}