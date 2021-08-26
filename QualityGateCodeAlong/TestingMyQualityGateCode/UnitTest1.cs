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
        // added these two tests after the code along
        [TestCase("Helllo", new char[] { 'l' })]
        [TestCase("123411156", new char[] { '1' })]
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