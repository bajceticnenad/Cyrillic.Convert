using Xunit;

namespace Cyrillic.Convert.UnitTests.LanguagesTests
{
    public class KazakhLanguageTests
    {
        [Fact]
        public void KazakhCyrillicToLatin_ShouldReturnIdentity()
        {
            var conversion = new Conversion();
            var source = TestConst.KazakhCyrillicLetters.Replace(",", string.Empty);
            var result = conversion.KazakhCyrillicToLatin(source);
            Assert.Equal(source, result); // identity expectation
        }

        [Fact]
        public void KazakhLatinToCyrillic_ShouldReturnIdentity()
        {
            var conversion = new Conversion();
            var source = TestConst.KazakhCyrillicLetters.Replace(",", string.Empty);
            // Using Cyrillic as 'Latin' input just to ensure no exception and identity
            var result = conversion.KazakhLatinToCyrillic(source);
            Assert.Equal(source, result); // identity expectation
        }
    }
}
