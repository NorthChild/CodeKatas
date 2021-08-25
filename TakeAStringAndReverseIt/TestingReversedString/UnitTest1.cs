using NUnit.Framework;
using TakeAStringAndReverseIt;

namespace TestingReversedString
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("This is my string", "gnirts ym si sihT")]
        [TestCase("This is another string", "gnirts rehtona si sihT")]
        public void TestingThatReceivedStringIsReversedCorrectly(string testString, string expected)
        {
            Assert.That(()=> Program.TakeStringAndReverseIt(testString), Is.EqualTo(expected));
        }
    }
}