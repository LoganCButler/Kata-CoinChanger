using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application;

namespace UnitTest
{
    [TestClass]
    public class SingleCoins
    {
        [TestMethod]
        public void OnePenny()
        {
            double input = 0.01;
            CoinChanger c = new CoinChanger();

            string output = c.MakeChange(input);

            Assert.AreEqual("Pennies: 1", output);
            
        }
    }

    [TestClass]
    public class MultipleOfSameCoin
    {
        [TestMethod]
        public void MultiplePennies()
        {
            double input = 0.03;
            CoinChanger c = new CoinChanger();

            string output = c.MakeChange(input);

            Assert.AreEqual("Pennies: 3", output);

        }
    }
}
