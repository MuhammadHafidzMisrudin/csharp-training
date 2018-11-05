using System;

namespace loopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
          for (int a=1; a<=5; a++) {
            for (int i=1; i<=10; i++) {
              Console.WriteLine(i);
            }
            for (int j=10; j>=1; j--) {
              Console.WriteLine(j);
            }
          }
        }
    }
}
