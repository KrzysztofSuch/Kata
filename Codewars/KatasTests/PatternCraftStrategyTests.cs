using Katas;
using NUnit.Framework;

namespace KatasTests
{
    [TestFixture]
    public class PatternCraftStrategyTests
    {
        [Test]
        public void _0_WalkMove()
        {
            IUnit viking = new Viking();

            viking.Move();
            Assert.AreEqual(1, viking.Position);
            viking.Move();
            Assert.AreEqual(2, viking.Position);
        }

        [Test]
        public void _1_FlyMove()
        {
            IUnit viking = new Viking();
            viking.MoveBehavior = new Fly();

            viking.Move();
            Assert.AreEqual(10, viking.Position);
            viking.Move();
            Assert.AreEqual(20, viking.Position);
        }

        [Test]
        public void _2_MixMove()
        {
            IUnit viking = new Viking();

            viking.Move();
            Assert.AreEqual(1, viking.Position);

            viking.MoveBehavior = new Fly();
            viking.Move();
            Assert.AreEqual(11, viking.Position);
        }

        [Test]
        public void _3_MoveVrite()
        {
            IUnit v = new Vrite();

            Assert.AreEqual(0, v.Position);

            v.Move();

            Assert.AreEqual(10,v.Position);

        }

    }
}
