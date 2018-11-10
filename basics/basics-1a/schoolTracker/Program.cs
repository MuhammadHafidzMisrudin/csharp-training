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

          // Initialise dynamic lists collection with types (string, int, Student).
          var studentNames = new List<string>();
          var studentGrades = new List<int>();
          var studentList = new List<Student>();

          // Console.WriteLine("Capacity studentNames: {0}", studentNames.Capacity);
          // Console.WriteLine("Capacity studentGrades: {0}", studentGrades.Capacity);
          Console.WriteLine("Capacity studentList: {0}", studentList.Capacity);


          // Set a flag.
          var addElement = true;

          // Use while loop for dynamic data insertion.
          while (addElement) {

            // Create a student object.
            var studentObject = new Student();

            Console.WriteLine();

            // Set propeties values.
            Console.WriteLine("Student Name: ");
            studentObject.Name = Console.ReadLine();
            // studentNames.Add(Console.ReadLine());

            Console.WriteLine("Student Grade: ");
            studentObject.Grade = int.Parse(Console.ReadLine());
            // studentGrades.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Student Birthday: ");
            studentObject.Birthday = Console.ReadLine();

            Console.WriteLine("Student Address: ");
            studentObject.Address = Console.ReadLine();

            Console.WriteLine("Student Phone: ");
            studentObject.Phone = int.Parse(Console.ReadLine());

            // Add new created student object (& details) to the student list.
            studentList.Add(studentObject);

            Console.WriteLine("Add another? y/n: ");
            var inputDetails = Console.ReadLine();

            if (inputDetails != "y" && inputDetails != "Y") {
              addElement = false;
            }
          } // end while loop.

          Console.WriteLine();
          // Console.WriteLine("Capacity studentNames: {0}", studentNames.Capacity);
          // Console.WriteLine("Total studentNames: {0}", studentNames.Count);
          // Console.WriteLine("Capacity studentGrades: {0}", studentGrades.Capacity);
          // Console.WriteLine("Total studentNames: {0}", studentGrades.Count);
          Console.WriteLine("Capacity studentList: {0}", studentList.Capacity);
          Console.WriteLine("Total studentList: {0}", studentList.Count);
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
          for (int i=0; i<studentList.Count; i++) {
            Console.WriteLine("List => {0}, Name: {1}, Grade: {2}, Birthday: {2}, Address: {3}, Phone: {4}", studentList[i],
                                                                                                             studentList[i].Name,
                                                                                                             studentList[i].Grade,
                                                                                                             studentList[i].Birthday,
                                                                                                             studentList[i].Address,
                                                                                                             studentList[i].Phone);
          }

          // Uncomment to use foreach.
          // foreach (var student in studentList) {
          //   Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
          // }
        }
    }

    class Student
    {
      // Implement Object-Oriented.

      public string Name;
      public int Grade;
      public string Birthday;
      public string Address;
      public int Phone;
    }
}
