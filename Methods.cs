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
    public void problem7(int n){
      int i = 3, prime = 1;
      if (n == 1) i = 2;
      else
      {
        while(prime != n)
        {
          if (resources.isPrime(i)) prime++;
          i += 2;
        }
      }
      Resources.answer = i;
    }
    public void problem8(string text, int n){
      List<ulong> numbers = new List<ulong>();
      ulong number;
      string numbersText;
      for (int i = 0; i + n <= text.Length; i++)
      {
        number = 1;
        
        if (i == 0 && n % 2 != 0) numbersText = text.Substring(i,n - 1);
        else numbersText = text.Substring(i,n);

        if (numbersText.Contains("0")) continue;

        for (int j = 0; j < numbersText.Length; j++)
        {
          number *= ulong.Parse(numbersText.Substring(j,1));
        } 
        numbers.Add(number);
      }

      Resources.answer = numbers.Max();
    }

    public void problem9(int n){ 
      int a=0, b=0, c=0;
      double result = 0;
      bool f =false;

      for (c = 1; c <= n ; c++)
      {
        for (b = 0; b <= n/2; b++)
        {
          for (a = 1; a <= n/3; a++)
          {
            if (a*a + b*b == c*c && a+b+c==n && a<b && b<c)
            {
              result = a*b*c;
              f=true;
              break;
            }
          }
          if(f) break;
        }
        if(f) break;
      }

      Resources.answer = $"a = {a}, b = {b}, c = {c}, result = {result}";
    }
  }
}