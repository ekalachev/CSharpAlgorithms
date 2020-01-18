using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.Permutation
{
    [TestClass]
    public class StringPermutationTests
    {
        [TestMethod]
        public void GivenString_WhenRun_ThenReturnsAllPermutationsOfAGivenString()
        {
            // Arrange
            var p = new StringPermutation();
            var str = "abc";
            var expected = new HashSet<string>(new[] { "abc", "bac", "cab", "acb", "bca", "cba" });

            // Act
            var result = p.Permutate(str);

            // Assert            
            Assert.AreEqual(expected.Count, result.Count);
            result.ForEach(x => expected.Remove(x));
            Assert.AreEqual(0, expected.Count);
        }

        [TestMethod]
        public void GivenTwoStrings_WhenRun_ThenReturnsCountOfAllPermutationsOfTheShorterStringWithinTheLongerOne()
        {
            // Arrange
            var p = new StringPermutation();
            var str = "abbc";
            var text = "cbabadcbbabbcbabaabccbabc";

            // Act
            var result = p.GetPermutationCount(str, text);

            // Assert            
            Assert.AreEqual(7, result);
        }
    }
}
