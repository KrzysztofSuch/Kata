using KatasLab;
using NUnit.Framework;

namespace KatasTests
{
    [TestFixture()]
    public class CSharp6LabTests
    {
        [Test()]
        public void NewOperatorTest()
        {
            var p = new CSharp6Lab.Person {Name = "tom"};

            var a= p.Adress?.Street ?? "brak";


            Assert.IsTrue(a.Equals("brak"));

        }

        [Test()]
        public void NewOperatorTest2()
        {
            var p = new CSharp6Lab.Person {Name = "tom"};

            var a = p.Adress?.Street ??"nie można dodać throw exc :( ";

            Assert.IsTrue(a.Contains("nie można"));
            //throw new MyTestException("aaaa");


        }
    }
}