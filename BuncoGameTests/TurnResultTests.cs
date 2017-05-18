using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuncoGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuncoGame.Tests
{
    [TestClass()]
    public class TurnResultTests
    {
        [TestMethod()]
        public void TurnResultTestBunco()
        {
            TurnResult t = new TurnResult(1, 1, 1, 1);
            int result = t.Score;
            Assert.AreEqual(21, result);
        }
        [TestMethod()]
        public void TurnResultTestBinky()
        {
            TurnResult t = new TurnResult(1, 2, 2, 2);
            int result = t.Score;
            Assert.AreEqual(5, result);
        }
        [TestMethod()]
        public void TurnResultTestTwoCorrect()
        {
            TurnResult t = new TurnResult(1, 1, 2, 1);
            int result = t.Score;
            Assert.AreEqual(2, result);
        }
    }
}