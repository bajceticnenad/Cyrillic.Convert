using System.Collections.Generic;

namespace Cyrillic.Convert.Product.ConcreteProducts
{
    public class Belarusian : ConversionDictionaries
    {
        private readonly Dictionary<char,string> toLatin;              // Cyrillic char -> Latin
        private readonly Dictionary<char,string> startLatin;           // Start-of-word overrides
        private readonly Dictionary<string,string> special;            // Affricates only
        private readonly Dictionary<string,string> toCyrillic;         // Latin token -> Cyrillic string
        private readonly Dictionary<string,string> startToCyrillic;    // Start-of-word Latin overrides

        public Belarusian()
        {
            special = new Dictionary<string,string>
            {
                { "\u0414\u0416", "D\u017D" }, // ?? -> DŽ
                { "\u0414\u0417", "Dz" },      // ?? -> Dz
                { "\u0434\u0436", "d\u017E" }, // ?? -> dž
                { "\u0434\u0437", "dz" }       // ?? -> dz
            };

            toLatin = new Dictionary<char,string>();
            void L(char k,string v) => toLatin[k] = v;

            L('\u0410', "A");  L('\u0430', "a");
            L('\u0411', "B");  L('\u0431', "b");
            L('\u0412', "V");  L('\u0432', "v");
            L('\u0413', "H");  L('\u0433', "h");
            L('\u0414', "D");  L('\u0434', "d");
            L('\u0416', "\u017D"); L('\u0436', "\u017E"); // Ž ž
            L('\u0417', "Z");  L('\u0437', "z");
            L('\u0406', "I");  L('\u0456', "i");
            L('\u0419', "J");  L('\u0439', "j");
            L('\u041A', "K");  L('\u043A', "k");
            L('\u041B', "L");  L('\u043B', "l");
            L('\u041C', "M");  L('\u043C', "m");
            L('\u041D', "N");  L('\u043D', "n");
            L('\u041E', "O");  L('\u043E', "o");
            L('\u041F', "P");  L('\u043F', "p");
            L('\u0420', "R");  L('\u0440', "r");
            L('\u0421', "S");  L('\u0441', "s");
            L('\u0422', "T");  L('\u0442', "t");
            L('\u0423', "U");  L('\u0443', "u");
            L('\u040E', "\u016C"); L('\u045E', "\u016D"); // ? -> ?, ? -> ?
            L('\u0424', "F");  L('\u0444', "f");
            L('\u0426', "C");  L('\u0446', "c");
            L('\u0427', "\u010C"); L('\u0447', "\u010D"); // ? ?
            L('\u0428', "\u0160"); L('\u0448', "\u0161"); // Š š
            L('\u042B', "Y");  L('\u044B', "y");
            L('\u042C', "\u02C8");  L('\u044C', "'"); // ? -> ?, ? -> '
            L('\u042D', "E");  L('\u044D', "e");

            startLatin = new Dictionary<char,string>
            {
                { '\u0415', "Je" }, { '\u0435', "je" },
                { '\u0401', "Jo" }, { '\u0451', "jo" },
                { '\u042E', "Ju" }, { '\u044E', "ju" },
                { '\u042F', "Ja" }, { '\u044F', "ja" }
            };
            // Non-start (after consonant) forms
            L('\u0415', "Ie"); L('\u0435', "ie");
            L('\u0401', "Io"); L('\u0451', "io");
            L('\u042E', "Iu"); L('\u044E', "iu");
            L('\u042F', "Ia"); L('\u044F', "ia");

            toCyrillic = new Dictionary<string,string>();
            foreach (var kv in toLatin)
                if (!toCyrillic.ContainsKey(kv.Value))
                    toCyrillic.Add(kv.Value, kv.Key.ToString());

            // Override soft sign mappings
            toCyrillic["\u02C8"] = "\u042C"; // ? -> ?
            toCyrillic["'"] = "\u044C";       // ' -> ?
            toCyrillic["\u2019"] = "\u042C"; // ’ -> ? (alias)

            // Affricates
            toCyrillic["D\u017D"] = "\u0414\u0416"; toCyrillic["d\u017E"] = "\u0434\u0436";
            toCyrillic["Dz"] = "\u0414\u0417";       toCyrillic["dz"] = "\u0434\u0437";
            // Palatalized S
            toCyrillic["\u015A"] = "\u0421\u042C"; toCyrillic["\u015B"] = "\u0441\u044C";
            // Vowel digraphs (start + non-start variants)
            toCyrillic["Je"] = "\u0415"; toCyrillic["je"] = "\u0435"; toCyrillic["Ie"] = "\u0415"; toCyrillic["ie"] = "\u0435";
            toCyrillic["Jo"] = "\u0401"; toCyrillic["jo"] = "\u0451"; toCyrillic["Io"] = "\u0401"; toCyrillic["io"] = "\u0451";
            toCyrillic["Ju"] = "\u042E"; toCyrillic["ju"] = "\u044E"; toCyrillic["Iu"] = "\u042E"; toCyrillic["iu"] = "\u044E";
            toCyrillic["Ja"] = "\u042F"; toCyrillic["ja"] = "\u044F"; toCyrillic["Ia"] = "\u042F"; toCyrillic["ia"] = "\u044F";

            startToCyrillic = new Dictionary<string,string>
            {
                { "Je", "\u0415" }, { "je", "\u0435" },
                { "Jo", "\u0401" }, { "jo", "\u0451" },
                { "Ju", "\u042E" }, { "ju", "\u044E" },
                { "Ja", "\u042F" }, { "ja", "\u044F" },
                { "\u02C8", "\u042C" }, // ? at word start -> ?
                { "\u2019", "\u042C" }  // ’ at word start -> ?
            };
        }

        public override Dictionary<char,string> GetToLatinDictionary() => toLatin;
        public override Dictionary<char,string> GetStartDictionary() => startLatin;
        public override Dictionary<string,string> GetStartToCyrillicDictionary() => startToCyrillic;
        public override Dictionary<string,string> GetToCyrillicDictionary() => toCyrillic;
        public override Dictionary<string,string> GetSpecialDictionary() => special;
    }
}
