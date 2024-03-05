using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrillic.Convert.Product.ConcreteProducts
{
    public class Russian
    {
        Dictionary<string, string> russianDictionary;
        public void RussianDictionary()
        {
            russianDictionary = new Dictionary<string, string>
            {
                { "щ", "sch" },
                { "Щ", "Sch" },
                { "ё", "yo" },
                { "ж", "zh" },
                { "ч", "ch" },
                { "ш", "sh" },
                { "ю", "yu" },
                { "я", "ya" },
                { "Ё", "Yo" },
                { "Ж", "Zh" },
                { "Ч", "Ch" },
                { "Ш", "Sh" },
                { "Ю", "Yu" },
                { "Я", "Ya" },

                { "ц", "c" },
                { "ъ", "j" },
                { "ы", "i" },
                { "ь", "j" },
                { "э", "e" },
                { "й", "j" },
                { "Ц", "C" },
                { "Ъ", "J" },
                { "Ы", "I" },
                { "Ь", "J" },
                { "Э", "E" },
                { "Й", "J" },

                { "а", "a" },
                { "б", "b" },
                { "в", "v" },
                { "г", "g" },
                { "д", "d" },
                { "е", "e" },
                { "з", "z" },
                { "и", "i" },
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
                { "А", "A" },
                { "Б", "B" },
                { "В", "V" },
                { "Г", "G" },
                { "Д", "D" },
                { "Е", "E" },
                { "З", "Z" },
                { "И", "I" },
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
                { "Х", "H" }
            };


        }

        public Dictionary<string, string> GetDictionary()
        {
            RussianDictionary();
            return russianDictionary;
        }
    }
}

