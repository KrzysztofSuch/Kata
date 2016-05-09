using NUnit.Framework;
using Descending_Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasTests
{



    [TestFixture]
    public class DescendingOrderKataTests
    {
        [Test]
        public void Test0()
        {
            Assert.AreEqual(0, DescendingOrderKata.DescendingOrder(0));
        }


        [Test]
        public void Test1()
        {
            Assert.AreEqual(654321, DescendingOrderKata.DescendingOrder(145263));
        }

    }
}