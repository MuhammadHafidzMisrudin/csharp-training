using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class Console
    {

        // External class with additional functions.
        // Add function to request input data.
        public static string AskInputConsole(string question)
        {
            System.Console.WriteLine(question);
            return System.Console.ReadLine();
        }

        // Add function return input integer.
        static public int AskInputInteger(string question)
        {

            try
            {
                System.Console.WriteLine(question);
                return int.Parse(System.Console.ReadLine());
            }
            catch (Exception)
            {
                throw new FormatException("Input was not valid type such as number or integer.");
            }
        }
    }
}
