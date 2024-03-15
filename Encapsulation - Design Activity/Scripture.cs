using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> words;

    public Scripture(string text)
    {
        words = new List<Word>();
       
    }

    public void HideRandomWords(int numberToHide)
    {
        
    }

    public string GetDisplayText()
    {
        
        return "";
    }

    public bool IsCompletelyHidden()
    {
        
        return false;
    }
}
