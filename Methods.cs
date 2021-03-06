using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace projecteuler
{
  public static class Methods
  {
    public static void problem1(int n)
    {
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
    public static void problem2(int n)
    {
      Console.WriteLine("Esto es una prueba");
      uint x = 1, y = 1, z = 0, result = 0;
      while (x < n)
      {
        if (x % 2 == 0) result += x;
        x = y;
        y = z;
        z = x + y;
      }
      Resources.answer = result;
    }
    public static void problem3(ulong num)
    {
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
    public static void problem4(int n)
    {
      int x = n, y, z, result = 0;
      while (x >= 100)
      {
        y = n;
        while (y >= x)
        {
          z = x * y;
          if (z <= result) break;
          if (Resources.invertNumber(z) == z) result = z;
          y--;
        }
        x--;
      }
      Resources.answer = result;
    }
    public static void problem5(int n)
    {
      int i = 2520, f = 0;
      int[] primes = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
      while (true)
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
    public static void problem6(int n)
    {
      double sum = Math.Pow(n * (n + 1) / 2, 2);
      double sumPow = (2 * n + 1) * (n + 1) * n / 6;
      Resources.answer = Math.Abs(sum - sumPow);
    }
    public static void problem7(int n)
    {
      int i = 3, prime = 1;
      if (n == 1) i = 2;
      else
      {
        while (prime != n)
        {
          if (Resources.isPrime(i)) prime++;
          i += 2;
        }
      }
      Resources.answer = i;
    }
    public static void problem8(string text, int n)
    {
      List<ulong> numbers = new List<ulong>();
      ulong number;
      string numbersText;
      for (int i = 0; i + n <= text.Length; i++)
      {
        number = 1;

        if (i == 0 && n % 2 != 0) numbersText = text.Substring(i, n - 1);
        else numbersText = text.Substring(i, n);

        if (numbersText.Contains("0")) continue;

        for (int j = 0; j < numbersText.Length; j++)
        {
          number *= ulong.Parse(numbersText.Substring(j, 1));
        }
        numbers.Add(number);
      }

      Resources.answer = numbers.Max();
    }

    public static void problem9(int n)
    {
      int a = 0, b = 0, c = 0;
      double result = 0;
      bool f = false;

      for (c = 1; c <= n; c++)
      {
        for (b = 0; b <= n / 2; b++)
        {
          for (a = 1; a <= n / 3; a++)
          {
            if (a * a + b * b == c * c && a + b + c == n && a < b && b < c)
            {
              result = a * b * c;
              f = true;
              break;
            }
          }
          if (f) break;
        }
        if (f) break;
      }

      Resources.answer = $"a = {a}, b = {b}, c = {c}, result = {result}";
    }
    public static void problem10(int n)
    {
      long result = 3;
      for (int i = 1; i <= n; i++)
      {
        if (Resources.isPrime(i))
        {
          result += i;
        }
      }

      Resources.answer = result;
    }

    public static void problem11(int[,] grid)
    {
      int max = -1;
      for (int y = 0; y < grid.GetLength(0); y++)
      {
        for (int x = 0; x < grid.GetLength(1); x++)
        {
          max = Math.Max(Resources.product4(x, y, 1, 0, 4, grid), max);
          max = Math.Max(Resources.product4(x, y, 0, 1, 4, grid), max);
          max = Math.Max(Resources.product4(x, y, 1, 1, 4, grid), max);
          max = Math.Max(Resources.product4(x, y, 1, -1, 4, grid), max);
        }
      }
      Resources.answer = Convert.ToInt32(max);
    }

    public static void problem12(ulong n)
    {
      ulong i = 1, triNumber = 0;

      do
      {
        triNumber = i * (i + 1) / 2;
        i++;
      } while (Resources.numberDivisors(triNumber) < n);

      Resources.answer = triNumber;
    }
    public static void problem13(String[] n)
    {
      BigInteger sum = new BigInteger();
      for (int i = 0; i < n.Length; i++)
      {
        sum += BigInteger.Parse(n[i]);
      }
      Resources.answer = Convert.ToString(sum).Substring(0, 10);
    }
  }
}