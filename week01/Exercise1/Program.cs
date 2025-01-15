using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the first name
        Console.WriteLine("What is your first name?: ");
        string name = Console.ReadLine();

        // Ask the last name
        Console.WriteLine("What is your last name?: ");
        string lname = Console.ReadLine();

        // order the sentence
        Console.Write($"Your name is {lname}, {name} {lname}.");

    }
}