using System;

namespace OOP
{
  public class Dog : Mammal, ILog
  {
    public string Name;
    public override void Sleep(int hours)
    {
      string s = $"{Name} the dog is {Age} years old, has {NumberOfLegs} legs and sleeps {hours} hours/day.";
      Console.WriteLine(s);
    }
    public override void SayHi()
    {
      base.SayHi();
      Console.WriteLine("Dog says hi.");
    }
    public void Log(string message) => Console.WriteLine(message);
  }
}
