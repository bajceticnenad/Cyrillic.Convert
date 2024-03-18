namespace Cyrillic.Convert.UnitTests.LanguagesTests
{
    public class SerbianLanguageTests
    {
        [Fact]
        public void ConvertToSerbianCyrillic_ShouldReturnCorrectLetters()
        {
            // Arrange
            var conversion = new Conversion();

            // Act
            var cyrillic = conversion.SerbianLatinToCyrillic(TestConst.SerbianLatinLetters); //Convert with forwarded string

            // Assert
            Assert.Equal(TestConst.SerbianCyrillicLetters, cyrillic);
        }

        [Fact]
        public void ConvertToSerbianCyrillic_Extension_ShouldReturnCorrectLetters()
        {
            // Arrange & Act
            var cyrillicExtension = TestConst.SerbianLatinLetters.ToSerbianCyrilic(); //Convert with extension method

            // Assert
            Assert.Equal(TestConst.SerbianCyrillicLetters, cyrillicExtension);
        }

        [Fact]
        public void ConvertToSerbianLatin_ShouldReturnCorrectLetters()
        {
            // Arrange
            var conversion = new Conversion();

            // Act
            var latin = conversion.SerbianCyrillicToLatin(TestConst.SerbianCyrillicLetters); //Convert with forwarded string

            // Assert
            Assert.Equal(TestConst.SerbianLatinLetters, latin);
        }

        [Fact]
        public void ConvertToSerbianLatin_Extension_ShouldReturnCorrectLetters()
        {
            // Arrange & Act
            var latinExtension = TestConst.SerbianCyrillicLetters.ToSerbianLatin(); //Convert with extension method

            // Assert
            Assert.Equal(TestConst.SerbianLatinLetters, latinExtension);
        }
    }
}
