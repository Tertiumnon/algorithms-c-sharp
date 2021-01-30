using NUnit.Framework;
using Algorithms;

namespace AlgorithmsTests
{
    [TestFixture]
    public class Tests
    {
        private SingleNumberSolution _singleNumberSolution;

        [SetUp]
        public void Setup()
        {
            _singleNumberSolution = new SingleNumberSolution();
        }

        [Test]
        [TestCase(1, new[]{ 2, 2, 1 })]
        public void Test1(int exprectedResult, int[] nums)
        {
            var result = _singleNumberSolution.SingleNumber(nums);
            Assert.AreEqual(result, exprectedResult);
        }
    }
}