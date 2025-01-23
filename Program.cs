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
class Program 
{    
    static void Main() 
    {
        Console.WriteLine("Do you choose A or B?");
        string choice = Console.ReadLine();
        string choiceUpper = choice.ToUpper();

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

        for (int i = age; i >= 0; i--)
        {
            int year = now.Year - i; 
            Console.WriteLine($"You were {age - i} years old in {year}");
        }
}
}
