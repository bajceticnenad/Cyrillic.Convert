using System.Collections.Generic;

namespace Cyrillic.Convert.Product.ConcreteProducts
{
    public class Armenian : ConversionDictionaries
    {
        private readonly Dictionary<char,string> toLatin;
        private readonly Dictionary<char,string> startLatin;
        private readonly Dictionary<string,string> special; // empty for simplified version
        private readonly Dictionary<string,string> toCyrillic;
        private readonly Dictionary<string,string> startToCyrillic;

        public Armenian()
        {
            // No multi-char Cyrillic specials (simplified) – ensures deterministic round-trip.
            special = new Dictionary<string, string>();

            toLatin = new Dictionary<char, string>();
            void A(char c, string t) => toLatin[c] = t; // overwrite-safe

            // Uppercase (unique ASCII tokens)
            A('\u0531', "A");   // ?
            A('\u0532', "B");   // ?
            A('\u0533', "G");   // ?
            A('\u0534', "D");   // ?
            A('\u0535', "Ye");  // ?
            A('\u0536', "Z");   // ?
            A('\u0537', "E");   // ?
            A('\u0538', "Eh");  // ?
            A('\u0539', "Th");  // ?
            A('\u053A', "Zh");  // ?
            A('\u053B', "I");   // ?
            A('\u053C', "L");   // ?
            A('\u053D', "X");   // ?
            A('\u053E', "Ts");  // ? (simplified from Tc)
            A('\u053F', "K");   // ?
            A('\u0540', "H");   // ?
            A('\u0541', "Dz");  // ?
            A('\u0542', "Gh");  // ?
            A('\u0543', "Tch"); // ?
            A('\u0544', "M");   // ?
            A('\u0545', "Y");   // ?
            A('\u0546', "N");   // ?
            A('\u0547', "Sh");  // ?
            A('\u0548', "Vo");  // ?
            A('\u0549', "Ch");  // ?
            A('\u054A', "P");   // ?
            A('\u054B', "J");   // ?
            A('\u054C', "R");   // ?
            A('\u054D', "S");   // ?
            A('\u054E', "V");   // ?
            A('\u054F', "T");   // ?
            A('\u0550', "Rr");  // ? (distinct)
            A('\u0551', "C");   // ?
            A('\u0552', "Yw");  // ?
            A('\u0553', "Ph");  // ?
            A('\u0554', "Kh");  // ?
            A('\u0555', "O");   // ?
            A('\u0556', "F");   // ?

            // Lowercase (ensure uniqueness; use e1 for ?? to avoid collision with ?)
            A('\u0561', "a");   // ?
            A('\u0562', "b");   // ?
            A('\u0563', "g");   // ?
            A('\u0564', "d");   // ?
            A('\u0565', "ye");  // ? (lower of ? – ye)
            A('\u0566', "z");   // ?
            A('\u0567', "e");   // ? (distinct from ye)
            A('\u0568', "eh");  // ?
            A('\u0569', "th");  // ?
            A('\u056A', "zh");  // ?
            A('\u056B', "i");   // ?
            A('\u056C', "l");   // ?
            A('\u056D', "x");   // ?
            A('\u056E', "ts");  // ?
            A('\u056F', "k");   // ?
            A('\u0570', "h");   // ?
            A('\u0571', "dz");  // ?
            A('\u0572', "gh");  // ?
            A('\u0573', "tch"); // ?
            A('\u0574', "m");   // ?
            A('\u0575', "y");   // ?
            A('\u0576', "n");   // ?
            A('\u0577', "sh");  // ?
            A('\u0578', "vo");  // ? (contextually 'o' but keep vo to disambiguate)
            A('\u0579', "ch");  // ?
            A('\u057A', "p");   // ?
            A('\u057B', "j");   // ?
            A('\u057C', "r");   // ?
            A('\u057D', "s");   // ?
            A('\u057E', "v");   // ?
            A('\u057F', "t");   // ?
            A('\u0580', "rr");  // ? (distinct from ?=r)
            A('\u0581', "c");   // ?
            A('\u0582', "yw");  // ?
            A('\u0583', "ph");  // ?
            A('\u0584', "kh");  // ?
            A('\u0585', "o");   //ordial'o' but keep vo to disambiguate)
            A('\u0586', "f");   // ?

            toCyrillic = new Dictionary<string,string>();
            foreach (var kv in toLatin)
                toCyrillic[kv.Value] = kv.Key.ToString();

            startLatin = new Dictionary<char,string>();
            startToCyrillic = new Dictionary<string,string>();
        }

        public override Dictionary<char,string> GetToLatinDictionary() => toLatin;
        public override Dictionary<char,string> GetStartDictionary() => startLatin;
        public override Dictionary<string,string> GetStartToCyrillicDictionary() => startToCyrillic;
        public override Dictionary<string,string> GetToCyrillicDictionary() => toCyrillic;
        public override Dictionary<string,string> GetSpecialDictionary() => special;
    }
}
