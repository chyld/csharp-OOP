using System;

namespace OOP
{
  public abstract class Mammal : Animal
  {
    public int NumberOfLegs;
    public override void SayHi() => Console.WriteLine("Mammal says hi.");
  }
}
