using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrillic.Convert.UnitTests.LanguagesTests
{
    public class GeorgianLanguageTests
    {
        [Fact]
        public void ConvertToGeorgianCyrillic_ShouldReturnCorrectLetters()
        {
            // Arrange
            var conversion = new Conversion();

            // Act
            var cyrillic = conversion.GeorgianLatinToCyrillic(TestConst.GeorgianLatinLetters); //Convert with forwarded string

            // Assert
            Assert.Equal(TestConst.GeorgianCyrillicLetters, cyrillic);
        }

        [Fact]
        public void ConvertToGeorgianCyrillic_Extension_ShouldReturnCorrectLetters()
        {
            // Arrange & Act
            var cyrillicExtension = TestConst.GeorgianLatinLetters.ToGeorgianCyrilic(); //Convert with extension method

            // Assert
            Assert.Equal(TestConst.GeorgianCyrillicLetters, cyrillicExtension);
        }

        [Fact]
        public void ConvertToGeorgianLatin_ShouldReturnCorrectLetters()
        {
            // Arrange
            var conversion = new Conversion();

            // Act
            var latin = conversion.GeorgianCyrillicToLatin(TestConst.GeorgianCyrillicLetters); //Convert with forwarded string

            // Assert
            Assert.Equal(TestConst.GeorgianLatinLetters, latin);
        }

        [Fact]
        public void ConvertToGeorgianLatin_Extension_ShouldReturnCorrectLetters()
        {
            // Arrange & Act
            var latinExtension = TestConst.GeorgianCyrillicLetters.ToGeorgianLatin(); //Convert with extension method

            // Assert
            Assert.Equal(TestConst.GeorgianLatinLetters, latinExtension);
        }
    }
}
