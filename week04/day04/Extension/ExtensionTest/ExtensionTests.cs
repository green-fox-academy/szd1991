using Extension;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionTests
{
    public class ExtensionTests
    {
        [TestFixture]
        public class Extension_Tests
        {
            Extensions extension = new Extensions();

            [Test]
            public void TestAdd_2and3is5()
            {
                Assert.AreEqual(5, extension.Add(2, 3));
            }

            [Test]
            public void TestAdd_8plus3_is11()
            {
                Assert.AreEqual(11, extension.Add(8, 3));
            }

            [Test]
            public void TestAdd_24plus6_is30()
            {
                Assert.AreEqual(30, extension.Add(24, 6));
            }

            [Test]
            public void TestAdd_2plus2_is4()
            {
                Assert.AreEqual(4, extension.Add(2, 2));
            }

            [Test]
            public void TestAdd_1and4is5()
            {
                Assert.AreEqual(5, extension.Add(1, 4));
            }

            [Test]
            public void TestMaxOfThree_First()
            {
                Assert.AreEqual(5, extension.MaxOfThree(5, 4, 3));
            }

            [Test]
            public void TestMaxOfThree_Fhird()
            {
                Assert.AreEqual(5, extension.MaxOfThree(3, 4, 5));
            }

            [Test]
            public void TestMaxOfThree_Second()
            {
                Assert.AreEqual(5, extension.MaxOfThree(3, 5, 4));
            }

            [Test]
            public void TestMaxOfThree_FirstIsBiggerThanSecond_ButThirdIsGreatest()
            {
                Assert.AreEqual(5, extension.MaxOfThree(4, 3, 5));
            }

            [Test]
            public void TestMaxOfThree_FirstAndSecondAreEqual()
            {
                Assert.AreEqual(5, extension.MaxOfThree(5, 5, 4));
            }

            [Test]
            public void TestMaxOfThree_FirstAndThirdAreEqual()
            {
                Assert.AreEqual(5, extension.MaxOfThree(5, 3, 5));
            }

            [Test]
            public void TestMaxOfThree_SecondAndThirdAreEqual()
            {
                Assert.AreEqual(5, extension.MaxOfThree(4, 5, 5));
            }

            [Test]
            public void TestMaxOfThree_AllThreeAreEqual()
            {
                Assert.AreEqual(5, extension.MaxOfThree(5, 5, 5));
            }

            [Test]
            public void TestMedian_Four()
            {
                Assert.AreEqual(5, extension.Median(new List<int>() { 7, 5, 3, 5 }));
            }

            [Test]
            public void TestMedian_Five()
            {
                Assert.AreEqual(3, extension.Median(new List<int>() { 1, 2, 3, 4, 5 }));
            }

            [Test]
            public void TestMedian_ListCountIs3_MedianIs24()
            {
                Assert.AreEqual(24, extension.Median(new List<int>() { 13, 79, 24 }));
            }

            [Test]
            public void TestMedian_ListCountIs7_MedianIs6()
            {
                Assert.AreEqual(6, extension.Median(new List<int>() { 6, 2, 8, 9, 11, 4, 4 }));
            }

            [Test]
            public void TestIsVowel_a()
            {
                Assert.True(extension.IsVowel('a'));
            }

            [Test]
            public void TestIsVowel_u()
            {
                Assert.True(extension.IsVowel('u'));
            }

            [Test]
            public void TestIsVowel_x()
            {
                Assert.False(extension.IsVowel('x'));
            }

            [Test]
            public void TestIsVowel_f()
            {
                Assert.False(extension.IsVowel('f'));
            }

            [Test]
            public void testTranslate_bemutatkozik()
            {
                Assert.AreEqual("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
            }

            [Test]
            public void testTranslate_kolbice()
            {
                Assert.AreEqual("lavagovopuvus", extension.Translate("lagopus"));
            }
        }
    }
}