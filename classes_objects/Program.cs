using System;

namespace StaticMembers
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Forest.ForestsCreated);
      Forest f1 = new Forest("Palmera", "Trópicos");
      Forest f2 = new Forest("Pino", "Taiga");
      Console.WriteLine(Forest.ForestsCreated);
    }
  }
}
