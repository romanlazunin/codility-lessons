using System;
using NUnit.Framework;
using codility_demo_test;

namespace codility_demo_test.test
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Solution_Run_TestMethod0()
        {
            var A = new int[] {};
            var expected = -1;
            var actual = new Solution().Run(A);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Solution_Run_TestMethod1()
        {
            var A = new int[] { 0 };
            var expected = 0;
            var actual = new Solution().Run(A);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solution_Run_TestMethod2()
        {
            var A = new int[] { 0, 0 };
            var expected = 0;
            var actual = new Solution().Run(A);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solution_Run_TestMethod3()
        {
            var A = new int[] { 0, 0, 0 };
            var expected = 0;
            var actual = new Solution().Run(A);

            Assert.AreEqual(expected, actual);
        }

        // -1, 3, -4, 5, 1, -6, 2, 1
        [Test]
        public void Solution_Run_TestMethod4()
        {
            var A = new int[] { -1, 3, -4, 5, 1, -6, 2, 1 };
            var expected = 1;
            var actual = new Solution().Run(A);

            Assert.AreEqual(expected, actual);
        }

        // −2,147,483,648..2,147,483,647
        [Test]
        public void Solution_Run_TestMethod5()
        {
            var A = new int[] { int.MinValue, int.MaxValue };
            var expected = -1;
            var actual = new Solution().Run(A);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solution_Run_TestMethod6()
        {
            var n = 100000;
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = 0;
            }

            var expected = 0;
            var actual = new Solution().Run(A);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solution_Run_TestMethod7()
        {
            var n = 100000;
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = 1;
            }

            var expected = -1;
            var actual = new Solution().Run(A);

            Assert.AreEqual(expected, actual);
        }

    }
}
