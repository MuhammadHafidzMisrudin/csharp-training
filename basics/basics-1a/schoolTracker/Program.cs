using System;

namespace schoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class?");
            var studentCount = int.Parse(Console.ReadLine());

            // Initialise and specify the sizes of Arrays.
            var studentNames = new string[studentCount];
            var studentGrades = new int[studentCount];

            // Store and insert data for both Arrays.
            for (int i=0; i<studentCount; i++) {
              Console.WriteLine("Student Name: ");
              studentNames[i] = Console.ReadLine();

              Console.WriteLine("Student Grade: ");
              studentGrades[i] = int.Parse(Console.ReadLine());
            }

            // Display output of student details.
            for (int i=0; i<studentCount; i++) {
              Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }
        }
    }
}
