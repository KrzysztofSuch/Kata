using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

public class GapInPrimes
{
    public static long[] Gap(int g, long m, int n)
    {
        var allPrimes = AtkinPrimeNumbersGenerator.Primes(n);

        var smalRange = allPrimes.Where(a => m <= a
                                             && a <= n).ToList();

        for (var i = 1; i < smalRange.Count(); i++)
        {
            var actualGap = smalRange.ElementAt(i) - smalRange.ElementAt(i - 1);
            if (actualGap == g)
            {
                return new[] {smalRange.ElementAt(i - 1), smalRange.ElementAt(i)};
            }
        }


        return null;
    }
}

public class AtkinPrimeNumbersGenerator : IEnumerable<long>
{
    private readonly List<long> primes;
    private readonly long limit;

    public AtkinPrimeNumbersGenerator(long limit)
    {
        this.limit = limit;
        primes = new List<long>();
    }

    public IEnumerator<long> GetEnumerator()
    {
        if (!primes.Any())
            FindPrimes();

        foreach (var p in primes)
            yield return p;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private void FindPrimes()
    {
        var isPrime = new bool[limit + 1];
        var sqrt = Math.Sqrt(limit);

        for (long x = 1; x <= sqrt; x++)
            for (long y = 1; y <= sqrt; y++)
            {
                var n = 4*x*x + y*y;
                if (n <= limit && (n%12 == 1 || n%12 == 5))
                    isPrime[n] ^= true;

                n = 3*x*x + y*y;
                if (n <= limit && n%12 == 7)
                    isPrime[n] ^= true;

                n = 3*x*x - y*y;
                if (x > y && n <= limit && n%12 == 11)
                    isPrime[n] ^= true;
            }

        for (long n = 5; n <= sqrt; n++)
            if (isPrime[n])
            {
                var s = n*n;
                for (long k = s; k <= limit; k += s)
                    isPrime[k] = false;
            }

        primes.Add(2);
        primes.Add(3);
        for (long n = 5; n <= limit; n += 2)
            if (isPrime[n])
                primes.Add(n);
    }
    public static IEnumerable<long> PrimesOld(int bound)
    {
        if (bound < 2) yield break;
        //The first prime number is 2
        yield return 2;

        BitArray composite = new BitArray((bound - 1) / 2);
        int limit = ((int)(Math.Sqrt(bound)) - 1) / 2;
        for (int i = 0; i < limit; i++)
        {
            if (composite[i]) continue;
            //The first number not crossed out is prime
            int prime = 2 * i + 3;
            yield return prime;
            //cross out all multiples of this prime, starting at the prime squared
            for (int j = (prime * prime - 2) >> 1; j < composite.Count; j += prime)
            {
                composite[j] = true;
            }
        }
        //The remaining numbers not crossed out are also prime
        for (int i = limit; i < composite.Count; i++)
        {
            if (!composite[i]) yield return 2 * i + 3;
        }
    }

    public static IEnumerable<long> Primes(long bound)
    {
        if (bound < 2) yield break;
        //The first prime number is 2
        yield return 2;

        var composite = new List<bool>();

        for (int i = 0; i < ((bound - 1)/2); i++)
        {
            composite.Add(false);
        }

        int limit = ((int)(Math.Sqrt(bound)) - 1) / 2;
        for (int i = 0; i < limit; i++)
        {
            if (composite[i]) continue;
            //The first number not crossed out is prime
            int prime = 2 * i + 3;
            yield return prime;
            //cross out all multiples of this prime, starting at the prime squared
            for (int j = (prime * prime - 2) >> 1; j < composite.Count; j += prime)
            {
                composite[j] = true;
            }
        }
        //The remaining numbers not crossed out are also prime
        for (int i = limit; i < composite.Count; i++)
        {
            if (!composite[i]) yield return 2 * i + 3;
        }
    }
}



