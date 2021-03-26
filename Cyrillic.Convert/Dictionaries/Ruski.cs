using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrillic.Convert.Dictionaries
{
    public class Ruski
    {
        Dictionary<string, string> rus_dictionary;
        public void RusDictionary()
        {
            rus_dictionary = new Dictionary<string, string>();

            rus_dictionary.Add("а", "a");
            rus_dictionary.Add("б", "b");
            rus_dictionary.Add("в", "v");
            rus_dictionary.Add("г", "g");
            rus_dictionary.Add("д", "d");
            rus_dictionary.Add("е", "e");
            rus_dictionary.Add("ё", "yo");
            rus_dictionary.Add("ж", "zh");
            rus_dictionary.Add("з", "z");
            rus_dictionary.Add("и", "i");
            rus_dictionary.Add("й", "j");
            rus_dictionary.Add("к", "k");
            rus_dictionary.Add("л", "l");
            rus_dictionary.Add("м", "m");
            rus_dictionary.Add("н", "n");
            rus_dictionary.Add("о", "o");
            rus_dictionary.Add("п", "p");
            rus_dictionary.Add("р", "r");
            rus_dictionary.Add("с", "s");
            rus_dictionary.Add("т", "t");
            rus_dictionary.Add("у", "u");
            rus_dictionary.Add("ф", "f");
            rus_dictionary.Add("х", "h");
            rus_dictionary.Add("ц", "c");
            rus_dictionary.Add("ч", "ch");
            rus_dictionary.Add("ш", "sh");
            rus_dictionary.Add("щ", "sch");
            rus_dictionary.Add("ъ", "j");
            rus_dictionary.Add("ы", "i");
            rus_dictionary.Add("ь", "j");
            rus_dictionary.Add("э", "e");
            rus_dictionary.Add("ю", "yu");
            rus_dictionary.Add("я", "ya");
            rus_dictionary.Add("А", "A");
            rus_dictionary.Add("Б", "B");
            rus_dictionary.Add("В", "V");
            rus_dictionary.Add("Г", "G");
            rus_dictionary.Add("Д", "D");
            rus_dictionary.Add("Е", "E");
            rus_dictionary.Add("Ё", "Yo");
            rus_dictionary.Add("Ж", "Zh");
            rus_dictionary.Add("З", "Z");
            rus_dictionary.Add("И", "I");
            rus_dictionary.Add("Й", "J");
            rus_dictionary.Add("К", "K");
            rus_dictionary.Add("Л", "L");
            rus_dictionary.Add("М", "M");
            rus_dictionary.Add("Н", "N");
            rus_dictionary.Add("О", "O");
            rus_dictionary.Add("П", "P");
            rus_dictionary.Add("Р", "R");
            rus_dictionary.Add("С", "S");
            rus_dictionary.Add("Т", "T");
            rus_dictionary.Add("У", "U");
            rus_dictionary.Add("Ф", "F");
            rus_dictionary.Add("Х", "H");
            rus_dictionary.Add("Ц", "C");
            rus_dictionary.Add("Ч", "Ch");
            rus_dictionary.Add("Ш", "Sh");
            rus_dictionary.Add("Щ", "Sch");
            rus_dictionary.Add("Ъ", "J");
            rus_dictionary.Add("Ы", "I");
            rus_dictionary.Add("Ь", "J");
            rus_dictionary.Add("Э", "E");
            rus_dictionary.Add("Ю", "Yu");
            rus_dictionary.Add("Я", "Ya");
        }

        public Dictionary<string, string> getDictionary()
        {
            RusDictionary();
            return this.rus_dictionary;
        }
    }
}

