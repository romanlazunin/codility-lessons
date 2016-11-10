using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using chapter_1_iterations_1._2_while_loops;

namespace chapter_1_iterations_1._2_while_loops.test
{
    [TestClass]
    public class WhileLoopTest
    {
        [TestMethod]
        public void WhileLoop_Run_TestMethod1()
        {
            var n = 0;
            var expected = string.Empty;
            var actual = WhileLoop.Run(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhileLoop_Run_TestMethod2()
        {
            var n = 1;
            var expected = "*";
            var actual = WhileLoop.Run(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhileLoop_Run_TestMethod3()
        {
            var n = 2;
            var expected = "**";
            var actual = WhileLoop.Run(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
