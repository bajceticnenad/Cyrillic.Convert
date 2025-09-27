using System.Text;
using Xunit;

namespace Cyrillic.Convert.UnitTests.LanguagesTests
{
    public class BelarusianLanguageTests
    {
        private static string NC(string s) => s.Normalize(NormalizationForm.FormC);

        [Fact]
        public void BelarusianCyrillicToLatin_ShouldReturnExpected()
        {
            var conversion = new Conversion();
            var latin = conversion.BelarusianCyrillicToLatin(TestConst.BelarusianCyrillicLetters);
            Assert.Equal(NC(TestConst.BelarusianLatinLetters), NC(latin));
        }

        [Fact]
        public void BelarusianCyrillicToLatin_Extension_ShouldReturnExpected()
        {
            var latin = TestConst.BelarusianCyrillicLetters.ToBelarusianLatin();
            Assert.Equal(NC(TestConst.BelarusianLatinLetters), NC(latin));
        }

        [Fact]
        public void BelarusianLatinToCyrillic_ShouldReturnExpected()
        {
            var conversion = new Conversion();
            var cyr = conversion.BelarusianLatinToCyrillic(TestConst.BelarusianLatinLetters);
            Assert.Equal(NC(TestConst.BelarusianCyrillicLetters), NC(cyr));
        }

        [Fact]
        public void BelarusianLatinToCyrillic_Extension_ShouldReturnExpected()
        {
            var cyr = TestConst.BelarusianLatinLetters.ToBelarusianCyrillic();
            Assert.Equal(NC(TestConst.BelarusianCyrillicLetters), NC(cyr));
        }
    }
}
