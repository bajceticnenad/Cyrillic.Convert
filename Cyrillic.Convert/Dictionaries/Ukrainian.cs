using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrillic.Convert.Dictionaries
{
    public class Ukrainian
    {
        private Dictionary<string, string> ukr_dictionary;
        public void RusDictionary()
        {
            ukr_dictionary = new Dictionary<string, string>
            {
                { "а", "a" },
                { "б", "b" },
                { "в", "v" },
                { "г", "h" },
                { "ґ", "g" },
                { "д", "d" },
                { "е", "e" },
                { "ё", "yo" },
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
                { "щ", "sch" },
                { "ъ", "j" },
                { "ы", "i" },
                { "ь", "j" },
                { "э", "e" },
                { "ю", "yu" },
                { "я", "ya" },
                { "А", "A" },
                { "Б", "B" },
                { "В", "V" },
                { "Г", "H" },
                { "Ґ", "G" },
                { "Д", "D" },
                { "Е", "E" },
                { "Ё", "Yo" },
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
                { "Щ", "Sch" },
                { "Ъ", "J" },
                { "Ы", "I" },
                { "Ь", "J" },
                { "Э", "E" },
                { "Ю", "Yu" },
                { "Я", "Ya" }
            };
        }

        public Dictionary<string, string> getDictionary()
        {
            RusDictionary();
            return this.ukr_dictionary;
        }
    }
}
