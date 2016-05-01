using Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasTests
{
    [TestFixture]
    public class DigitalRootsTests
    {
        private DigitalRoots num;

        [SetUp]
        public void SetUp()
        {
            num = new DigitalRoots();
        }

        [TearDown]
        public void TearDown()
        {
            num = null;
        }

        [Test]
        public void DigitalRootsTests_BasicTest()
        {
            Assert.AreEqual(7, num.DigitalRoot(16));
        }

        [Test]
        public void DigitalRootsTests_BasicTest2()
        {
            Assert.AreEqual(6, num.DigitalRoot(942));
        }

        [Test]
        public void DigitalRootsTests_BasicTest3()
        {
            Assert.AreEqual(6, num.DigitalRoot(132189));
            Assert.AreEqual(2, num.DigitalRoot(493193));
            
        }

        

    }
}
