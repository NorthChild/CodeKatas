using NUnit.Framework;
using System;
using CodeKata5_WhoLikesIt;
using System.Collections.Generic;
namespace Solution
{


    [TestFixture]
    public class Test
    {
        [Test, Description("It should return correct text")]
        public void TestingThatFeedingMethodWithArrayReturnsCorrectString()
        {
            Assert.AreEqual("no one likes this", Program.LikeThis(new string[0]));
            Assert.AreEqual("Peter likes this", Program.LikeThis(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", Program.LikeThis(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", Program.LikeThis(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", Program.LikeThis(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }

        [TestCase( new string[] { "X Æ A-12" }, "X Æ A-12 likes this")]
        public void TestingThatFeedingMethodWithArrayWithParticularNamesReturnsCorrectString(string[] testString, string expected)
        {
            Assert.That(()=> Program.LikeThis(testString), Is.EqualTo(expected));
        }

        [Test]
        public void TestingThatFeedingMethodWithArrayContainingIntsThrowsException()
        {
            Assert.That(() => Program.LikeThis(new string[] { "George", "1" }), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Array must contain names"));
        }
    }
}