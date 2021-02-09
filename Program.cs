using System;
using System.Diagnostics;

namespace projecteuler
{
  class Program
  {
    static void Main(string[] args)
    {
      int option = -1;
      Resources resources = new Resources();
      Problems problems = new Problems();
      Stopwatch sw = new Stopwatch();
      do{
        Console.ForegroundColor = ConsoleColor.Green;
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
          Console.Write("\nEnter the exercise number => ");
          option = int.Parse(Console.ReadLine());
          if(option == 0) break;
          Console.Clear();
        }
        catch (System.Exception) {Console.Clear();}

        if(option > 0)
        {
          sw.Start();
          problems.showProblems(option);
          sw.Stop();
          Console.WriteLine($"The Answer for problem \"{resources.titles[option]}\" is:");
          Console.WriteLine($"\n{Resources.answer}\n");
        }
        else 
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Enter a number from 0 to 10");
        }

        Console.WriteLine($"Time elapsed: {sw.Elapsed.ToString("hh\\:mm\\:ss\\.fff")}");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
      }while(option != 0);
      Console.Clear();
    }    
  }
}
