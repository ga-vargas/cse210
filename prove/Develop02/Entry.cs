using System;

public class Entry
{

    // This is the entry information
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = prompt;
        _entryText = response;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine();
    }

    // To plain Text
    public string ToText()
    {
        return $"{_date}~|~{_promptText}~|~{_entryText}";
    }

    // Entry format
    public static Entry FromText(string text)
    {
        string[] parts = text.Split("~|~");
        return new Entry(parts[1], parts[2]) { _date = parts[0] };
    }
}