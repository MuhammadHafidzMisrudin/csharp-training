using System;

namespace forLoops
{
    class Program
    {
        static void Main(string[] args)
        {
          var num = 1;
          while (num <= 10) {
            Console.WriteLine(num);
            num++;
          }

          for (int i=11; i<=20; i++) {
            Console.WriteLine(i);
          }
        }
    }
}
