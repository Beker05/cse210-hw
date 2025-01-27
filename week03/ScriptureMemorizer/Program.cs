using System;

class Program
{
    static void Main(string[] args)
    {
        var scriptures = new (string reference, string text)[]
        {
            ("1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            ("2 Nephi 2:25", "Adam fell that men might be; and men are, that they might have joy."),
            ("Mosiah 2:17", "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."),
            ("Alma 32:21", "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."),
            ("Ether 12:27", "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.")
        };

        Random random = new Random();
        var randomScripture = scriptures[random.Next(scriptures.Length)];

        Scripture scripture = new Scripture(randomScripture.reference, randomScripture.text);

        scripture.Display();

        while (!scripture.IsFullyHidden())
        {
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWord();
            scripture.Display();
        }

        Console.WriteLine("Memorized! Writing completely hidden.");
    }
}
