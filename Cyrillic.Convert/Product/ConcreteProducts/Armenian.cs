using System.Collections.Generic;

namespace Cyrillic.Convert.Product.ConcreteProducts
{
    public class Armenian : ConversionDictionaries
    {
        private readonly Dictionary<char, string> toLatin;              // Cyrillic (Armenian) -> Latin
        private readonly Dictionary<char, string> startLatin;           // (unused in simplified variant)
        private readonly Dictionary<string, string> special;            // (no multi-char Cyrillic tokens needed here)
        private readonly Dictionary<string, string> toCyrillic;         // Latin -> Cyrillic (Armenian)
        private readonly Dictionary<string, string> startToCyrillic;    // (unused in simplified variant)

        public Armenian()
        {
            // Simplified, deterministic, round?trip friendly mapping based on test expectations.
            // No position dependent variants kept (so start dictionaries remain empty).
            special = new Dictionary<string, string>();
            startLatin = new Dictionary<char, string>();
            startToCyrillic = new Dictionary<string, string>();

            toLatin = new Dictionary<char, string>();
            // Helper local function for concise adding (overwrites if re-added)
            void A(char c, string latin) => toLatin[c] = latin;

            // Uppercase Armenian letters U+0531 – U+0556 (subset as per tests)
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
            A('\u053E', "Ts");  // ? (simplified Ts)
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
            A('\u0550', "Rr");  // ?
            A('\u0551', "C");   // ?
            A('\u0552', "Yw");  // ?
            A('\u0553', "Ph");  // ?
            A('\u0554', "Kh");  // ?
            A('\u0555', "O");   // ?
            A('\u0556', "F");   // ?

            // Lowercase Armenian letters U+0561 – U+0586 (subset as per tests)
            A('\u0561', "a");   // ?
            A('\u0562', "b");   // ?
            A('\u0563', "g");   // ?
            A('\u0564', "d");   // ?
            A('\u0565', "ye");  // ? (always 'ye' for round?trip)
            A('\u0566', "z");   // ?
            A('\u0567', "e");   // ?
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
            A('\u0578', "vo");  // ?
            A('\u0579', "ch");  // ?
            A('\u057A', "p");   // ?
            A('\u057B', "j");   // ?
            A('\u057C', "r");   // ?
            A('\u057D', "s");   // ?
            A('\u057E', "v");   // ?
            A('\u057F', "t");   // ?
            A('\u0580', "rr");  // ?
            A('\u0581', "c");   // ?
            A('\u0582', "yw");  // ?
            A('\u0583', "ph");  // ?
            A('\u0584', "kh");  // ?
            A('\u0585', "o");   // ?
            A('\u0586', "f");   // ?

            // Latin -> Armenian mapping (include explicit multi-char tokens).
            toCyrillic = new Dictionary<string, string>
            {
                // Multi-character (uppercase / lowercase) first for clarity
                { "Tch", "\u0543" }, { "tch", "\u0573" },
                { "Sh",  "\u0547" }, { "sh",  "\u0577" },
                { "Ch",  "\u0549" }, { "ch",  "\u0579" },
                { "Dz",  "\u0541" }, { "dz",  "\u0571" },
                { "Gh",  "\u0542" }, { "gh",  "\u0572" },
                { "Ts",  "\u053E" }, { "ts",  "\u056E" },
                { "Th",  "\u0539" }, { "th",  "\u0569" },
                { "Zh",  "\u053A" }, { "zh",  "\u056A" },
                { "Ye",  "\u0535" }, { "ye",  "\u0565" },
                { "Eh",  "\u0538" }, { "eh",  "\u0568" },
                { "Vo",  "\u0548" }, { "vo",  "\u0578" },
                { "Ph",  "\u0553" }, { "ph",  "\u0583" },
                { "Kh",  "\u0554" }, { "kh",  "\u0584" },
                { "Rr",  "\u0550" }, { "rr",  "\u0580" },
                { "Yw",  "\u0552" }, { "yw",  "\u0582" },

                // Single-character tokens (handled also with auto upper-case in conversion, but explicit for clarity)
                { "A", "\u0531" }, { "a", "\u0561" },
                { "B", "\u0532" }, { "b", "\u0562" },
                { "G", "\u0533" }, { "g", "\u0563" },
                { "D", "\u0534" }, { "d", "\u0564" },
                { "Z", "\u0536" }, { "z", "\u0566" },
                { "E", "\u0537" }, { "e", "\u0567" },
                { "I", "\u053B" }, { "i", "\u056B" },
                { "L", "\u053C" }, { "l", "\u056C" },
                { "X", "\u053D" }, { "x", "\u056D" },
                { "K", "\u053F" }, { "k", "\u056F" },
                { "H", "\u0540" }, { "h", "\u0570" },
                { "M", "\u0544" }, { "m", "\u0574" },
                { "Y", "\u0545" }, { "y", "\u0575" },
                { "N", "\u0546" }, { "n", "\u0576" },
                { "P", "\u054A" }, { "p", "\u057A" },
                { "J", "\u054B" }, { "j", "\u057B" },
                { "R", "\u054C" }, { "r", "\u057C" },
                { "S", "\u054D" }, { "s", "\u057D" },
                { "V", "\u054E" }, { "v", "\u057E" },
                { "T", "\u054F" }, { "t", "\u057F" },
                { "C", "\u0551" }, { "c", "\u0581" },
                { "O", "\u0555" }, { "o", "\u0585" },
                { "F", "\u0556" }, { "f", "\u0586" }
            };
        }

        public override Dictionary<char, string> GetToLatinDictionary() => toLatin;
        public override Dictionary<char, string> GetStartDictionary() => startLatin;
        public override Dictionary<string, string> GetStartToCyrillicDictionary() => startToCyrillic;
        public override Dictionary<string, string> GetToCyrillicDictionary() => toCyrillic;
        public override Dictionary<string, string> GetSpecialDictionary() => special;
    }
}
