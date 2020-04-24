using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Functions;
using Domain.Models;
using System.ComponentModel;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class FunctionSquaredSumTests
    {
        [TestMethod]
        public void WhenCall_SumOfSquared_PassingAGivenListOfIntegers_ShouldReturnSquaredSum()
        {
            FunctionSquaredSum func = new FunctionSquaredSum();
            var numbersList = new List<int>();
            numbersList.Add(1);
            numbersList.Add(2);
            numbersList.Add(3);
            numbersList.Add(4);
            numbersList.Add(5);

            var returnedValue = func.SumOfSquared(numbersList);

            Assert.AreEqual(55, returnedValue);
        }

        [TestMethod]
        public void WhenCall_Square_PassingAGivenIntegers_ShouldReturnSquare()
        {
            FunctionSquaredSum func = new FunctionSquaredSum();
            var number = 7;

            var returnedValue = func.Square(number);

            Assert.AreEqual(49, returnedValue);
        }
    }
}
