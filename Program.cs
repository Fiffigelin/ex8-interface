using System;

internal class Program
{

  public class Program1 : IProgram, IProgram1
  {
    public void Only()
    {
      Console.WriteLine("Denna funktion har inte Program2, na na na na na!");
    }

    // public void Run()
    // {
    //   Console.WriteLine("Nu kör vi program 1");
    // }
    public void Start()
    {
      Console.WriteLine("Nu kör vi program 1");
    }
  }
  public class Program2 : IProgram
  {
    // public void Go()
    // {
    //   Console.WriteLine("Nu kör vi program 2");
    // }
    public void Start()
    {
      Console.WriteLine("Nu kör vi program 2");
    }
  }

  public interface IProgram
  {
    public void Start();
  }
  public interface IProgram1
  {
    public void Only();
  }
  private static void Main(string[] args)
  {
    Program1 program1 = new();
    Program2 program2 = new();

    // program1.Run();
    // program2.Go();

    program1.Start();
    program2.Start();
  }
}