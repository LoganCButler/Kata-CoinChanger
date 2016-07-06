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

            Assert.AreEqual("Pennies: 1 ", output);
            
        }

        [TestMethod]
        public void OneNickle()
        {
            double input = 0.05;
            CoinChanger c = new CoinChanger();

            string output = c.MakeChange(input);

            Assert.AreEqual("Nickles: 1 ", output);

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

            Assert.AreEqual("Pennies: 3 ", output);

        }
    }

    [TestClass]
    public class MultiplesWithDifferentCoins
    {
        [TestMethod]
        public void SixCents()
        {
            double input = 0.06;
            CoinChanger c = new CoinChanger();

            string output = c.MakeChange(input);

            Assert.AreEqual("Nickles: 1 Pennies: 1 ", output);

        }
    }
}
