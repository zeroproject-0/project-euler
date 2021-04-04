using System;
using System.Diagnostics;
using static System.Console;

namespace projecteuler
{
  public static class Problems
  {
    private static Stopwatch sw = new Stopwatch();
    private static void showProblems(int o)
    {
      switch (o)
      {
        case 0:
          exit();
          break;
        case 1:
          Methods.problem1(1000);
          break;
        case 2:
          Methods.problem2(4000000);
          break;
        case 3:
          Methods.problem3(600851475143);
          break;
        case 4:
          Methods.problem4(999);
          break;
        case 5:
          Methods.problem5(20);
          break;
        case 6:
          Methods.problem6(100);
          break;
        case 7:
          Methods.problem7(10001);
          break;
        case 8:
          Methods.problem8(Resources.problem8, 13);
          break;
        case 9:
          Methods.problem9(1000);
          break;
        case 10:
          Methods.problem10(2000000);
          break;
        case 11:
          Methods.problem11(Resources.problem11);
          break;
        case 12:
          Methods.problem12(500);
          break;
        case 13:
          Methods.problem13(Resources.problem13());
          break;
      }
    }

    public static void RunMainMenu()
    {
      string prompt = @"
$$$$$$$\                                                      $$\           $$$$$$$$\           $$\                     
$$  __$$\                                                     $$ |          $$  _____|          $$ |                    
$$ |  $$ | $$$$$$\   $$$$$$\        $$\  $$$$$$\   $$$$$$$\ $$$$$$\         $$ |      $$\   $$\ $$ | $$$$$$\   $$$$$$\  
$$$$$$$  |$$  __$$\ $$  __$$\       \__|$$  __$$\ $$  _____|\_$$  _|        $$$$$\    $$ |  $$ |$$ |$$  __$$\ $$  __$$\ 
$$  ____/ $$ |  \__|$$ /  $$ |      $$\ $$$$$$$$ |$$ /        $$ |          $$  __|   $$ |  $$ |$$ |$$$$$$$$ |$$ |  \__|
$$ |      $$ |      $$ |  $$ |      $$ |$$   ____|$$ |        $$ |$$\       $$ |      $$ |  $$ |$$ |$$   ____|$$ |      
$$ |      $$ |      \$$$$$$  |      $$ |\$$$$$$$\ \$$$$$$$\   \$$$$  |      $$$$$$$$\ \$$$$$$  |$$ |\$$$$$$$\ $$ |      
\__|      \__|       \______/       $$ | \_______| \_______|   \____/       \________| \______/ \__| \_______|\__|      
                              $$\   $$ |                                                                                
                              \$$$$$$  |                                                                                
                              \______/                                                                                 
'Project Euler exists to encourage, challenge, and develop the skills and enjoyment of anyone with an interest in the
                                  fascinating world of mathematics.'
(Use the arrow keys to select the problem)";

      string[] options = Resources.titles;
      Menu mainMenu = new Menu(prompt, options, ConsoleColor.Black, ConsoleColor.Cyan);
      int selectedIndex = mainMenu.RunMenu();
      sw.Start();
      showProblems(selectedIndex);
      sw.Stop();

      showResults(selectedIndex);
    }

    private static void showResults(int i)
    {
      Clear();
      ForegroundColor = ConsoleColor.Green;
      WriteLine($"The Answer for problem \"{Resources.titles[i]}\" is:");
      WriteLine($"\n{Resources.answer}\n");
      WriteLine($"Time elapsed: {sw.Elapsed.ToString("hh\\:mm\\:ss\\.fff")}");
      WriteLine("Press any key to continue");
      ReadKey();
    }

    private static void exit()
    {
      Clear();
      ForegroundColor = ConsoleColor.Yellow;
      WriteLine("Bye! :D \nPress any key to exit...");
      ReadKey();
      Environment.Exit(0);
    }
  }
}