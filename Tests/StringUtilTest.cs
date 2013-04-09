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
            string reversedString = StringUtil.Reverse(null);
            Assert.IsNull(reversedString);
        }

        [Test]
        public void ReversingAnEmptyStringShouldReturnEmpty()
        {
            string reversedString = StringUtil.Reverse(string.Empty);
            Assert.That(reversedString, Is.EqualTo(string.Empty));
        }

        [Test]
        public void ReversingASingleCharacterStringShouldReturnTheSame()
        {
            string reversedString = StringUtil.Reverse("A");
            Assert.That(reversedString, Is.EqualTo("A"));
        }

        [Test]
        public void ShouldReverseAMultiCharacterStringWithNoSpaces()
        {
            string reversedString = StringUtil.Reverse("Quick");
            Assert.That(reversedString, Is.EqualTo("kciuQ"));
        }

        [Test]
        public void ShouldReverseWithoutConsideringSpaceAtTheEnd()
        {
            string reversedString = StringUtil.Reverse("Quick ");
            Assert.That(reversedString, Is.EqualTo("kciuQ "));
        }

        [Test]
        public void ShouldReverseFragmentsOfSubstringsWithinAMasterString()
        {
            string reversedString = StringUtil.Reverse("Cat and Dog");
            Assert.That(reversedString, Is.EqualTo("taC dna goD"));            
        }

        [Test]
        public void ShouldReverseFragmentsOfSubstringsWithPunctuations()
        {
            string reversedString = StringUtil.Reverse("Hip;  hip;  hurray! ");
            Assert.That(reversedString, Is.EqualTo(";piH  ;pih  !yarruh "));
        }
        
    }
}
