using System;
using static System.Console;

namespace projecteuler
{
  class Menu
  {
    string prompt;
    string[] options;
    int selectedIndex;

    ConsoleColor cc1;
    ConsoleColor cc2;

    public Menu(string prompt, string[] options, ConsoleColor cc1, ConsoleColor cc2)
    {
      this.prompt = prompt;
      this.options = options;
      this.cc1 = cc1;
      this.cc2 = cc2;
      selectedIndex = 0;
    }

    private void DisplayOptions()
    {
      ForegroundColor = cc2;
      WriteLine(prompt);
      for (int i = 0; i < options.Length; i++)
      {
        string currentOption = options[i];
        string prefix;

        if (i == selectedIndex)
        {
          prefix = "->";
          ForegroundColor = cc1;
          BackgroundColor = cc2;
        }
        else
        {
          prefix = "  ";
          ForegroundColor = cc2;
          BackgroundColor = ConsoleColor.Black;
        }
        WriteLine($"{prefix} {i}) {currentOption}");
      }
      ResetColor();
    }

    public int RunMenu()
    {
      ConsoleKey keyPressed;
      do
      {
        Clear();
        DisplayOptions();
        ConsoleKeyInfo keyInfo = ReadKey(true);
        keyPressed = keyInfo.Key;

        if (keyPressed == ConsoleKey.UpArrow)
        {
          selectedIndex--;
          if (selectedIndex == -1) selectedIndex = options.Length - 1;
        }
        else if (keyPressed == ConsoleKey.DownArrow)
        {
          selectedIndex++;
          if (selectedIndex == options.Length) selectedIndex = 0;
        }
      } while (keyPressed != ConsoleKey.Enter);
      return selectedIndex;
    }
  }
}