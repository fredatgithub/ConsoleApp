using System;

namespace ConsoleApp
{
  internal class Program
  {
    static void Main()
    {
      Action<string> Display = Console.WriteLine;
      Display("Hello World!");

      Display("press any key to exit");
      Console.ReadKey();
    }
  }
}
