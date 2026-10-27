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

  public class Extra : IExtra1, IExtra2
  {
    // när jag lägger till den med bara ett interface
    // public void Run()
    // {
    //   throw new NotImplementedException();
    // }

    // när jag lägger till med båda interfaces
    public void Run() // eller void IExtra1.Run()
    {
      Console.WriteLine("Denna returnerar ingenting!");
    }

    int IExtra2.Run()
    {
      Console.WriteLine("Denna returnerar 7!");
      return 7;
    }
  }

  public interface IProgram1
  {
    public void Only();
  }

  public interface IExtra1
  {
    public void Run();
  }
  public interface IExtra2
  {
    public int Run();
  }

  private static void Main(string[] args)
  {
    Program1 program1 = new();
    Program2 program2 = new();

    // program1.Run();
    // program2.Go();

    program1.Start();
    program2.Start();

    // https://www.c-sharpcorner.com/article/how-to-inherit-multiple-interfaces-having-same-method-name
    // varför skulle man vilja göra såhär?
    Extra extra = new();
    IExtra2 extra2 = new Extra();

    extra.Run();
    int i = extra2.Run();

    Console.WriteLine($"Int: {i}");
    // int j = extra.Run(); // cannot implicity convert type 'void' to 'int'


  }
}