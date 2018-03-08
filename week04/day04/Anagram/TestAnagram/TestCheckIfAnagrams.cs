using NUnit.Framework;
using Anagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnagram
{
    [TestFixture]
    public class TestCheckIfAnagrams
    {
        CheckIfAnagrams anagramsOrNot = new CheckIfAnagrams();

        [Test]
        public void ShouldReturnFalseBecauseWordsLengthsAreNotEvenEqual()
        {
            string stringOne = "oneone";
            string stringTwo = "two";

            Assert.AreEqual(false, anagramsOrNot.AnagramsOrNot(stringOne, stringTwo));
        }

        [Test]
        public void ShouldReturnFalseBecauseWordsAreNotAnagrams()
        {
            string stringOne = "one";
            string stringTwo = "two";

            Assert.AreEqual(false, anagramsOrNot.AnagramsOrNot(stringOne, stringTwo));
        }

        [Test]
        public void ShouldReturnTrueWithLowercaseInputs()
        {
            string stringOne = "listen";
            string stringTwo = "silent";

            Assert.AreEqual(true, anagramsOrNot.AnagramsOrNot(stringOne, stringTwo));
        }

        [Test]
        public void ShouldReturnTrueOneOfTwoInputsWithUppercase()
        {
            string stringOne = "Star";
            string stringTwo = "rats";

            Assert.AreEqual(true, anagramsOrNot.AnagramsOrNot(stringOne, stringTwo));
        }

        [Test]
        public void ShouldReturnTrueWithDifferentNumberOfSpacesInInputsAlsoOneLetterMultipleExistance()
        {
            string stringOne = "Kossuth Lajos";
            string stringTwo = "Has Just Looks";

            Assert.AreEqual(true, anagramsOrNot.AnagramsOrNot(stringOne, stringTwo));
        }
    }
}
