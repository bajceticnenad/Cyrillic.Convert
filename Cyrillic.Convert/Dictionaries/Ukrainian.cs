using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrillic.Convert.Dictionaries
{
    public class Ukrainian
    {
        private readonly Dictionary<char, string> ukr_to_latin_dictionary;
        private readonly Dictionary<char, string> ukr_start_dictionary;
        private readonly Dictionary<string, string> ukr_special_cases;

        private readonly Dictionary<string, string> latin_to_ukr_dictionary;
        private readonly Dictionary<string, string> latin_to_ukr_start_dictionary;

        public Ukrainian()
        {
            ukr_start_dictionary = new Dictionary<char, string>()
            {
                { 'є', "ye" },
                { 'ї' , "yi" },
                { 'й' , "y" },
                { 'ю' , "yu" },
                { 'я' , "ya" },

                { 'Є', "Ye" },
                { 'Ї' , "Yi" },
                { 'Й' , "Y" },
                { 'Ю' , "Yu" },
                { 'Я' , "Ya" },
            };

            latin_to_ukr_start_dictionary = new Dictionary<string, string>()
            {
                { "ye", "є" },
                { "yi", "ї" },
                { "yu", "ю" },
                { "ya", "я" },
                { "y", "й" },


                { "Ye", "Є" },
                { "Yi", "Ї" },
                { "Yu", "Ю" },
                { "Ya", "Я" },

                { "YE", "Є" },
                { "YI", "Ї" },
                { "YU", "Ю" },
                { "YA", "Я" },

                { "Y", "Й" },
            };


            ukr_special_cases = new Dictionary<string, string>()
            {
                { "зг", "zgh" },
                { "Зг", "Zgh" },
                { "ЗГ", "ZGH" },
                { "зГ", "zGH" }
            };

            ukr_to_latin_dictionary = new Dictionary<char, string>
            {
                { 'а', "a" },
                { 'б', "b" },
                { 'в', "v" },
                { 'г', "h" },
                { 'ґ', "g" },
                { 'д', "d" },
                { 'е', "e" },
                { 'є', "ie" },
                { 'ж', "zh" },
                { 'з', "z" },
                { 'и', "y" },
                { 'і', "i" },
                { 'ї', "i" },
                { 'й', "i" },
                { 'к', "k" },
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
                { 'х', "kh" },
                { 'ц', "ts" },
                { 'ч', "ch" },
                { 'ш', "sh" },
                { 'щ', "shch" },
                { 'ю', "iu" },
                { 'я', "ia" },

                { 'А', "A" },
                { 'Б', "B" },
                { 'В', "V" },
                { 'Г', "H" },
                { 'Ґ', "G" },
                { 'Д', "D" },
                { 'Е', "E" },
                { 'Є', "IE" },
                { 'Ж', "Zh" },
                { 'З', "Z" },
                { 'И', "Y" },
                { 'І', "I" },
                { 'Ї', "I" },
                { 'Й', "i" },
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
                { 'Х', "Kh" },
                { 'Ц', "Ts" },
                { 'Ч', "Ch" },
                { 'Ш', "Sh" },
                { 'Щ', "Shch" },
                { 'Ю', "IU" },
                { 'Я', "IA" },

                { 'ь', "" },
                { '\'',"" }
            };

            latin_to_ukr_dictionary = new Dictionary<string, string>
            {
                { "shch", "щ" },
                { "ie", "є" },
                { "zh", "ж" },
                { "kh", "х" },
                { "ts", "ц" },
                { "ch", "ч" },
                { "sh", "ш" },
                { "iu", "ю" },
                { "ia", "я" },

                { "Shch" , "Щ" },
                { "SHCH" , "Щ" },
                { "IE", "Є" },
                { "ZH", "Ж" },
                { "Zh", "Ж" },
                { "KH" , "Х" },
                { "Kh" , "Х" },
                { "TS" , "Ц" },
                { "Ts" , "Ц" },
                { "CH" , "Ч" },
                { "Ch" , "Ч" },
                { "SH" , "Ш" },
                { "Sh" , "Ш" },
                { "IU" , "Ю" },
                { "IA" , "Я" },

                { "a", "а" },
                { "b", "б" },
                { "v", "в" },
                { "h", "г" },
                { "g", "ґ" },
                { "d", "д" },
                { "e", "е" },

                { "z",  "з" },
                { "y", "и" },
                { "i", "і" },
                { "k", "к" },
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



                { "A", "А" },
                { "B", "Б" },
                { "V", "В" },
                { "H", "Г" },
                { "G", "Ґ" },
                { "D", "Д" },
                { "E", "Е" },

                { "Z", "З" },
                { "Y" , "И" },
                { "I" , "І" },
                { "K" , "К" },
                { "L" , "Л" },
                { "M" , "М" },
                { "N" , "Н" },
                { "O" , "О" },
                { "P" , "П" },
                { "R" , "Р" },
                { "S" , "С" },
                { "T" , "Т" },
                { "U" , "У" },
                { "F" , "Ф" },

            };
        }


        public Dictionary<char, string> getDictionary()
        {
            return this.ukr_to_latin_dictionary;
        }
        public Dictionary<char, string> getStartDictionary()
        {
            return this.ukr_start_dictionary;
        }

        public Dictionary<string, string> getStartToUkrDictionary()
        {
            return this.latin_to_ukr_start_dictionary;
        }

        public Dictionary<string, string> getToUkrDictionary()
        {
            return this.latin_to_ukr_dictionary;
        }

        public Dictionary<string, string> getSpecialDictionary()
        {
            return this.ukr_special_cases;
        }
    }
}
