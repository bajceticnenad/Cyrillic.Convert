using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrillic.Convert.Product.ConcreteProducts
{
    public class Georgian : ConversionDictionaries
    {
        private readonly Dictionary<char, string> cyrillicToLatinDictionary;
        private readonly Dictionary<char, string> cyrillicStartDictionary;
        private readonly Dictionary<string, string> cyrillicSpecialCases;

        private readonly Dictionary<string, string> latinToCyrillicDictionary;
        private readonly Dictionary<string, string> latinToCyrillicStartDictionary;
        public Georgian()
        {
            latinToCyrillicDictionary = new Dictionary<string, string>
            {
                { "tch", "ჭ" },
                { "Tch", "Ჭ" },

                { "th", "თ"},
                { "Th", "Თ" },
                { "zh", "ჟ" },
                { "Zh", "Ჟ" },
                { "ph", "ფ" },
                { "Ph", "Ფ" },
                { "gh", "ღ" },
                { "Gh", "Ღ" },
                { "qh", "ყ" },
                { "Qh", "Ყ" },
                { "sh", "შ" },
                { "Sh", "Შ" },
                { "ch", "ჩ" },
                { "Ch", "Ჩ" },
                { "ts", "ც" },
                { "Ts", "Ც" },
                { "dz", "ძ" },
                { "Dz", "Ძ" },
                { "kh", "ხ" },
                { "Kh", "Ხ" },

                { "a", "ა" },
                { "A", "Ა" },
                { "b", "ბ" },
                { "B", "Ბ" },
                { "g", "გ" },
                { "G", "Გ" },
                { "d", "დ" },
                { "D", "Დ" },
                { "e", "ე" },
                { "E", "Ე" },
                { "v", "ვ" },
                { "V", "Ვ" },
                { "z", "ზ" },
                { "Z", "Ზ" },
                { "i", "ი" },
                { "I", "Ი" },
                { "k", "კ" },
                { "K", "Კ" },
                { "l", "ლ" },
                { "L", "Ლ" },
                { "m", "მ" },
                { "M", "Მ" },
                { "n", "ნ" },
                { "N", "Ნ" },
                { "o", "ო" },
                { "O", "Ო" },
                { "p", "პ" },
                { "P", "Პ" },
                { "r", "რ" },
                { "R", "Რ" },
                { "s", "ს" },
                { "S", "Ს" },
                { "t", "ტ" },
                { "T", "Ტ" },
                { "u", "უ" },
                { "U", "Უ" },
                { "q", "ქ" },
                { "Q", "Ქ" },
                { "j", "ჯ" },
                { "J", "Ჯ" },
                { "h", "ჰ" },
                { "H", "Ჰ" },
            };

            cyrillicToLatinDictionary = new Dictionary<char, string>
            {
                { 'ჭ', "tch"},
                { 'Ჭ', "Tch"},

                { 'თ', "th" },
                { 'Თ', "Th"},
                { 'ჟ', "zh" },
                { 'Ჟ', "Zh" },
                { 'ფ', "ph" },
                { 'Ფ', "Ph" },
                { 'ღ', "gh" },
                { 'Ღ', "Gh" },
                { 'ყ', "qh" },
                { 'Ყ', "Qh" },
                { 'შ', "sh" },
                { 'Შ', "Sh" },
                { 'ჩ', "ch" },
                { 'Ჩ', "Ch" },
                { 'ც', "ts" },
                { 'Ც', "Ts" },
                { 'ძ', "dz" },
                { 'Ძ', "Dz" },
                { 'წ', "ts" },
                { 'Წ', "Ts" },
                { 'ხ', "kh" },
                { 'Ხ', "Kh" },

                { 'ა', "a" },
                { 'Ა', "A" },
                { 'ბ', "b" },
                { 'Ბ', "B" },
                { 'გ', "g" },
                { 'Გ', "G" },
                { 'დ', "d" },
                { 'Დ', "D" },
                { 'ე', "e" },
                { 'Ე', "E" },
                { 'ვ', "v" },
                { 'Ვ', "V" },
                { 'ზ', "z" },
                { 'Ზ', "Z" },
                { 'ი', "i" },
                { 'Ი', "I" },
                { 'კ', "k" },
                { 'Კ', "K" },
                { 'ლ', "l" },
                { 'Ლ', "L" },
                { 'მ', "m" },
                { 'Მ', "M" },
                { 'ნ', "n" },
                { 'Ნ', "N" },
                { 'ო', "o" },
                { 'Ო', "O" },
                { 'პ', "p" },
                { 'Პ', "P" },
                { 'რ', "r" },
                { 'Რ', "R" },
                { 'ს', "s" },
                { 'Ს', "S" },
                { 'ტ', "t" },
                { 'Ტ', "T" },
                { 'უ', "u" },
                { 'Უ', "U" },
                { 'ქ', "q" },
                { 'Ქ', "Q" },
                { 'ჯ', "j" },
                { 'Ჯ', "J" },
                { 'ჰ', "h" },
                { 'Ჰ', "H" },
            };

            cyrillicStartDictionary = new Dictionary<char, string>()
            {
            };

            latinToCyrillicStartDictionary = new Dictionary<string, string>()
            {
            };

            cyrillicSpecialCases = new Dictionary<string, string>()
            {
                //{ "წ", "ts" },
                //{ "Წ", "Ts" },
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
