using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;      // List of words and Reference

    // Constructor

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // Hide number of visible words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            // random word
            int index = random.Next(_words.Count);
            Word word = _words[index];

            if (!word.IsHidden())
            {
                word.Hide();
                hiddenCount++;
            }
        }
    }

    // check if words are hidden

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

    // Get the scripture as a string and display

    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText() + "\n";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return scriptureText.Trim();
    }
}


