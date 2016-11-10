using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_1_iterations_1._2_while_loops.test
{
    class DecimalTest
    {
        [Test, Sequential]
        public void DecimalTest_CountDigits_Test1([Range(1, 9)] int n)
        {
            var expected = 1;
            var actual = Decimal.CountDigits(n);
            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void DecimalTest_CountDigits_Test2([Range(10, 99)] int n)
        {
            var expected = 2;
            var actual = Decimal.CountDigits(n);
            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void DecimalTest_CountDigits_Test3([Range(100, 999)] int n)
        {
            var expected = 3;
            var actual = Decimal.CountDigits(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
