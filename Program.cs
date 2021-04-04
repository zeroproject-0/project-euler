using System;
using System.Diagnostics;

namespace projecteuler
{
  class Program
  {
    static void Main(string[] args)
    {
      // TODO Agregar opción para ir a la página principal
      // string target = "https://www.projecteuler.net";
      // ProcessStartInfo psi = new ProcessStartInfo();
      // psi.UseShellExecute = true;
      // psi.FileName = target;
      // Process.Start(psi);

      Console.Title = "Project Euler By ZeroProject";
      do
      {
        Problems.RunMainMenu();
      } while (true);
    }
  }
}
