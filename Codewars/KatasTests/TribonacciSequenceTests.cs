using NUnit.Framework;
using Katas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasTests
{
    [TestFixture()]
    public class TribonacciSequenceTests
    {
        private TribonacciSequence _variabonacci;

        [SetUp]
        public void SetUp()
        {
            _variabonacci = new TribonacciSequence();
        }

        [TearDown]
        public void TearDown()
        {
            _variabonacci = null;
        }

        [Test]
        public void TribonacciTest()
        {
            Assert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, _variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, _variabonacci.Tribonacci(new double[] { 0, 0, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, _variabonacci.Tribonacci(new double[] { 0, 1, 1 }, 10));
        }
    }
}