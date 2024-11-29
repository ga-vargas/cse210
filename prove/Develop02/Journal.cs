using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // Create a new entry in the Journal
    public void AddEntry(string prompt, string response)
    {
        _entries.Add(new Entry(prompt, response));
        Console.WriteLine("Entry Added Succesfully!");
    }

    // Method to display all the entries in the Journal

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal");
            return;
        }

        Console.WriteLine("Journal Entries:"); // in the case there are entries
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Save an entry
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToText());   // code to save the file
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                _entries.Add(Entry.FromText(line));
            }
            Console.WriteLine("Journal loaded Successfully");
        }

        else
        {
            Console.WriteLine("File not Found. Please try again");
        }
    }


}