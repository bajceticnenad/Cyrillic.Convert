using System.Text;

namespace Cyrillic.Convert.UnitTests.LanguagesTests
{
    public class KazakhLanguageTests
    {
        private static string NC(string? s) => s!.Normalize(NormalizationForm.FormC);

        [Fact]
        public void KazakhCyrillicToLatin_ShouldReturnExpected()
        {
            var conversion = new Conversion();
            var latin = conversion.KazakhCyrillicToLatin(TestConst.KazakhCyrillicLetters);
            Assert.Equal(NC(TestConst.KazakhLatinLetters), NC(latin));
        }

        [Fact]
        public void KazakhCyrillicToLatin_Extension_ShouldReturnExpected()
        {
            var latin = TestConst.KazakhCyrillicLetters.ToKazakhLatin();
            Assert.Equal(NC(TestConst.KazakhLatinLetters), NC(latin));
        }

        [Fact]
        public void KazakhLatinToCyrillic_ShouldReturnExpected()
        {
            var conversion = new Conversion();
            var cyrillic = conversion.KazakhLatinToCyrillic(TestConst.KazakhLatinLetters);
            Assert.Equal(NC(TestConst.KazakhCyrillicLetters), NC(cyrillic));
        }

        [Fact]
        public void KazakhLatinToCyrillic_Extension_ShouldReturnExpected()
        {
            var cyrillic = TestConst.KazakhLatinLetters.ToKazakhCyrillic();
            Assert.Equal(NC(TestConst.KazakhCyrillicLetters), NC(cyrillic));
        }
    }
}
