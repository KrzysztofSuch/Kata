using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqTests.TestoweKlasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqTests.TestoweKlasy.Tests
{
    [TestClass()]
    public class SamochodTests
    {
        [TestMethod()]
        public void getNazwaTest()
        {
            var mock = new Mock<Samochod>();
            mock.Setup(car => car.getNazwa()).Returns("Fake nazwa");

            Assert.AreEqual("Fake nazwa", mock.Object.getNazwa());

        }
    }
}