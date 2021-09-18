using System;

namespace OOP
{
  class Program
  {
    static void Main(string[] args)
    {
      Dog d = new() { Age = 3, NumberOfLegs = 4, Name = "Fido" };
      Cat c = new() { Age = 4, NumberOfLegs = 4, };
      d.SayHi();
      d.Sleep(8);
      c.Sleep(9);

      var loggers = new ILog[] { d, c };
      foreach (var log in loggers) log.Log("Hello Animals");

      Console.WriteLine(d is Dog);
      Console.WriteLine(d is Mammal);
      Console.WriteLine(d is Animal);
      Console.WriteLine(d is ILog);
    }
  }
}
