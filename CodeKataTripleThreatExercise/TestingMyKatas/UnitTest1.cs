using NUnit.Framework;
using CodeKataTripleThreatExercise;
using System;

namespace TestingMyKatas
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        // exercise 1 tests
        [TestCase("CELSIUS", "45", 7.2222222222222223d)]
        [TestCase("FAHRENHEIT", "-45", -49.0d)]
        [TestCase("CELSIUS", "1", -17.222222222222221d)]
        public void TestThatGivenACelsTempItConvertsItToFahrenheit(string convToDo, string temp, double expected)
        {
            Assert.That(() => Program.TemperatureConverter(convToDo, temp), Is.EqualTo(expected));
        }

        [Test]
        public void TestThatGivingWrongCommandsThrowsException()
        {

            var stringToTest = "wrong input";
            var temp = "10.4";

            Assert.That(() => Program.TemperatureConverter(stringToTest, temp), Throws.TypeOf<ArgumentException>().With.Message.Contains("INVALID CONVERSION"));
        }

        // exercise 2 tests
        [TestCase("10 5 25 40", "Average marks of (10,5,25,40) = 20")]
        public void TestThatGivenArrayOfIntsFromCommandLineReturnsAvgOfTheInts(string arrayInString, string expected)
        {
            Assert.That(() => Program.FromCommandLineTakeIntsAndReturnAverage(arrayInString), Is.EqualTo(expected));
        }

        [Test]
        public void TestThatIfStringContainsTextThrowsException()
        {
            Assert.That(() => Program.FromCommandLineTakeIntsAndReturnAverage("asd 23 a 123 fa"), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("INSERT ONLY NUMBERS!"));
        }



        // exercise 3 tests
        [Test]
        public void AssertThatIfIntIsInsertedThrowsException()
        {
            Assert.That(() => Program.CharacterIdentifier("1"), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("ONLY WORKS WITH LETTERS, SOZ"));
        }

        [TestCase("l", "Entered character l is Consonant")]
        [TestCase("a", "Entered character a is Vowel")]
        [TestCase("m", "Entered character m is Consonant")]
        public void TestThatGivenACharacterItIdentifiesSaidCharAsVowelOrConsonant(string charToIde, string expected)
        {
            Assert.That(() => Program.CharacterIdentifier(charToIde), Is.EqualTo(expected));
        }

        [Test]
        public void TestThatIfInputIsNotACharButAStringThrowException()
        {
            Assert.That(() => Program.CharacterIdentifier("lol"), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("ONLY SINGLE CHARACTERS PLEASE!"));
        }
    }
}