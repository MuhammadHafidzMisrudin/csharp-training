using System;

namespace mcqQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhats your name?");
            var userName = Console.ReadLine();

            if (userName == "") {
              PrintErrorOutput();
              userName = Console.ReadLine();
            }

            Console.WriteLine("\nHow old are you?");
            var userAge =  Console.ReadLine();

            if (userAge == "") {
              PrintErrorOutput();
              userAge = Console.ReadLine();
            }

            Console.WriteLine("\nWhat month were your born in?");
            var userMonthDOB = Console.ReadLine();

            if (userMonthDOB == "") {
              PrintErrorOutput();
              userMonthDOB = Console.ReadLine();
            }

            Console.WriteLine("\nName: " + userName);
            Console.WriteLine("Age: " + userAge);
            Console.WriteLine("Month DOB: " + userMonthDOB);

            if (userMonthDOB == "march" || userMonthDOB == "March") {
              Console.WriteLine("Zodiac Sign: Aries");
            }
            else if (userMonthDOB == "april" || userMonthDOB == "April") {
              Console.WriteLine("Zodiac Sign: Taurus");
            }
            else if (userMonthDOB == "may" || userMonthDOB == "May") {
              Console.WriteLine("Zodiac Sign: Gemini");
            }
        }

        static void PrintErrorOutput() {
          Console.WriteLine("Error! Valid input required. Try again: ");
        }
    }
}
