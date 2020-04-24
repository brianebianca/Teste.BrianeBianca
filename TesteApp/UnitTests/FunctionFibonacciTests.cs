using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Functions;
using Domain.Models;
using System.ComponentModel;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class FunctionFibonacciTests
    {
        [TestMethod]
        public void WhenCall_HasNDigits_PassingANumberSmallerThanN_ShouldReturnFalse()
        {
            FunctionFibonacci func = new FunctionFibonacci();
            int number = 35;
            int digits = 5;

            var returnedValue = func.HasNDigits(number, digits);

            Assert.AreEqual(false, returnedValue);
        }

        [TestMethod]
        public void WhenCall_HasNDigits_PassingANumberEqualsNDigits_ShouldReturnTrue()
        {
            FunctionFibonacci func = new FunctionFibonacci();
            int number = 47890;
            int digits = 5;

            var returnedValue = func.HasNDigits(number, digits);

            Assert.AreEqual(true, returnedValue);
        }

        [TestMethod]
        public void WhenCall_DoFibonacciWhileFindNDigitsNumber_PassingTwoDigits_ShouldReturnN7()
        {
            FunctionFibonacci func = new FunctionFibonacci();
            int digits = 2;
            int n;

            var returnedValue = func.DoFibonacciWhileFindNDigitsNumber(out n,digits);

            Assert.AreEqual(7, n);
        }

        [TestMethod]
        public void WhenCall_DoFibonacciWhileFindNDigitsNumber_PassingTwoDigits_ShouldReturnValue13()
        {
            FunctionFibonacci func = new FunctionFibonacci();
            int digits = 2;
            int n;

            var returnedValue = func.DoFibonacciWhileFindNDigitsNumber(out n, digits);

            Assert.AreEqual(13, returnedValue);
        }
    }
}


