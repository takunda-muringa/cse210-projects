using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries { get; set; } = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        Entry newEntry = new Entry(prompt, response);
        Entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in Entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveJournal(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in Entries)
            {
                outputFile.WriteLine($"{entry.Date}~|~{entry.Prompt}~|~{entry.Response}");
            }
        }
    }

    public void LoadJournal(string fileName)
    {
        if (File.Exists(fileName))
        {
            Entries.Clear();
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                Entry loadedEntry = new Entry(prompt, response) { Date = date };
                Entries.Add(loadedEntry);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
