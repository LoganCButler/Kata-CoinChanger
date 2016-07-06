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

            string output = c.ChangeCheck(input);

            Assert.AreEqual("Pennies: 1\n", output);
        }

        [TestMethod]
        public void OneNickle()
        {
            double input = 0.05;
            CoinChanger c = new CoinChanger();

            string output = c.ChangeCheck(input);

            Assert.AreEqual("Nickles: 1\n", output);
        }

        [TestMethod]
        public void OneDime()
        {
            double input = 0.10;
            CoinChanger c = new CoinChanger();

            string output = c.ChangeCheck(input);

            Assert.AreEqual("Dimes: 1\n", output);
        }

        [TestMethod]
        public void OneQuarter()
        {
            double input = 0.25;
            CoinChanger c = new CoinChanger();

            string output = c.ChangeCheck(input);

            Assert.AreEqual("Quarters: 1\n", output);
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

            string output = c.ChangeCheck(input);

            Assert.AreEqual("Pennies: 3\n", output);
        }

        [TestMethod]
        public void MultipleDimes()
        {
            double input = 0.20;
            CoinChanger c = new CoinChanger();

            string output = c.ChangeCheck(input);

            Assert.AreEqual("Dimes: 2\n", output);
        }

        [TestMethod]
        public void MultipleQuarters()
        {
            double input = 0.75;
            CoinChanger c = new CoinChanger();

            string output = c.ChangeCheck(input);

            Assert.AreEqual("Quarters: 3\n", output);
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

            string output = c.ChangeCheck(input);

            Assert.AreEqual("Nickles: 1\nPennies: 1\n", output);
        }

        [TestMethod]
        public void QuarterDime()
        {
            double input = 0.35;
            CoinChanger c = new CoinChanger();

            string output = c.ChangeCheck(input);

            Assert.AreEqual("Quarters: 1\nDimes: 1\n", output);
        }

        [TestMethod]
        public void DimeDimePenniePennie()
        {
            double input = 0.22;
            CoinChanger c = new CoinChanger();

            string output = c.ChangeCheck(input);

            Assert.AreEqual("Dimes: 2\nPennies: 2\n", output);
        }

        [TestMethod]
        public void QuarterDimeNicklePennie()
        {
            double input = 0.41;
            CoinChanger c = new CoinChanger();

            string output = c.ChangeCheck(input);

            Assert.AreEqual("Quarters: 1\nDimes: 1\nNickles: 1\nPennies: 1\n", output);
        }
    }

    [TestClass]
    public class SpecialCases
    {
        [TestMethod]
        public void NoChange()
        {
            double input = 0.00;
            CoinChanger c = new CoinChanger();

            string output = c.ChangeCheck(input);

            Assert.AreEqual("No Change", output);
        }

        
    }
}
