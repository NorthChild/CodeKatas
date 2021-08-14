using NUnit.Framework;
using DuplicateElemCounter;
using System;
using System.Collections.Generic;


namespace DuplicateElementTEST
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("anna mia", new char[]{'n','a'})]
        [TestCase("Nishant Mandal", new char[] {'n','a'})]
        [TestCase("whatever tommorow brings i'll be there", new char[] { 'e', 't', 'm', 'o', 'r', 'w', 'i', 'l', 'b', 'h' })]
        [TestCase("test string, not too deep", new char[] { 't', 's', 'n', 'o', 'e' })]
        public void FeedingStringsReturningACountOfDuplicateCharacters(string testString, char[] expected)
        {
            Assert.That(() => Program.DupicateCounter(testString), Is.EqualTo(expected));
        }


        [Test]
        public void FeedingEmptyStringReturnsException()
        {
            var emptyTestString = "";
            Assert.That(() => Program.DupicateCounter(emptyTestString), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Give me something to do!"));
        }


    }
}