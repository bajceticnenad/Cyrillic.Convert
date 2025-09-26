using Cyrillic.Convert.UnitTests;

namespace Cyrillic.Convert.UnitTests.LanguagesTests
{
    public class GreekLanguageTests
    {
        [Fact]
        public void ConvertToGreekLatin_ShouldReturnCorrectLetters()
        {
            // Arrange
            var conversion = new Conversion();

            // Act
            var latin = conversion.GreekCyrillicToLatin(TestConst.GreekCyrillicLetters);

            // Assert
            Assert.Equal(TestConst.GreekLatinLetters, latin);
        }

        [Fact]
        public void ConvertToGreekLatin_Extension_ShouldReturnCorrectLetters()
        {
            // Arrange & Act
            var latinExtension = TestConst.GreekCyrillicLetters.ToGreekLatin();

            // Assert
            Assert.Equal(TestConst.GreekLatinLetters, latinExtension);
        }

        [Fact]
        public void ConvertToGreekCyrillic_ShouldReturnExpectedRoundTripLetters()
        {
            // Arrange
            var conversion = new Conversion();

            // Act
            var cyrillic = conversion.GreekLatinToCyrillic(TestConst.GreekLatinLetters);

            // Assert
            Assert.Equal(TestConst.GreekLatinToGreekExpected, cyrillic);
        }

        [Fact]
        public void ConvertToGreekCyrillic_Extension_ShouldReturnExpectedRoundTripLetters()
        {
            // Arrange & Act
            var cyrillicExtension = TestConst.GreekLatinLetters.ToGreekCyrilic();

            // Assert
            Assert.Equal(TestConst.GreekLatinToGreekExpected, cyrillicExtension);
        }
    }
}
