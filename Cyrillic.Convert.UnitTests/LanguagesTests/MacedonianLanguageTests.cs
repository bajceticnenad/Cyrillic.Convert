using System.Text;
using Xunit;

namespace Cyrillic.Convert.UnitTests.LanguagesTests
{
    public class MacedonianLanguageTests
    {
        private static string NC(string s) => s.Normalize(NormalizationForm.FormC);

        [Fact]
        public void MacedonianCyrillicToLatin_CoreLetters()
        {
            const string cyr = "\u0410\u0430 \u0411\u0431 \u0412\u0432 \u0413\u0433 \u0414\u0434 \u0415\u0435 \u0417\u0437 \u0418\u0438 \u0408\u0458 \u041A\u043A \u041B\u043B \u041C\u043C \u041D\u043D \u041E\u043E \u041F\u043F \u0420\u0440 \u0421\u0441 \u0422\u0442 \u0423\u0443 \u0424\u0444 \u0425\u0445 \u042A\u044A";
            var latin = cyr.ToMacedonianLatin();
            Assert.Equal("Aa Bb Vv Gg Dd Ee Zz Ii Jj Kk Ll Mm Nn Oo Pp Rr Ss Tt Uu Ff Hh ??", NC(latin));
        }

        [Fact]
        public void MacedonianCyrillicToLatin_Digraphs()
        {
            const string cyr = "\u0403\u0453 \u0405\u0455 \u040A\u045A \u0409\u0459 \u040C\u045C \u040F\u045F \u0427\u0447 \u0416\u0436 \u0428\u0448";
            var latin = cyr.ToMacedonianLatin();
            Assert.Equal("Gjgj Dzdz Njnj Ljlj Kjkj Djdj Chch zhzh Shsh", NC(latin));
        }

        [Fact]
        public void MacedonianLatinToCyrillic_DigraphsRoundTrip()
        {
            const string latin = "Gjgj Dzdz Njnj Ljlj Kjkj Djdj Chch Zhzh Shsh";
            var cyr = latin.ToMacedonianCyrillic();
            Assert.Equal("\u0403\u0453 \u0405\u0455 \u040A\u045A \u0409\u0459 \u040C\u045C \u040F\u045F \u0427\u0447 \u0416\u0436 \u0428\u0448", cyr);
        }

        [Fact]
        public void MacedonianRoundTrip_Sample()
        {
            const string cyr = "\u0409\u0443\u0431\u043E\u0432 \u0403\u0430\u0432\u043E\u043B \u040C\u043E\u0448 \u0405\u0438\u0434 \u040F\u0435\u0431 \u040A\u0443\u0437"; // ????? ????? ??? ??? ??? ???
            var latin = cyr.ToMacedonianLatin();
            var back = latin.ToMacedonianCyrillic();
            Assert.Equal(NC(cyr), NC(back));
        }
    }
}
