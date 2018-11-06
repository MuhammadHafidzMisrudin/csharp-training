using System;

namespace switchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years of experience do you have?");

            var years = int.Parse(Console.ReadLine());

            if (years == 0) {
              Console.WriteLine("Inexperienced");
            } else if (years == 1) {
              Console.WriteLine("Junior");
            } else if (years == 2) {
              Console.WriteLine("Intermediate");
            } else if (years == 3) {
              Console.WriteLine("Advanced");
            } else  {
              Console.WriteLine("Senior");
            }
        }
    }
}
