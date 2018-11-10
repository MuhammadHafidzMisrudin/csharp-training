using System;
using System.Collections.Generic;

namespace schoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
          // Uncomment this for test.
          // Console.WriteLine("How many students in your class?");
          // var studentCount = int.Parse(Console.ReadLine());

          // Initialise and specify the sizes of Arrays.
          // var studentNames = new string[studentCount];
          // var studentGrades = new int[studentCount];

          // Initialise dynamic lists collection.
          var studentNames = new List<string>();
          var studentGrades = new List<int>();

          Console.WriteLine("Capacity studentNames: {0}", studentNames.Capacity);
          Console.WriteLine("Capacity studentGrades: {0}", studentGrades.Capacity);

          // Set a flag.
          var addElement = true;

          // Use while loop for dynamic data insertion.
          while (addElement) {
            Console.WriteLine();
            Console.WriteLine("Student Name: ");
            studentNames.Add(Console.ReadLine());

            Console.WriteLine("Student Grade: ");
            studentGrades.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Add another? y/n: ");
            var inputDetails = Console.ReadLine();

            if (inputDetails != "y" && inputDetails != "Y") {
              addElement = false;
            }
          } // end while loop.

          Console.WriteLine();
          Console.WriteLine("Capacity studentNames: {0}", studentNames.Capacity);
          Console.WriteLine("Total studentNames: {0}", studentNames.Count);
          Console.WriteLine("Capacity studentGrades: {0}", studentGrades.Capacity);
          Console.WriteLine("Total studentNames: {0}", studentGrades.Count);
          Console.WriteLine();

          // Uncomment this for test.
          // Store and insert data for both Arrays.
          // for (int i=0; i<studentCount; i++) {
          //   Console.WriteLine("Student Name: ");
          //   studentNames[i] = Console.ReadLine();
          //
          //   Console.WriteLine("Student Grade: ");
          //   studentGrades[i] = int.Parse(Console.ReadLine());
          // }

          // Display output of student details.
          for (int i=0; i<studentNames.Count; i++) {
            Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
          }
        }
    }

    class Student
    {
      public string Name;
      public int Grade;
      public string Birthday;
      public string Address;
      public int Phone;
    }
}
