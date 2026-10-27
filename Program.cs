using System;
using System.Net.Http.Headers;

internal class Program
{

  public class Program1
  {
    public void Run()
    {
      Console.WriteLine("Nu kör vi program 1");
    }
  }
  public class Program2
  {
    public void Go()
    {
      Console.WriteLine("Nu kör vi program 2");
    }
  }
  private static void Main(string[] args)
  {
    Program1 program1 = new();
    Program2 program2 = new();

    program1.Run();
    program2.Go();
  }
}