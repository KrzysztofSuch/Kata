using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoqTests.TestoweKlasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MoqTests.TestoweKlasy.Tests
{
    [TestClass()]
    public class SamochodDataReaderTests
    {
        [TestMethod()]
        public void getSamochodyTest()
        {
            var a = new SamochodDataReader();

            a.getSamochody();
        }
    }
}
