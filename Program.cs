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


class Program 
{    
    static void Main() 
    {
      Console.WriteLine("Write something");
      string input = Console.ReadLine();
      string formattedInput = $"{input} \n";
      File.AppendAllText("output.txt", formattedInput);
      string output = File.ReadAllText("output.txt");
      Console.WriteLine(output);
    }
}       