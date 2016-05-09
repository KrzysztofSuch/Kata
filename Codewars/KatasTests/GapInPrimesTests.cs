using NUnit.Framework;
using Katas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasTests
{
    [TestFixture]
    public static class GapInPrimesTests
    {

        [Test]
        public static void GapInPrimesTests_test1()
        {
            Assert.AreEqual(new long[] { 101, 103 }, GapInPrimes.Gap(2, 100, 110));
            Assert.AreEqual(new long[] { 103, 107 }, GapInPrimes.Gap(4, 100, 110));
            Assert.AreEqual(null, GapInPrimes.Gap(6, 100, 110));
            Assert.AreEqual(new long[] { 359, 367 }, GapInPrimes.Gap(8, 300, 400));
            Assert.AreEqual(new long[] { 337, 347 }, GapInPrimes.Gap(10, 300, 400));
        }

        [Test]
        public static void GapInPrimesTests_test2()
        {
            var t = AtkinPrimeNumbersGenerator.PrimesOld(1000000);
            var tt = AtkinPrimeNumbersGenerator.Primes(1000000L);
            //var tt =  new AtkinPrimeNumbersGenerator(1000000000);

            Assert.AreEqual(tt.Count(), t.Count());
        }                               
    }
}