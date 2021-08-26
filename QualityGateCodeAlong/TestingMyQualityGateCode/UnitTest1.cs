using NUnit.Framework;
using QualityGateCodeAlong;
using System;

namespace TestingMyQualityGateCode
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase ("Hello", new char[] {'l'})]
        public void TestThatGivenAStringReturnsDuplicateChars(string testString, char[] expected)
        {
            Assert.That(() => Program.ReturnDuplicatesFromArray(testString), Is.EqualTo(expected));
        }

        [Test]
        public void TestThatEmptyArrayThrowsException()
        {
            Assert.That(() => Program.ReturnDuplicatesFromArray(""), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("array is empty"));
        }
    }
}