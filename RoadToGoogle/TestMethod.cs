using FluentAssertions;
using NUnit.Framework;
using RoadToGoogle.Challenges.SortingAndSearching;

namespace RoadToGoogle
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void Test()
        {
            int[][] a = { new[] { 2, 3 }, new[]{ 2, 2 }, new[]{3,3}, new[]{1,3}, new[] { 5, 7 }, new[] { 2, 2 }, new[] { 4, 6 } };
            int[][] b = { new[] { 1, 3 }, new[]{4,7}};

            MergeIntervals.Merge(a).Should().BeEquivalentTo(b);
        }
    }
}