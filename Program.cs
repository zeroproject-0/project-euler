using System;

namespace projecteuler
{
  class Program
  {
    static void Main(string[] args)
    {
      int option = -1;
      Resources resources = new Resources();
      Problems problems = new Problems();
      do{
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Clear();

        int i = 0;
        Console.WriteLine("\nPROJECT EULER\n");
        foreach (var title in resources.titles)
        {
          Console.WriteLine($"{i}) {title}");
          i++;
        }

        try
        {
          option = int.Parse(Console.ReadLine());
          if(option == 0) break;
          Console.Clear();
        }
        catch (System.Exception) {Console.Clear();}

        if(option > 0)
        {
          problems.showProblems(option);
          Console.WriteLine($"The Answer for problem \"{resources.titles[option]}\" is:");
          Console.WriteLine($"\n{Resources.answer}\n");
        }
        else 
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Enter a number from 0 to 10");
        }

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
      }while(option != 0);
      Console.Clear();
    }    
  }
}
