using System.Collections.Generic;

namespace Cyrillic.Convert.Product.ConcreteProducts
{
    public class Serbian : ConversionDictionaries
    {
        private readonly Dictionary<char, string> cyrillicToLatinDictionary;
        private readonly Dictionary<char, string> cyrillicStartDictionary;
        private readonly Dictionary<string, string> cyrillicSpecialCases;

        private readonly Dictionary<string, string> latinToCyrillicDictionary;
        private readonly Dictionary<string, string> latinToCyrillicStartDictionary;
        public Serbian()
        {
            latinToCyrillicDictionary = new Dictionary<string, string>
            {
                { "Lj", "Љ" },
                { "Nj", "Њ" },
                { "Dž", "Џ" },
                { "lj", "љ" },
                { "nj", "њ" },
                { "dž", "џ" },
                { "a", "а" },
                { "b", "б" },
                { "v", "в" },
                { "g", "г" },
                { "d", "д" },
                { "đ", "ђ" },
                { "e", "е" },
                { "ž", "ж" },
                { "z", "з" },
                { "i", "и" },
                { "j", "ј" },
                { "k", "к" },
                { "l", "л" },
                { "m", "м" },
                { "n", "н" },
                { "o", "о" },
                { "p", "п" },
                { "r", "р" },
                { "s", "с" },
                { "t", "т" },
                { "ć", "ћ" },
                { "u", "у" },
                { "f", "ф" },
                { "h", "х" },
                { "c", "ц" },
                { "č", "ч" },
                { "š", "ш" }
            };

            cyrillicToLatinDictionary = new Dictionary<char, string>
            {
                { 'Љ', "Lj" },
                { 'Њ', "Nj" },
                { 'Џ', "Dž" },
                { 'љ', "lj" },
                { 'њ', "nj" },
                { 'џ', "dž" },
                { 'а', "a" },
                { 'б', "b" },
                { 'в', "v" },
                { 'г', "g" },
                { 'д', "d" },
                { 'ђ', "đ" },
                { 'е', "e" },
                { 'ж', "ž" },
                { 'з', "z" },
                { 'и', "i" },
                { 'ј', "j" },
                { 'к', "k" },
                { 'л', "l" },
                { 'м', "m" },
                { 'н', "n" },
                { 'о', "o" },
                { 'п', "p" },
                { 'р', "r" },
                { 'с', "s" },
                { 'т', "t" },
                { 'ћ', "ć" },
                { 'у', "u" },
                { 'ф', "f" },
                { 'х', "h" },
                { 'ц', "c" },
                { 'ч', "č" },
                { 'ш', "š" }
            };

            cyrillicStartDictionary = new Dictionary<char, string>()
            {
                { 'Љ', "Lj" },
                { 'Њ', "Nj" },
                { 'Џ', "Dž" },
                { 'љ', "lj" },
                { 'њ', "nj" },
                { 'џ', "dž" },
            };

            latinToCyrillicStartDictionary = new Dictionary<string, string>()
            {
            };

            cyrillicSpecialCases = new Dictionary<string, string>()
            {
            };
        }

        //CyrillicToLatin
        public override Dictionary<char, string> GetToLatinDictionary()
        {
            return cyrillicToLatinDictionary;
        }

        //CyrillicToLatin & LatinToCyrillic
        public override Dictionary<char, string> GetStartDictionary()
        {
            return cyrillicStartDictionary;
        }

        //LatinToCyrillic
        public override Dictionary<string, string> GetStartToCyrillicDictionary()
        {
            return latinToCyrillicStartDictionary;
        }

        //LatinToCyrillic
        public override Dictionary<string, string> GetToCyrillicDictionary()
        {
            return latinToCyrillicDictionary;
        }

        //CyrillicToLatin & LatinToCyrillic
        public override Dictionary<string, string> GetSpecialDictionary()
        {
            return cyrillicSpecialCases;
        }
    }
}