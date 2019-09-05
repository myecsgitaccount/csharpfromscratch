﻿using System;

namespace CSharpTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output
            PrintLine("Type in a name that contains L");

            // Input
            string name = Console.ReadLine();

            var nameContainsL = name.ToLower().Contains("l");

            // NOT
            while (!nameContainsL)
            {
                PrintLine("The name does not contain L. Please try again");
                name = Console.ReadLine();
                nameContainsL = name.ToLower().Contains("l");
            }
            PrintLine("You have typed a name that contains L");
            Console.ReadLine();
        }

        // custom method to replace writeline
        static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }

        // custom method to readline
        static string ReadLine()
        {
            return Console.ReadLine(); 
        }
    }
}
