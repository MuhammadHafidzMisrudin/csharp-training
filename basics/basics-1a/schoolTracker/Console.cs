using System;
using System.Collections.Generic;
using System.Text;

namespace Util {
  class Console {
    public static string AskInputConsole(string question) {
      System.Console.WriteLine(question);
      return System.Console.ReadLine();
    }
  }
}
