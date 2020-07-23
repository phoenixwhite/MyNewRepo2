using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppHello.Tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Sum_10and5_returned15()
        {
            int actual = Calc.Sum(10, 5);

            int expected = 15;

            Assert.AreEqual(expected, actual);
        }
    }
}
