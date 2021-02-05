using System;
using System.Collections.Generic;
using System.Linq;

namespace projecteuler
{
  public class Methods
  {
    private Resources resources;
    public Methods()
    {
      resources = new Resources();
    }
    public void problem1(int n){
      int result = 0;
        for (int i = 0; i < n; i++)
        {
          if (i % 3 == 0 || i % 5 == 0)
          {
            result += i; 
          }
        }
      Resources.answer = result;
    }
    public void problem2(int n){
      uint x = 1, y = 1, z = 0, result = 0;
      while (x < n)
      {
        if (x % 2 == 0) result += x;
        x = y;
        y = z;
        z = x+y;
      }
      Resources.answer = result;
    }
    public void problem3(ulong num){
      ulong i = 2, n = num, result = 0;
      while (n > 1)
      {
        if (n % i == 0)
        {
          result = i;
          n /= i;
        }
        i++;
      }
      Resources.answer = result;
    }
    public void problem4(int n){
      int x=n, y, z, result = 0;
      while (x >= 100)
      {
        y = n;
        while (y >= x)
        {
          z = x*y;
          if(z <= result) break;
          if (resources.invertNumber(z) == z) result = z;
          y--;
        }
        x--;
      }
      Resources.answer = result;
    }
    public void problem5(int n){
      int i = 2520, f = 0;
      int[] primes = new int[]{11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
      while(true)
      {
        foreach (int prime in primes)
        {
          if (i % prime == 0) f += 2;
        }
        if (f == n) break;
        f = 0;
        i += 2520;
      }
      Resources.answer = i;      
    }
    public void problem6(int n){
      double sum = Math.Pow(n * (n + 1) / 2, 2);
      double sumPow = (2 * n + 1) * (n + 1) * n / 6;
      Resources.answer = Math.Abs(sum - sumPow);
    }
  }
}