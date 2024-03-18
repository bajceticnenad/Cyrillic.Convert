using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrillic.Convert.UnitTests.LanguagesTests
{
    public class BulgarianLanguageTests
    {
        [Fact]
        public void ConvertToBulgarianCyrillic_ShouldReturnCorrectLetters()
        {
            // Arrange
            var conversion = new Conversion();

            // Act
            var cyrillic = conversion.BulgarianLatinToCyrillic(TestConst.BulgarianLatinLetters); //Convert with forwarded string

            // Assert
            Assert.Equal(TestConst.BulgarianCyrillicLetters, cyrillic);
        }

        [Fact]
        public void ConvertToBulgarianCyrillic_Extension_ShouldReturnCorrectLetters()
        {
            // Arrange & Act
            var cyrillicExtension = TestConst.BulgarianLatinLetters.ToBulgarianCyrilic(); //Convert with extension method

            // Assert
            Assert.Equal(TestConst.BulgarianCyrillicLetters, cyrillicExtension);
        }

        [Fact]
        public void ConvertToBulgarianLatin_ShouldReturnCorrectLetters()
        {
            // Arrange
            var conversion = new Conversion();

            // Act
            var latin = conversion.BulgarianCyrillicToLatin(TestConst.BulgarianCyrillicLetters); //Convert with forwarded string

            // Assert
            Assert.Equal(TestConst.BulgarianLatinLetters, latin);
            //Assert.True(TestConst.BulgarianLatinLetters.Equals(latin));
        }

        [Fact]
        public void ConvertToBulgarianLatin_Extension_ShouldReturnCorrectLetters()
        {
            // Arrange & Act
            var latinExtension = TestConst.BulgarianCyrillicLetters.ToBulgarianLatin(); //Convert with extension method

            // Assert
            Assert.Equal(TestConst.BulgarianLatinLetters, latinExtension);
        }
    }
}
