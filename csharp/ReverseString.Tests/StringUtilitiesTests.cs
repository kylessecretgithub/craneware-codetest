using CodingChallenge.ReversingString;
using NUnit.Framework;

namespace ReverseString.Tests
{
    public class StringUtilitiesTests
    {
        [Test]
        public void ReversesString()
        {
            string reversedString = StringUtilities.Reverse("abc");
            Assert.That(reversedString, Is.EqualTo("cba"));
        }

        [Test]
        public void Returns_empty_string_when_given_null()
        {
            string reversedString = StringUtilities.Reverse(null);
            Assert.That(reversedString, Is.EqualTo(""));
        }
    }
}