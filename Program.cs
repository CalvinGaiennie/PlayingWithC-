// See https://aka.ms/new-console-template for more information

//declaring variables
//If statements
//loops 
//logging
//string formatting
//collections (lists arrays dictionaries)
//methods and functions
//classes and objects
//Linq
// file operations like read and write


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
            Console.WriteLine("invalid input");
        }
}
}
