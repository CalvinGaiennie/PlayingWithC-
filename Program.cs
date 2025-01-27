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
        Console.WriteLine("Do you choose A or B?");
        string choice = Console.ReadLine();
        string choiceUpper = choice.ToUpper();

        Console.WriteLine("what is your name?");
        string name = Console.ReadLine();
        
        if ( choiceUpper == "A" || choiceUpper == "B" )
        {
            Console.WriteLine(choiceUpper);
        }
        else 
        {
            Console.WriteLine("invalid input. Your answer should be 'A' or 'B'");
        }
        Console.WriteLine("How old are you?");
        string ageInput = Console.ReadLine();
        //string interpolation
        Console.WriteLine($"You are {ageInput} years old");
        DateTime now = DateTime.Now;

        int.TryParse(ageInput, out int age);

        string[] numbersAsWords = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "twenty-one", "twenty-two", "twenty-three", "twenty-four", "twenty-five", "twenty-six", "twenty-seven", "twenty-eight", "twenty-nine", "thirty", "thirty-one", "thirty-two", "thirty-three", "thirty-four", "thirty-five", "thirty-six", "thirty-seven", "thirty-eight", "thirty-nine", "forty", "forty-one", "forty-two", "forty-three", "forty-four", "forty-five", "forty-six", "forty-seven", "forty-eight", "forty-nine", "fifty", "fifty-one", "fifty-two", "fifty-three", "fifty-four", "fifty-five", "fifty-six", "fifty-seven", "fifty-eight", "fifty-nine", "sixty", "sixty-one", "sixty-two", "sixty-three", "sixty-four", "sixty-five", "sixty-six", "sixty-seven", "sixty-eight", "sixty-nine", "seventy", "seventy-one", "seventy-two", "seventy-three", "seventy-four", "seventy-five", "seventy-six", "seventy-seven", "seventy-eight", "seventy-nine", "eighty", "eighty-one", "eighty-two", "eighty-three", "eighty-four", "eighty-five", "eighty-six", "eighty-seven", "eighty-eight", "eighty-nine", "ninety", "ninety-one", "ninety-two", "ninety-three", "ninety-four", "ninety-five", "ninety-six", "ninety-seven", "ninety-eight", "ninety-nine", "one hundred"];
        
        for (int i = age; i >= 0; i--)
        {
            int year = now.Year - i; 
            Console.WriteLine($"You were {numbersAsWords[age - i]} years old in {year}");
        }
        Console.WriteLine(age > 18 ? "You are an adult" : "You are a minor");
        var userData = new {
            Name = name,
            Age = age,
            Year = now.Year
        };
        string jsonString = System.Text.Json.JsonSerializer.Serialize(userData);
        File.WriteAllText("userInfo.txt", jsonString);
    }
}