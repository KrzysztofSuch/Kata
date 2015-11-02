// <copyright file="SamochodTest.cs">Copyright ©  2015</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoqTests.TestoweKlasy;

namespace MoqTests.TestoweKlasy.Tests
{
    /// <summary>This class contains parameterized unit tests for Samochod</summary>
    [PexClass(typeof(Samochod))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class SamochodTest
    {
        /// <summary>Test stub for getNazwa()</summary>
        [PexMethod]
        public string getNazwaTest([PexAssumeUnderTest]Samochod target)
        {
            string result = target.getNazwa();
            return result;
            // TODO: add assertions to method SamochodTest.getNazwaTest(Samochod)
        }
    }
}
