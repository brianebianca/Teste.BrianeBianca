using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Functions;
using Domain.Models;


namespace UnitTests
{
    [TestClass]
    public class FunctionPrintNumbersTests
    {
        [TestMethod]
        public void WhenCall_ListNumbers_ShouldReturnAtLeast100Elements()
        {
            FunctionPrintNumbers func = new FunctionPrintNumbers();
            Tag name = new Tag(String.Empty);
            Tag lastName = new Tag(String.Empty);
            var returnedValue = func.ListNumbers(name, lastName);

            Assert.AreEqual(100, returnedValue.Count);
        }

        [TestMethod]
        public void WhenCall_getNumberString_ForANumberNotMultipleOfThreeOrFive_ShouldReturnJustTheNumber()
        {
            FunctionPrintNumbers func = new FunctionPrintNumbers();
            Tag name = new Tag("Name");
            Tag lastName = new Tag("LastName");
            var number = 1;
            var returnedValue = func.getNumberString(number, false, false,name, lastName);

            Assert.AreEqual("1", returnedValue);
        }

        [TestMethod]
        public void WhenCall_getNumberString_ForANumberMultipleOfThree_ShouldReturnNumberAndName()
        {
            FunctionPrintNumbers func = new FunctionPrintNumbers();
            Tag name = new Tag("Name");
            Tag lastName = new Tag("LastName");
            var number = 1;
            var returnedValue = func.getNumberString(number, true, false, name, lastName);

            Assert.AreEqual("1 Name", returnedValue);
        }

        [TestMethod]
        public void WhenCall_getNumberString_ForANumberMultipleOfFive_ShouldReturnNumberAndLastName()
        {
            FunctionPrintNumbers func = new FunctionPrintNumbers();
            Tag name = new Tag("Name");
            Tag lastName = new Tag("LastName");
            var number = 1;
            var returnedValue = func.getNumberString(number, false, true, name, lastName);

            Assert.AreEqual("1 LastName", returnedValue);
        }

        [TestMethod]
        public void WhenCall_getNumberString_ForANumberMultipleOfThreeAndFive_ShouldReturnNumberNameAndLastName()
        {
            FunctionPrintNumbers func = new FunctionPrintNumbers();
            Tag name = new Tag("Name");
            Tag lastName = new Tag("LastName");
            var number = 1;
            var returnedValue = func.getNumberString(number, true, true, name, lastName);

            Assert.AreEqual("1 Name LastName", returnedValue);
        }

        [TestMethod]
        public void WhenCall_IsMultipleOfThree_PassingANonMultipleOfThree_ShouldReturnFalse()
        {
            FunctionPrintNumbers func = new FunctionPrintNumbers();
            var number = 4;
            var returnedValue = func.IsMultipleOfThree(number);

            Assert.AreEqual(false, returnedValue);
        }

        [TestMethod]
        public void WhenCall_IsMultipleOfThree_PassingMultipleOfThree_ShouldReturnTrue()
        {
            FunctionPrintNumbers func = new FunctionPrintNumbers();
            var number = 6;
            var returnedValue = func.IsMultipleOfThree(number);

            Assert.AreEqual(true, returnedValue);
        }

        [TestMethod]
        public void WhenCall_IsMultipleOfFive_PassingANonMultipleOfFive_ShouldReturnFalse()
        {
            FunctionPrintNumbers func = new FunctionPrintNumbers();
            var number = 6;
            var returnedValue = func.IsMultipleOfFive(number);

            Assert.AreEqual(false, returnedValue);
        }

        [TestMethod]
        public void WhenCall_IsMultipleOfFive_PassingMultipleOfFive_ShouldReturnTrue()
        {
            FunctionPrintNumbers func = new FunctionPrintNumbers();
            var number = 10;
            var returnedValue = func.IsMultipleOfFive(number);

            Assert.AreEqual(true, returnedValue);
        }
    }
}
