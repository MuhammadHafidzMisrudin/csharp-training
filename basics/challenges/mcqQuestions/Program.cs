using System;

namespace mcqQuestions
{

    // Implement Object Oriented.
    class DataHandler
    {

        // Initialise fields.
        public string userName;
        public int userAge;
        public string userMonthDOB;

        // Add function to output all field values.
        public void DisplayOutput()
        {
            Console.WriteLine("\nName: " + userName);
            Console.WriteLine("Age: " + userAge);
            Console.WriteLine("Month DOB: " + userMonthDOB);

            if (userMonthDOB == "march" || userMonthDOB == "March")
            {
                Console.WriteLine("Zodiac Sign: Aries");
            }
            else if (userMonthDOB == "april" || userMonthDOB == "April")
            {
                Console.WriteLine("Zodiac Sign: Taurus");
            }
            else if (userMonthDOB == "may" || userMonthDOB == "May")
            {
                Console.WriteLine("Zodiac Sign: Gemini");
            }
        }
    }

    class Program
    {

        // Declare the event.
        static public event Action Posted;

        static void Main(string[] args)
        {

            // Create a Stats system.
            // Instantiate a stats class.
            var stats = new Stats();
            stats.Start();

            // Instantiate a data object class.
            var dataObject = new DataHandler();

            Console.WriteLine("\nWhats your name?");
            // var userName = Console.ReadLine();
            // var userName = GetInputAnswer();
            dataObject.userName = GetInputAnswer();

            Console.WriteLine("\nHow old are you?");
            // var userAge =  Console.ReadLine();
            // var userAge = GetInputAnswer();
            dataObject.userAge = int.Parse(GetInputAnswer());

            Console.WriteLine("\nWhat month were your born in?");
            // var userMonthDOB = Console.ReadLine();
            // var userMonthDOB = GetInputAnswer();
            dataObject.userMonthDOB = GetInputAnswer();

            // Console.WriteLine("\nName: " + userName);
            // Console.WriteLine("Age: " + userAge);
            // Console.WriteLine("Month DOB: " + userMonthDOB);

            // Check if nothing has registered to the posted event, if the event is null.
            // Invoke the event.
            if (Posted != null)
            {
                Posted();
            }
            

            // Invoke DisplayOutput().
            dataObject.DisplayOutput();

            // if (userMonthDOB == "march" || userMonthDOB == "March") {
            //   Console.WriteLine("Zodiac Sign: Aries");
            // }
            // else if (userMonthDOB == "april" || userMonthDOB == "April") {
            //   Console.WriteLine("Zodiac Sign: Taurus");
            // }
            // else if (userMonthDOB == "may" || userMonthDOB == "May") {
            //   Console.WriteLine("Zodiac Sign: Gemini");
            // }

            Console.ReadKey();
        }

        static string GetInputAnswer()
        {

            // Get input answer.
            var answer = Console.ReadLine();

            // Check if the param is empty, get new input and return new value.
            if (answer == "")
            {
                Console.WriteLine("Error! Valid input required. Try again: ");
                return Console.ReadLine();
            }
            return answer;
        }
    }
}
