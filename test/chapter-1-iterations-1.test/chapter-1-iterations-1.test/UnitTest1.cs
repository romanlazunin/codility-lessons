using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using chapter_1_iterations;

namespace chapter_1_iterations_1.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Iterations_Factorial_Test1()
        {
            var n = 0;

            var expected = 1;
            var actual = Iteratoins.Factorial(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Iterations_Factorial_Test2()
        {
            var n = 1;

            var expected = 1;
            var actual = Iteratoins.Factorial(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Iterations_Factorial_Test3()
        {
            var n = 2;

            var expected = 2;
            var actual = Iteratoins.Factorial(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Iterations_Factorial_Test4()
        {
            var n = 3;

            var expected = 6;
            var actual = Iteratoins.Factorial(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Iterations_Factorial_Test5()
        {
            var n = 4;

            var expected = 24;
            var actual = Iteratoins.Factorial(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Iterations_Factorial_Test6()
        {
            var n = 5;

            var expected = 120;
            var actual = Iteratoins.Factorial(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Iterations_Factorial_Test7()
        {
            var n = 6;

            var expected = 720;
            var actual = Iteratoins.Factorial(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
