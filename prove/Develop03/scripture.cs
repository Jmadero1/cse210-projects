using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<Word> words;

    public Scripture(string text)
    {
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(words.Count);
            words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        return string.Join(" ", words.Select(word => word.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return words.All(word => word.IsHidden());
    }
}
