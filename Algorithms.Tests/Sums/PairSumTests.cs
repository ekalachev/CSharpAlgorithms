using System.Linq;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Sums;

namespace Algorithms.Tests.Sums
{
    [TestClass]
    public class PairSumTests
    {
        [TestMethod]
        public void GivenNullArray_WhenFind_ThenThrows()
        {
            // Arrange
            var tps = new PairSum();

            // Act // Assert
            Assert.ThrowsException<ArgumentNullException>(() => tps.Find(null, 10));
        }

        [TestMethod]
        public void GivenArrayAndSum_WhenFind_ThenReturnsAllTwoPairSumsWhichEqualToSumNumber()
        {
            // Arrange
            var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sum = 8;
            var tps = new PairSum();

            // Act
            var result = tps.Find(array, sum).OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToList();

            // Assert
            var expectedResult = new List<Tuple<int, int>>() {
                new Tuple<int, int>(1,7),
                new Tuple<int, int>(2,6),
                new Tuple<int, int>(3,5)
            };

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
        }
    }
}