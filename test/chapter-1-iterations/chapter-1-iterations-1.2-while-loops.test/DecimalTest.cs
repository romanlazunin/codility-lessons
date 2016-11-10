using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace chapter_1_iterations_1._2_while_loops.test
{
    [TestClass]
    public class DecimalTest
    {
        [TestMethod]
        public void DecimalTest_CountDigits_TestMethod1()
        {
            var n = 0;
            var expected = 1;
            var actual = Decimal.CountDigits(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecimalTest_CountDigits_TestMethod2()
        {
            var n = 1;
            var expected = 1;
            var actual = Decimal.CountDigits(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecimalTest_CountDigits_TestMethod3()
        {
            var n = 2;
            var expected = 1;
            var actual = Decimal.CountDigits(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecimalTest_CountDigits_TestMethod4()
        {
            var n = 3;
            var expected = 1;
            var actual = Decimal.CountDigits(n);
            Assert.AreEqual(expected, actual);
        }

    }
}
