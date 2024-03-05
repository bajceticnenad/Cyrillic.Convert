using Microsoft.VisualBasic;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;

namespace Cyrillic.Convert.UnitTests
{
    public class ConvertToCyrillicTests
    {
        [Fact]
        public void ConvertToSerbian_ShouldReturnCorrectLetters()
        {
            // Arrange
            var conversion = new Conversion();

            // Act
            var cyrillic = conversion.SerbianLatinToCyrillic(TestConst.SerbianLatinLetters); //Convert with forwarded string
            
            // Assert
            Assert.Equal(TestConst.SerbianCyrillicLetters, cyrillic);
        }

        [Fact]
        public void ConvertToSerbian_Extension_ShouldReturnCorrectLetters()
        {
            // Arrange & Act
            var cyrillicExtension = TestConst.SerbianLatinLetters.ToSerbianCyrilic(); //Convert with extension method

            // Assert
            Assert.Equal(TestConst.SerbianCyrillicLetters, cyrillicExtension);
        }

        [Fact]
        public void ConvertToRussian_ShouldReturnCorrectLetters()
        {
            // Arrange
            //string cyrillic = string.Empty;
            var conversion = new Conversion();

            // Act
            //foreach (var letter in TestConst.RussianLatinLettersArray)
            //{
            //    var cyrillicLetter = conversion.RussianLatinToCyrillic(letter);
            //    cyrillic += $",{cyrillicLetter}";
            //}
            var cyrillic = conversion.RussianLatinToCyrillic(TestConst.RussianLatinLetters); //Convert with forwarded string

            // Assert
            Assert.Equal(TestConst.RussianCyrillicLetters, cyrillic);
        }

        [Fact]
        public void ConvertToRussian_Extension_ShouldReturnCorrectLetters()
        {
            // Arrange
            string cyrillic = string.Empty;

            // Act
            foreach (var letter in TestConst.RussianLatinLettersArray)
            {
                var cyrillicLetter = letter.ToRussianCyrilic();
                cyrillic += $",{cyrillicLetter}";
            }

            // Assert
            Assert.Equal(TestConst.RussianCyrillicLetters, cyrillic);
        }


    }
}