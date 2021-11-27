using FluentAssertions;
using NUnit.Framework;
using RoadToGoogle.Challenges.ArraysAndStrings;
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
            string[] logs = { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };
            string[] output = {"let1 art can", "let3 art zero", "let2 own kit dig", "dig1 8 1 5 1", "dig2 3 6"};

            ReorderdataInLogFiles.ReorderLogFiles(logs).Should().BeEquivalentTo(output);
        }
    }
}