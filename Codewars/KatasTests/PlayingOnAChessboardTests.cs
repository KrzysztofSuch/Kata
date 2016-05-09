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
    public class PlayingOnAChessboardTests
    {
        [Test]
        public void Playing_on_a_chessboard_GameVal_is_0()
        {
            Assert.AreEqual("[0]", PlayingOnAChessboard.Game(0));
        }
        [Test]
        public void Playing_on_a_chessboard_GameVal_is_1()
        {
            Assert.AreEqual("[1, 2]", PlayingOnAChessboard.Game(1));
        }

        [Test]
        public void Playing_on_a_chessboard_GameVal_is_2()
        {
            Assert.AreEqual("[2]", PlayingOnAChessboard.Game(2));
        }

        [Test]
        public void Playing_on_a_chessboard_GameVal_is_3()
        {
            Assert.AreEqual("[4, 2]", PlayingOnAChessboard.Game(3));
        }
        
        [Test]
        public void Playing_on_a_chessboard_GameVal_is_4()
        {
            Assert.AreEqual("[8]", PlayingOnAChessboard.Game(4));
        }

        [Test]
        public void Playing_on_a_chessboard_Test03()
        {
            Assert.AreEqual("[32]", PlayingOnAChessboard.Game(8));
        }
    }
}    
