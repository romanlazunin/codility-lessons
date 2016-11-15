using System;
using NUnit.Framework;
using codility_demo_test;

namespace codility_demo_test.test
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Solution_Run_TestMethod1([Range(0, 9)] int n)
        {
            var expected = true;
            var actual = new Solution().Run(n);

            Assert.AreEqual(expected, actual);
        }
    }
}
