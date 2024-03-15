using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrillic.Convert.UnitTests.LanguagesTests
{
    public class RussianLanguageTests
    {
        [Fact]
        public void ConvertToRussianCyrillic_ShouldReturnCorrectLetters()
        {
            // Arrange
            var conversion = new Conversion();

            // Act
            var cyrillic = conversion.RussianLatinToCyrillic(TestConst.RussianLatinLetters); //Convert with forwarded string

            // Assert
            Assert.Equal(TestConst.RussianCyrillicLetters, cyrillic);
        }

        [Fact]
        public void ConvertToRussianCyrillic_Extension_ShouldReturnCorrectLetters()
        {
            // Arrange & Act
            var cyrillicExtension = TestConst.RussianLatinLetters.ToRussianCyrilic(); //Convert with extension method

            // Assert
            Assert.Equal(TestConst.RussianCyrillicLetters, cyrillicExtension);
        }

        [Fact]
        public void ConvertToRussianLatin_ShouldReturnCorrectLetters()
        {
            // Arrange
            var conversion = new Conversion();

            // Act
            var latin = conversion.RussianCyrillicToLatin(TestConst.RussianCyrillicLetters); //Convert with forwarded string

            // Assert
            Assert.Equal(TestConst.RussianLatinLetters, latin);
            //Assert.True(TestConst.RussianLatinLetters.Equals(latin));
        }

        [Fact]
        public void ConvertToRussianLatin_Extension_ShouldReturnCorrectLetters()
        {
            // Arrange & Act
            var latinExtension = TestConst.RussianCyrillicLetters.ToRussianLatin(); //Convert with extension method

            // Assert
            Assert.Equal(TestConst.RussianLatinLetters, latinExtension);
        }
    }
}
