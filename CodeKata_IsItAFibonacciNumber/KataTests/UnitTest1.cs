using NUnit.Framework;
using CodeKata_IsItAFibonacciNumber;
using System;

namespace KataTests
{
    public class Tests
    {

        [Test]
        public void TestingThatGivenANumbThatIsAFibonacciNumb_ReturnsCorrectString()
        {
            Assert.That(() => Program.IsItPartOfFibonacci(13), Is.EqualTo($"{13} is part of Fibonacci"));
            Assert.That(() => Program.IsItPartOfFibonacci(89), Is.EqualTo($"{89} is part of Fibonacci"));
            Assert.That(() => Program.IsItPartOfFibonacci(34), Is.EqualTo($"{34} is part of Fibonacci"));
            Assert.That(() => Program.IsItPartOfFibonacci(144), Is.EqualTo($"{144} is part of Fibonacci"));
            Assert.That(() => Program.IsItPartOfFibonacci(3), Is.EqualTo($"{3} is part of Fibonacci"));
        }


        [Test]
        public void TestingThatGivenANumbThatIsntAFibonacciNumb_ReturnsCorrectString()
        {
            Assert.That(() => Program.IsItPartOfFibonacci(10), Is.EqualTo($"{10} is not part of Fibonacci"));
            Assert.That(() => Program.IsItPartOfFibonacci(51), Is.EqualTo($"{51} is not part of Fibonacci"));
            Assert.That(() => Program.IsItPartOfFibonacci(214), Is.EqualTo($"{214} is not part of Fibonacci"));
            Assert.That(() => Program.IsItPartOfFibonacci(37), Is.EqualTo($"{37} is not part of Fibonacci"));
            Assert.That(() => Program.IsItPartOfFibonacci(65), Is.EqualTo($"{65} is not part of Fibonacci"));

        }

        [Test]
        public void TestingThatGivenANegativeNumb_ThrowsException()
        {
            Assert.That(()=> Program.IsItPartOfFibonacci(-1), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Int must be positive"));
            Assert.That(() => Program.IsItPartOfFibonacci(-23), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Int must be positive"));
            Assert.That(() => Program.IsItPartOfFibonacci(-42), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Int must be positive"));
        }
    }
}