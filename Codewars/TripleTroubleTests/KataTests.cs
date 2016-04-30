using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleTroubleTests
{
    [TestFixture]
    class KataTests
    {
        [Test]
        [TestCase(451999277, 41177722899)]
        [TestCase(666789, 12345667)]
        [TestCase(10560002, 100)]
        public static void Expected_1(long s1, long s2)
        {
            var result = Kata.TripleDouble(s1, s2);
            Assert.AreEqual(1, result);
        }


        [TestCase(1222345, 12345)]
        [TestCase(12345, 12345)]
        public static void Expected_0(long s1, long s2)
        {
            var result = Kata.TripleDouble(s1, s2);
            Assert.AreEqual(0, result);
        }

    }
}
