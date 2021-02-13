using System;

namespace projecteuler
{
  public class Problems
  {
    private Methods methods;
    public Problems()
    {
      methods = new Methods();
    }

    public void showProblems(int o){
      Console.ForegroundColor = ConsoleColor.Cyan;

      switch(o)
      {
        case 1:
          methods.problem1(1000);
        break;
        case 2:
          methods.problem2(4000000);
        break;
        case 3:
          methods.problem3(600851475143);
        break;
        case 4:
          methods.problem4(999);
        break;
        case 5:
          methods.problem5(20);
        break;
        case 6:
          methods.problem6(100);
        break;
        case 7:
          methods.problem7(10001);
        break;
        case 8:
          methods.problem8(Resources.problem8, 13);
        break;
        case 9:
          methods.problem9(1000);
        break;
        case 10:
          methods.problem10(2000000);
        break;
        // TODO Put case 11
        case 12:
          methods.problem12(500);
        break;
        case 13:
          methods.problem13(Resources.problem13());
        break;
      }
    }
  }
}