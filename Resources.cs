using System;
using System.Collections.Generic;
using System.Linq;

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

    public bool isPrime(int n){
      if (n<2) return false;
      else if (n < 4) return true;
      else if (n % 2 == 0) return false;
      else if (n < 9) return true;
      else if (n % 3 == 0) return false;
      else
      {
        double r = Math.Floor(Math.Sqrt(n));
        int f = 5;
        while( f <= r){
          if(n % f == 0) return false;
          if(n % (f + 2) == 0) return false;
          f += 6;
        }
        return true;
      }
    }

    public ulong numberDivisors(ulong n){
      ulong result = 0;
      for (ulong i = 1; i <= Math.Floor(Math.Sqrt(n)); i++)
      {
        if (n % i == 0)
        {
          result++;
        }
      }

      return result*2;
    }

    public string[] titles = new string[]
    {
      "Exit",
      "Multiples of 3 and 5",
      "Even Fibonacci numbers",
      "Largest prime factor",
      "Largest palindrome product",
      "Smallest multiple",
      "Sum square difference",
      "10001st prime",
      "Largest product in a series",
      "Special Pythagorean triplet",
      "Summation of primes",
      "Largest product in a grid",
      "Highly divisible triangular number",
      "Large sum",
      "Longest Collatz sequence",
      "Lattice paths",
      "Power digit sum",
      "Number letter counts",
      "Maximum path sum I",
      "Counting Sundays",
      "Factorial digit sum"
    };
    
    public static dynamic answer { get; set; }
    public static String problem8 ="7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
  }
}