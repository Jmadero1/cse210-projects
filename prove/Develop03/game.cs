using System;

public class Game
{
    private Reference reference;
    private Scripture scripture;

    public Game(Reference reference, Scripture scripture)
    {
        this.reference = reference;
        this.scripture = scripture;
    }

  public void Start()
{
    while (true)
    {
        
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine();
        }

        Console.WriteLine($"Scripture: {reference.GetDisplayText()}");
        Console.WriteLine($"Text: {scripture.GetDisplayText()}");
        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

        var input = Console.ReadLine();
        if (input.ToLower() == "quit")
            break;

        scripture.HideRandomWords(3); // Hide 3 random words
        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("All words in the scripture are hidden. Game over.");
            break;
        }
    }
}


}
