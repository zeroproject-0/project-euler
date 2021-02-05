using System;

namespace projecteuler
{
  public class Resources
  {
    public Resources(){}

    public int invertNumber(int n){
      int x, res = 0;
      while(n > 0){
        x = n % 10;
        n = n / 10;
        res = res * 10 + x;
      }
      return res;
    }

    public int primeNumber(int n){
      int result = 0, i=1;
      while (n > 1)
      {
        if (n % i == 0)
        {
          result = i;
          n /= i;
        }
        i++;
      }
      return result;
    }

    public string[] titles = new string[]
    {
      "Exit",
      "Multiples of 3 and 5",
      "Even Fibonacci numbers",
      "Largest prime factor",
      "Largest palindrome product",
      "Smallest multiple",
      "Sum square difference"
    };
    
    public static dynamic answer { get; set; }

  }
}