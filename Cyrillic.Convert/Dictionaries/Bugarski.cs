using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrillic.Convert.Dictionaries
{
    public class Bugarski
    {
        Dictionary<string, string> bug_dictionary;
        public void BugDictionary()
        {
            bug_dictionary = new Dictionary<string, string>();
            bug_dictionary.Add("а", "a");
            bug_dictionary.Add("б", "b");
            bug_dictionary.Add("в", "v");
            bug_dictionary.Add("г", "g");
            bug_dictionary.Add("д", "d");
            bug_dictionary.Add("е", "e");
            //bug_dictionary.Add("ё", "yo");
            bug_dictionary.Add("ж", "zh");
            bug_dictionary.Add("з", "z");
            bug_dictionary.Add("и", "i");
            bug_dictionary.Add("й", "j");
            bug_dictionary.Add("к", "k");
            bug_dictionary.Add("л", "l");
            bug_dictionary.Add("м", "m");
            bug_dictionary.Add("н", "n");
            bug_dictionary.Add("о", "o");
            bug_dictionary.Add("п", "p");
            bug_dictionary.Add("р", "r");
            bug_dictionary.Add("с", "s");
            bug_dictionary.Add("т", "t");
            bug_dictionary.Add("у", "u");
            bug_dictionary.Add("ф", "f");
            bug_dictionary.Add("х", "h");
            bug_dictionary.Add("ц", "c");
            bug_dictionary.Add("ч", "ch");
            bug_dictionary.Add("ш", "sh");
            bug_dictionary.Add("щ", "sht"); //
            bug_dictionary.Add("ъ", "u"); //
            //bug_dictionary.Add("ы", "i");
            bug_dictionary.Add("ь", "j");
            bug_dictionary.Add("э", "e");
            bug_dictionary.Add("ю", "yu");
            bug_dictionary.Add("я", "ya");
            bug_dictionary.Add("дж", "dzh");
            bug_dictionary.Add("дз", "dz");
            bug_dictionary.Add("пш", "psh");

            bug_dictionary.Add("А", "A");
            bug_dictionary.Add("Б", "B");
            bug_dictionary.Add("В", "V");
            bug_dictionary.Add("Г", "G");
            bug_dictionary.Add("Д", "D");
            bug_dictionary.Add("Е", "E");
            //bug_dictionary.Add("Ё", "Yo");
            bug_dictionary.Add("Ж", "Zh");
            bug_dictionary.Add("З", "Z");
            bug_dictionary.Add("И", "I");
            bug_dictionary.Add("Й", "J");
            bug_dictionary.Add("К", "K");
            bug_dictionary.Add("Л", "L");
            bug_dictionary.Add("М", "M");
            bug_dictionary.Add("Н", "N");
            bug_dictionary.Add("О", "O");
            bug_dictionary.Add("П", "P");
            bug_dictionary.Add("Р", "R");
            bug_dictionary.Add("С", "S");
            bug_dictionary.Add("Т", "T");
            bug_dictionary.Add("У", "U");
            bug_dictionary.Add("Ф", "F");
            bug_dictionary.Add("Х", "H");
            bug_dictionary.Add("Ц", "C");
            bug_dictionary.Add("Ч", "Ch");
            bug_dictionary.Add("Ш", "Sh");
            bug_dictionary.Add("Щ", "Sht");//
            bug_dictionary.Add("Ъ", "U");//
            //bug_dictionary.Add("Ы", "I");
            bug_dictionary.Add("Ь", "U");
            bug_dictionary.Add("Э", "E");
            bug_dictionary.Add("Ю", "Yu");
            bug_dictionary.Add("Я", "Ya");
            bug_dictionary.Add("ДЖ", "Dzh");
            bug_dictionary.Add("ДЗ", "Dz");
            bug_dictionary.Add("ПШ", "Psh");
        }

        public Dictionary<string, string> getDictionary()
        {
            BugDictionary();
            return this.bug_dictionary;
        }

    }
}
