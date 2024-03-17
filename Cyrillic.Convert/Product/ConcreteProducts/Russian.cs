using System.Collections.Generic;

namespace Cyrillic.Convert.Product.ConcreteProducts
{
    public class Russian : ConversionDictionaries
    {
        private readonly Dictionary<char, string> cyrillicToLatinDictionary;
        private readonly Dictionary<char, string> cyrillicStartDictionary;
        private readonly Dictionary<string, string> cyrillicSpecialCases;

        private readonly Dictionary<string, string> latinToCyrillicDictionary;
        private readonly Dictionary<string, string> latinToCyrillicStartDictionary;
        public Russian()
        {
            cyrillicStartDictionary = new Dictionary<char, string>()
            {
                { 'Ё', "Yo" },
                { 'Ж', "Zh" },
                { 'Х', "Kh" },
                { 'Ц', "Ts" },
                { 'Ч', "Ch" },
                { 'Ш', "Sh" },
                { 'Щ', "Shch" },
                { 'Ю', "Ju" },
                { 'Я', "Ja" },
                { 'ё', "yo" },
                { 'ж', "zh" },
                { 'х', "kh" },
                { 'ц', "ts" },
                { 'ч', "ch" },
                { 'ш', "sh" },
                { 'щ', "shch" },
                { 'ю', "ju" },
                { 'я', "ja" },
                { 'а', "a" },
                { 'А', "A" },
            };

            latinToCyrillicStartDictionary = new Dictionary<string, string>()
            {
            };

            cyrillicToLatinDictionary = new Dictionary<char, string>
            {

                { 'Щ', "Sch" },

                { 'Ё', "Yo"  },
                { 'Ж', "Zh"  },
                { 'Х', "Kh"  },
                { 'Ц', "Ts"  },
                { 'Ч', "Ch"  },
                { 'Ю', "Ju"  },
                { 'Я', "Ja"  },
                { 'Ш', "Sh"  },


                { 'щ', "sch" },

                { 'ё', "yo" },
                { 'ж', "zh" },
                { 'х', "kh" },
                { 'ц', "ts" },
                { 'ч', "ch" },
                { 'ш', "sh" },
                { 'ю', "ju" },
                { 'я', "ja" },

                { 'А', "A" },
                { 'Б', "B" },
                { 'В', "V" },
                { 'Г', "G" },
                { 'Д', "D" },
                { 'Е', "E" },
                { 'З', "Z" },
                { 'И', "I" },
                { 'Й', "J" },
                { 'К', "K" },
                { 'Л', "L" },
                { 'М', "M" },
                { 'Н', "N" },
                { 'О', "O" },
                { 'П', "P" },
                { 'Р', "R" },
                { 'С', "S" },
                { 'Т', "T" },
                { 'У', "U" },
                { 'Ф', "F" },
                { 'Ы', "Y" },
                { 'Ъ', "" },
                { 'Ь', "" },
                { 'Э', "E" },
                { 'а', "a" },
                { 'б', "b" },
                { 'в', "v" },
                { 'г', "g" },
                { 'д', "d" },
                { 'е', "e" },
                { 'з', "z" },
                { 'и', "i" },
                { 'й', "j" },
                { 'к', "k" },
                { 'э', "e" },
                { 'л', "l" },
                { 'м', "m" },
                { 'н', "n" },
                { 'о', "o" },
                { 'п', "p" },
                { 'р', "r" },
                { 'с', "s" },
                { 'т', "t" },
                { 'у', "u" },
                { 'ф', "f" },
                { 'ъ', "" },
                { 'ы', "y" },
                { 'ь', "" },
                { '\'',"" }
            };

            latinToCyrillicDictionary = new Dictionary<string, string>
            {
                { "Shch", "Щ" },
                { "Sch", "Щ" },

                { "Yo", "Ё" },
                { "Zh", "Ж" },
                { "Kh", "Х" },
                { "Ts", "Ц" },
                { "Ch", "Ч" },
                { "Ju", "Ю" },
                { "Ja", "Я" },
                { "Sh", "Ш" },

                { "shch", "щ" },
                { "sch", "щ" },

                { "yo", "ё" },
                { "zh", "ж" },
                { "kh", "х" },
                { "ts", "ц" },
                { "ch", "ч" },
                { "sh", "ш" },
                { "ju", "ю" },
                { "ja", "я" },

                { "SHCH", "Щ" },
                { "SCH", "Щ" },
                { "CH", "Ч" },
                { "YO", "Ё" },
                { "ZH", "Ж" },
                { "KH", "Х" },
                { "TS", "Ц" },
                { "JU", "Ю" },
                { "JA", "Я" },

                { "A", "А" },
                { "B", "Б" },
                { "V", "В" },
                { "G", "Г" },
                { "D", "Д" },
                { "E", "Е" },
                { "Z", "З" },
                { "I", "И" },
                { "J", "Й" },
                { "K", "К" },
                { "L", "Л" },
                { "M", "М" },
                { "N", "Н" },
                { "O", "О" },
                { "P", "П" },
                { "R", "Р" },
                { "S", "С" },
                { "T", "Т" },
                { "U", "У" },
                { "F", "Ф" },
                { "Y", "Ы" },
                { "H", "Х" },
                //{ "C", "Ц" },
                //{ "E", "Э" },
                { "a", "а" },
                { "b", "б" },
                { "v", "в" },
                { "g", "г" },
                { "d", "д" },
                { "e", "е" },
                { "z", "з" },
                { "i", "и" },
                { "j", "й" },
                { "k", "к" },
                //{ "e", "э" },
                { "l", "л" },
                { "m", "м" },
                { "n", "н" },
                { "o", "о" },
                { "p", "п" },
                { "r", "р" },
                { "s", "с" },
                { "t", "т" },
                { "u", "у" },
                { "f", "ф" },
                { "y", "ы" },
                { "h", "х" },
                //{ "c", "ц" },
            };

            cyrillicSpecialCases = new Dictionary<string, string>()
            {
                { "Щ", "Shch" },
                { "щ", "shch" },
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

