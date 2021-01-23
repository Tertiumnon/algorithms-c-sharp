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
        public void Test1()
        {
            var result = _singleNumberSolution.SingleNumber(new[]{ 2, 2, 1 });
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Test2()
        {
            var result = _singleNumberSolution.SingleNumber(new[]{ 4,1,2,1,2 });
            Assert.AreEqual(result, 4);
        }
    }
}