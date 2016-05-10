using NUnit.Framework;
using KatasLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasLab.Tests
{
    [TestFixture()]
    public class CSharp6LabTests
    {

        class MyTestException : Exception
        {
            public MyTestException(String message) : base(message)
            {
            }
        }

        [Test()]
        public void NewOperatorTest()
        {
            var p = new CSharp6Lab.Person();
            p.Name = "tom";

            var a= p.Adress?.Street ?? "brak";


            Assert.IsTrue(a.Equals("brak"));

        }

        [Test()]
        public void NewOperatorTest2()
        {
            var p = new CSharp6Lab.Person();
            p.Name = "tom";

            var a = p.Adress?.Street ??"nie można dodać throw exc :( ";

            //throw new MyTestException("aaaa");


        }
    }
}