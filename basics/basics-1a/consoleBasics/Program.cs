using System;

namespace consoleBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var customString = "Custom String";
            Console.WriteLine("Enter input:");
            var customStringInput = Console.ReadLine();
            Console.WriteLine("Hardcoded string: Hello World!");
            Console.WriteLine("Using var keyword: " + customString);
            Console.WriteLine("Using input for custom string: " + customStringInput);
        }
    }
}
