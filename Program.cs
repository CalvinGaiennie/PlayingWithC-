// See https://aka.ms/new-console-template for more information

//declaring variables
//loops 
//string formatting
//collections (lists arrays dictionaries)
//methods and functions
//classes and objects
//Linq
// file operations like read and write



// Here I am using
//if statments
// loggings
// for loop

using System;
using System.Text.Json.Nodes;

public class JournalEntry
{
    public string Date { get; set; }
    public string Input { get; set; }
}

class Program 
{    
    static void Main() 
    {
        try
        {
            List<JournalEntry> entries = new List<JournalEntry>();
            
            if (File.Exists("output.txt"))
            {
                string output = File.ReadAllText("output.txt");
                if (!string.IsNullOrEmpty(output))
                {
                    entries = System.Text.Json.JsonSerializer.Deserialize<List<JournalEntry>>(output);
                }
            }

            string date = DateTime.Today.ToString("MM/dd/yyyy"); 
            Console.WriteLine("Write something");
            string input = Console.ReadLine();
            JournalEntry currentEntry = new JournalEntry();
            currentEntry.Date = date;
            currentEntry.Input = input;
            entries.Add(currentEntry);
            string jsonString = System.Text.Json.JsonSerializer.Serialize(entries);
            File.WriteAllText("output.txt", jsonString);
            
            Console.WriteLine(jsonString);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}       