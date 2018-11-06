using System;

namespace studentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students?");
            var numOfStudents = int.Parse(Console.ReadLine());
            Console.WriteLine(numOfStudents);

            var studentNamesArray = new string[numOfStudents];
            // Console.WriteLine(studentNamesArray);

            var studentGradesArray =  new int[numOfStudents];
            // Console.WriteLine(studentGradesArray);

            var studentName = "";
            var studentGrade = 0;
            for (int i=0; i<numOfStudents; i++) {
              Console.WriteLine("Student Name: ");
              studentName = Console.ReadLine();

              studentNamesArray[i] = studentName;

              Console.WriteLine("Student Grade: ");
              studentGrade = int.Parse(Console.ReadLine());

              studentGradesArray[i] = studentGrade;
            }

            Console.WriteLine("\n");
            for (int j=0; j<numOfStudents; j++) {
              Console.WriteLine("Name: " + studentNamesArray[j]);
              Console.WriteLine("Grade: " + studentGradesArray[j]);
              Console.WriteLine("\n");
            }
        }
    }
}
