public class Scripture
{
    public Reference Reference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        Words = new List<Word>();

        // Dividir el texto en palabras
        foreach (var word in text.Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(Reference);
        foreach (var word in Words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        
        var wordsToHide = Words.Where(w => !w.IsHidden).ToList();

        if (wordsToHide.Count > 0)
        {
            var wordToHide = wordsToHide[random.Next(wordsToHide.Count)];
            wordToHide.Hide();
        }
    }

    public bool IsFullyHidden()
    {
        foreach (var word in Words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }
}
