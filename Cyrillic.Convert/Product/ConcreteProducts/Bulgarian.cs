using System.Collections.Generic;

namespace Cyrillic.Convert.Product.ConcreteProducts
{
    public class Bulgarian
    {
        Dictionary<string, string> bulgarianDictionary;
        public void BulgarianDictionary()
        {
            bulgarianDictionary = new Dictionary<string, string>
            {
                { "а", "a" },
                { "б", "b" },
                { "в", "v" },
                { "г", "g" },
                { "д", "d" },
                { "е", "e" },
                //bug_dictionary.Add("ё", "yo");
                { "ж", "zh" },
                { "з", "z" },
                { "и", "i" },
                { "й", "j" },
                { "к", "k" },
                { "л", "l" },
                { "м", "m" },
                { "н", "n" },
                { "о", "o" },
                { "п", "p" },
                { "р", "r" },
                { "с", "s" },
                { "т", "t" },
                { "у", "u" },
                { "ф", "f" },
                { "х", "h" },
                { "ц", "c" },
                { "ч", "ch" },
                { "ш", "sh" },
                { "щ", "sht" }, //
                { "ъ", "u" }, //
                              //bug_dictionary.Add("ы", "i");
                { "ь", "j" },
                { "э", "e" },
                { "ю", "yu" },
                { "я", "ya" },
                { "дж", "dzh" },
                { "дз", "dz" },
                { "пш", "psh" },

                { "А", "A" },
                { "Б", "B" },
                { "В", "V" },
                { "Г", "G" },
                { "Д", "D" },
                { "Е", "E" },
                //bug_dictionary.Add("Ё", "Yo");
                { "Ж", "Zh" },
                { "З", "Z" },
                { "И", "I" },
                { "Й", "J" },
                { "К", "K" },
                { "Л", "L" },
                { "М", "M" },
                { "Н", "N" },
                { "О", "O" },
                { "П", "P" },
                { "Р", "R" },
                { "С", "S" },
                { "Т", "T" },
                { "У", "U" },
                { "Ф", "F" },
                { "Х", "H" },
                { "Ц", "C" },
                { "Ч", "Ch" },
                { "Ш", "Sh" },
                { "Щ", "Sht" },//
                { "Ъ", "U" },//
                             //bug_dictionary.Add("Ы", "I");
                { "Ь", "U" },
                { "Э", "E" },
                { "Ю", "Yu" },
                { "Я", "Ya" },
                { "ДЖ", "Dzh" },
                { "ДЗ", "Dz" },
                { "ПШ", "Psh" }
            };
        }

        public Dictionary<string, string> GetDictionary()
        {
            BulgarianDictionary();
            return bulgarianDictionary;
        }

    }
}