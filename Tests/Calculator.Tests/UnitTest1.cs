using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorHelperTests
    {
        [TestMethod]
        public void AddTwoNumbersShouldReturnResault()
        {
            double expectedResault = 10;
            double number = CalculatorHelper.Add(5, 5);
            Assert.AreEqual(expectedResault, number);
        }

        [TestMethod]
        public void AddTwoOppositeNumbersShouldReturnZero()
        {
            double number = CalculatorHelper.Add(-5, 5);
            Assert.AreEqual(0, number);
        }

        [TestMethod]
        public void MultiplyTwoNumbersShouldReturnResault()
        {
            double expectedResault = 25;
            double number = CalculatorHelper.Multiply(5, 5);
            Assert.AreEqual(expectedResault, number);
        }

        [TestMethod]
        public void DivideTwoNumbersShouldReturnResult()
        {
            double expectedResault = 4;
            double number = CalculatorHelper.Divide(8, 2);
            Assert.AreEqual(expectedResault, number);
        }

        [TestMethod]
        public void DivideTwoSameNumbersShouldReturnOne()
        {
            double number = CalculatorHelper.Divide(5, 5);
            Assert.AreEqual(1, number);
        }

        [TestMethod]
        public void SubtractTwoNumbersShouldReturnResult()
        {
            double expectedResault = 3;
            double number = CalculatorHelper.Subtract(8, 5);
            Assert.AreEqual(expectedResault, number);
        }

        [TestMethod]
        public void SubtractTwoSameNumbersShouldReturnZero()
        {
            double number = CalculatorHelper.Subtract(5, 5);
            Assert.AreEqual(0, number);
        }
    }
}
