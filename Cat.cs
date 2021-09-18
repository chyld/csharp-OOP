using System;

namespace OOP
{
  public class Cat : Mammal, ILog
  {
    public override void Sleep(int hours)
    {
      string s = $"This cat is {Age} years old, has {NumberOfLegs} legs and sleeps {hours} hours/day.";
      Console.WriteLine(s);
    }
    public override void SayHi() => Console.WriteLine("Cat says hi.");
    public void Log(string message) => Console.WriteLine(message);
  }
}
