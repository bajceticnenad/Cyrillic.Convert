using Xunit;

namespace Cyrillic.Convert.UnitTests.LanguagesTests
{
    public class ArmenianLanguageTests
    {
        [Fact]
        public void ConvertToArmenianLatin_ShouldReturnCorrectLetters()
        {
            var conversion = new Conversion();
            var latin = conversion.ArmenianCyrillicToLatin(TestConst.ArmenianCyrillicLetters);
            Assert.Equal(TestConst.ArmenianLatinLetters, latin);
        }

        [Fact]
        public void ConvertToArmenianLatin_Extension_ShouldReturnCorrectLetters()
        {
            var latinExtension = TestConst.ArmenianCyrillicLetters.ToArmenianLatin();
            Assert.Equal(TestConst.ArmenianLatinLetters, latinExtension);
        }

        [Fact]
        public void ConvertToArmenianCyrillic_ShouldReturnExpectedRoundTripLetters()
        {
            var conversion = new Conversion();
            var cyr = conversion.ArmenianLatinToCyrillic(TestConst.ArmenianLatinLetters);
            Assert.Equal(TestConst.ArmenianCyrillicLetters, cyr);
        }

        [Fact]
        public void ConvertToArmenianCyrillic_Extension_ShouldReturnExpectedRoundTripLetters()
        {
            var cyrExt = TestConst.ArmenianLatinLetters.ToArmenianCyrilic();
            Assert.Equal(TestConst.ArmenianCyrillicLetters, cyrExt);
        }
    }
}
