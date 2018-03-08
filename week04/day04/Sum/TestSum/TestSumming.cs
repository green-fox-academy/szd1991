using Sum;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSum
{
    [TestFixture]
    public class TestSumming
    {
        [Test]
        public void TestSumElementsWithEmptyList()
        {
            Summing summing = new Summing();
            var testNumbers = new List<int>();

            Assert.AreEqual(0, summing.SumElements(testNumbers));
        }

        [Test]
        public void TestSumElementsWithOneElementList()
        {
            Summing summing = new Summing();
            var testNumbers = new List<int> { 56 };

            Assert.AreEqual(testNumbers[0], summing.SumElements(testNumbers));
        }

        [Test]
        public void TestSumElementsWithMultipleElementList()
        {
            Summing summing = new Summing();
            var testNumbers = new List<int> { 1, 2, 3, 4, 5 };

            Assert.AreEqual(15, summing.SumElements(testNumbers));
        }

        [Test]
        public void TestSumElementsWithNullList()
        {
            Summing summing = new Summing();
            var testNumbers = new List<int>();
            testNumbers = null;

            Assert.Throws<NullReferenceException>(() => summing.SumElements(testNumbers));
        }
    }
}
