using System;
using NUnit.Framework;
using codility_trial_tasks;

namespace codility_trial_tasks.test
{
    [TestFixture]
    public class SolutionTests
    {
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 2)]
        [TestCase(3, ExpectedResult = 3)]
        [TestCase(4, ExpectedResult = 4)]
        [TestCase(5, ExpectedResult = 5)]
        [TestCase(6, ExpectedResult = 6)]
        [TestCase(7, ExpectedResult = 7)]
        [TestCase(8, ExpectedResult = 8)]
        [TestCase(9, ExpectedResult = 9)]
        [TestCase(10, ExpectedResult = 10)]
        public int Solution_Test_Run_Test1(int n)
        {
            var A = new int[] { n };
            return new Solution().Run(A);
        }

        [Test, Sequential]
        public void Solution_Test_Run_Test2([Range(1, 10)] int n)
        {
            var A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = 0;
            }

            var expected = 0;
            var actual = new Solution().Run(A);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solution_Test_Run_Test3()
        {
            var A = new int[] { int.MaxValue };
            var expected = int.MaxValue;
            var actual = new Solution().Run(A);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void Solution_Test_Run_Test4([Range(0, 10)] int n)
        {
            var A = new int[] { n };
            var expected = n;
            var actual = new Solution().Run(A);

            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void Solution_Test_Run_Test5([Range(99999, 100000)] int n)
        {
            var A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = 0;
            }

            var expected = 0;
            var actual = new Solution().Run(A);

            Assert.AreEqual(expected, actual);
        }
    }
}