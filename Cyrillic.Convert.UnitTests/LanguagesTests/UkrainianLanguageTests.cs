using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrillic.Convert.UnitTests.LanguagesTests
{
    public class UkrainianLanguageTests
    {
        [Fact]
        public void ConvertToUkrainianCyrillic_ShouldReturnCorrectLetters()
        {
            // Arrange
            var conversion = new Conversion();

            // Act
            var cyrillic = conversion.UkrainianLatinToCyrillic(TestConst.UkrainianLatinLetters); //Convert with forwarded string

            // Assert
            Assert.Equal(TestConst.UkrainianCyrillicLetters, cyrillic);
        }

        [Fact]
        public void ConvertToUkrainianCyrillic_Extension_ShouldReturnCorrectLetters()
        {
            // Arrange & Act
            var cyrillicExtension = TestConst.UkrainianLatinLetters.ToUkrainianCyrillic(); //Convert with extension method

            // Assert
            Assert.Equal(TestConst.UkrainianCyrillicLetters, cyrillicExtension);
        }

        [Fact]
        public void ConvertToUkrainianLatin_ShouldReturnCorrectLetters()
        {
            // Arrange
            var conversion = new Conversion();

            // Act
            var latin = conversion.UkrainianCyrillicToLatin(TestConst.UkrainianCyrillicLetters); //Convert with forwarded string

            // Assert
            Assert.Equal(TestConst.UkrainianLatinLetters, latin);
            //Assert.True(TestConst.UkrainianLatinLetters.Equals(latin));
        }

        [Fact]
        public void ConvertToUkrainianLatin_Extension_ShouldReturnCorrectLetters()
        {
            // Arrange & Act
            var latinExtension = TestConst.UkrainianCyrillicLetters.ToUkrainianLatin(); //Convert with extension method

            // Assert
            Assert.Equal(TestConst.UkrainianLatinLetters, latinExtension);
        }
    }
}
