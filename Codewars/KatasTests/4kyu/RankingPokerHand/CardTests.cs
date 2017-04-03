using Katas._4kyu.RankingPokerHand;
using NUnit.Framework;

namespace KatasTests._4kyu.RankingPokerHand {
    [TestFixture()]
    public class CardTests {
        [Test()]
        public void CardTest() {
            var a = new Card("2D");

            Assert.AreEqual('D', a.CardColor);
            Assert.AreEqual(2, a.power);

        }
    }
}