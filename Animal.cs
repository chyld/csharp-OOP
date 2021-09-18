using System;

namespace OOP
{
  public abstract class Animal
  {
    public int Age;
    public abstract void Sleep(int hours);
    public virtual void SayHi() => Console.WriteLine("Animal says hi.");
  }
}
