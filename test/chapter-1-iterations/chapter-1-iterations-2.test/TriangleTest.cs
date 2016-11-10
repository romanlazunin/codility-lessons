using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using chapter_1_iterations_2;

namespace chapter_1_iterations_2.test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Triangle_Print_TestMethod1()
        {
            var n = 1;
            var expected = "*";
            var actual = Triangle.Print(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Triangle_Print_TestMethod2()
        {
            var n = 2;
            var expected = "*";
            expected += Environment.NewLine;
            expected += "* *";
            var actual = Triangle.Print(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Triangle_Print_TestMethod3()
        {
            var n = 3;
            var expected = "*";
            expected += Environment.NewLine;
            expected += "* *";
            expected += Environment.NewLine;
            expected += "* * *";

            var actual = Triangle.Print(n);

            Assert.AreEqual(expected, actual);
        }
    }
}
