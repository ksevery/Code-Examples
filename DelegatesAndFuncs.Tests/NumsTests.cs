using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesAndFuncs.Tests
{
    [TestClass]
    public class NumsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var nums = new List<int>() { 20, 3, 44, 1, 2, 16, 5 };
            var expectedOutput = new List<int>() { 3, 1, 2, 5 };

            var numsLowerThan10 = Program.GetNumsLowerThan(10, nums).ToList();

            CollectionAssert.AreEquivalent(expectedOutput, numsLowerThan10);
        }

        // Showing exception testing
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNameEmptyShouldThrowException()
        {
            var example = new ExampleClass();

            example.Name = string.Empty;
        }
    }
}
