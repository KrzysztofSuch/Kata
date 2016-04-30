using NUnit.Framework;
using Descending_Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[TestFixture]
public class Tests
{
    [Test]
    public void Test0()
    {
        Assert.AreEqual(0, Kata.DescendingOrder(0));
    }


    [Test]
    public void Test1()
    {
        Assert.AreEqual(654321, Kata.DescendingOrder(145263));
    }
}