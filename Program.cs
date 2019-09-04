using System;

namespace CSharpTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output
            Console.WriteLine("Type in a name that contains L");

            // Input
            string name = Console.ReadLine();

            var nameContainsL = name.ToLower().Contains("l");

            // NOT
            while (!nameContainsL)
            {
                Console.WriteLine("The name does not contain L. Please try again");
                name = Console.ReadLine();
                nameContainsL = name.ToLower().Contains("l");
            }
            Console.WriteLine("You have typed a name that contains L");
            Console.WriteLine("Press any key to continue...");
        }
    }
}
