using System;

namespace fixedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new int[] {75, 45, 56, 87, 90, 100, 43, 76, 89, 99};

            // Using for loop.
            Console.WriteLine("\nUsing for loop.");
            for (int i=0; i<studentGrades.Length; i++) {
              Console.WriteLine(studentGrades[i]);
            }


            // Using foreach loop.
            Console.WriteLine("\nUsing foreach loop.");
            foreach (var studentGrade in studentGrades) {
              Console.WriteLine(studentGrade);
            }
        }
    }
}
