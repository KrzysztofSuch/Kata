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
    public class SomochodTests
    {
        [TestMethod()]
        public void licznikTest()
        {
            var samochodMock1 = new Mock<ISamochod>();
            samochodMock1.Setup(car => car.licznik()).Returns(5);




            var result = samochodMock1.Object.licznik();

            Assert.AreEqual(result, 5);


        }
    }
}