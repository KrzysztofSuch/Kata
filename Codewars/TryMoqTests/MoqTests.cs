using System;
using System.Collections.Generic;
using Moq;
using Shouldly;
using Xunit;

namespace TryMoqTests
{
    public class MoqTests
    {
        [Fact]
        public void MoqBasicTests()
        {
            var customerMock = new Mock<ICustomer>();
            customerMock.Setup(x => x.Age).Returns(16);
            customerMock.Setup(x => x.DoShopinng(It.IsAny<int>())).Returns(It.IsAny<int>());
            customerMock.Setup(x => x.Seller.Name).Returns("Tom");

            //            customerMock.Raise(m => m.FooEvent += null, new FooEventArgs(5));
//            5.ShouldBe(3);
            "ss".ShouldBe("ss");



        }

        [Fact]
        public void ShouldNotBeOneOf()
        {
            var apu = new Person() {Name = "Apu"};
            var homer = new Person() {Name = "Homer"};
            var skinner = new Person() {Name = "Skinner"};
            var barney = new Person() {Name = "Barney"};
            var wiggum = new Person() {Name = "Wiggum"};
            var theBeSharps = new List<Person>() {apu, homer, skinner, barney};

            wiggum.ShouldNotBeOneOf(theBeSharps.ToArray());
        }

    }

    public class Person
    {
        public string Name { get; set; }
    }

    public class FooEventArgs : EventArgs
    {
        public FooEventArgs(int i)
        {
            //throw new NotImplementedException();
        }
    }
}