// See https://aka.ms/new-console-template for more information
using System;
    class Program
    {
        static void Main()
        {
        //writing and reading from console c# is case sensitive
            Console.WriteLine("Please what is your first name? ");
             string fsom = Console.ReadLine();

        Console.WriteLine("Please what is your surname? ");
        string surn = Console.ReadLine();
        // by concatenation: Console.WriteLine("hello " + som);
            Console.WriteLine("hello {0}, {1}", fsom, surn);
    }
    }


