using System;
namespace SRA
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome! Type 'exit' to exit program");
      try
      {
        Core.Logic();
      }
      catch (Exception e) 
      {
        Console.WriteLine($"Unexpected error: {e}");
      }
    }
  }
}
