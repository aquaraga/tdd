using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;
using TDD;

namespace Tests
{
    [TestFixture]
    public class StringUtilTest
    {
        [Test]
        public void ReversingANullStringShouldReturnNull()
        {
            string reversedString = StringX.Reverse(null);
            Assert.IsNull(reversedString);
        }

        [Test]
        public void ReversingAnEmptyStringShouldReturnEmpty()
        {
            string reversedString = string.Empty.Reverse();
            Assert.That(reversedString, Is.EqualTo(string.Empty));
        }

        [Test]
        public void ReversingASingleCharacterStringShouldReturnTheSame()
        {
            string reversedString = "A".Reverse();
            Assert.That(reversedString, Is.EqualTo("A"));
        }

        [Test]
        public void ShouldReverseAMultiCharacterStringWithNoSpaces()
        {
            string reversedString = "Quick".Reverse();
            Assert.That(reversedString, Is.EqualTo("kciuQ"));
        }

        [Test]
        public void ShouldReverseWithoutConsideringSpaceAtTheEnd()
        {
            string reversedString = "Quick ".Reverse();
            Assert.That(reversedString, Is.EqualTo("kciuQ "));
        }

        [Test]
        public void ShouldReverseFragmentsOfSubstringsWithinAMasterString()
        {
            string reversedString = "Cat and Dog".Reverse();
            Assert.That(reversedString, Is.EqualTo("taC dna goD"));            
        }

        [Test]
        public void ShouldReverseFragmentsOfSubstringsWithPunctuations()
        {
            string reversedString = "Hip;  hip;  hurray! ".Reverse();
            Assert.That(reversedString, Is.EqualTo(";piH  ;pih  !yarruh "));
        }
        
    }
}
