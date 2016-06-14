using NUnit.Framework;
using Katas.PatternCraft.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.PatternCraft.Adapter.Tests
{
    [TestFixture()]
    public class MarioTests
    {
        [Test]
        public void _0_MarioAdapter_Can_Attack()
        {
            var marioAdapter = new MarioAdapter(new Mario());
            var target = new Target { Health = 33 };

            marioAdapter.Attack(target);

            Assert.AreEqual(30, target.Health);
        }
    }
}