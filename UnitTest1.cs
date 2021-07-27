using NUnit.Framework;
using CodeToTest;
namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenATimeOf21_Greeting_ReturnsGoodEvening()
        {
            var time = 21;
            var expectedGreeting = "Good evening!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [Test]
        public void GivenATimeOf8_Greeting_ReturnsGoodMorning()
        {
            var time = 8;
            var expectedGreeting = "Good morning!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [TestCase(6)]
        [TestCase(13)]
        [TestCase(16)]
        public void GivenATimeOf15_Greeting_ReturnsGoodafternoon()
        {
            var time = 15;
            var expectedGreeting = "Good afternoon!";
            var result = Program.Greeting(time);
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [TestCase(5)]
        [TestCase(8)]
        [TestCase(11)]
        public void GivenATimeBetween5and12Inclusive_Greeting_ReturnsGoodMorning(int time)
        {
            // Arrange
            var expectedGreeting = "Good morning!";
            // Act
            var result = Program.Greeting(time);
            // Assert
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
    }
}