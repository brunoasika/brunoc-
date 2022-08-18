/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); */

// - single line comments
/* - multiline comments */


// switch statements
using System;
    
class Program
{
    static void Main()
    {
        
        int totalcoffee = 0;
        Start:
        Console.WriteLine("Coffee sizes avalilable: 1 - small, 2 - medium, 3 - large");
        Console.WriteLine("prices are: \nsmall - 1 dollar \t medium - 3 dollars \t large - 5 dollars ");
        Console.WriteLine("pick between 1, 2 and 3");
        int usernum = int.Parse(Console.ReadLine());

        switch(usernum)
        {
            case 1:
                totalcoffee += 1;
                Console.WriteLine("that will be 1 dollar");
                break;
            case 2:
                totalcoffee += 3;
                Console.WriteLine("that will be 3 dollars");
                break;
            case 3:
                totalcoffee += 5;
                Console.WriteLine("that will be 5 dollars");
                break;
            default:
                Console.WriteLine("your choice is invalid");
                goto Start;
        }
        Run:
        Console.WriteLine("do you want another coffee - yes or no?");
        string userchoice = Console.ReadLine();

        switch (userchoice.ToLower())
        {
            case "yes":
                goto Start;
            case "no":
                break;
            default:
                Console.WriteLine("your choice is invalid");
                goto Run;

        }
        Console.WriteLine("your total is " + totalcoffee + " dollars");
    }
}
