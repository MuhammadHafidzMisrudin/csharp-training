using System;

namespace passCode
{
    class Program
    {
        static void Main(string[] args)
        {
          var code = "";
          while (code != "secret") {

            Console.WriteLine("What's the passcode?");
            code = Console.ReadLine();

            if (code != "secret") {
              Console.WriteLine("Error! Not Authenticated.");
            }
          } // end while loop
          Console.WriteLine("Authenticated.");
        }
    }
}
