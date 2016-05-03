using NUnit.Framework;
using Katas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Tests
{
    [TestFixture()]
    public class Playing_on_a_chessboardTests
    {
        Random randomGenerator = new Random();

        [Test]
        public void Playing_on_a_chessboard_Test01()
        {
            Assert.AreEqual("[0]", Playing_on_a_chessboard.game(0));
        }
        [Test]
        public void Playing_on_a_chessboard_Test02()
        {
            Assert.AreEqual("[1, 2]", Playing_on_a_chessboard.game(1));
        }
        [Test]
        public void Playing_on_a_chessboard_Test03()
        {
            Assert.AreEqual("[32]", Playing_on_a_chessboard.game(8));
        }
    }
}    
