using System.Collections.Generic;

namespace Cyrillic.Convert.Product.ConcreteProducts
{
    public class Kazakh : ConversionDictionaries
    {
        private readonly Dictionary<char,string> toLatin;
        private readonly Dictionary<char,string> startLatin; // not used (no word-start variants in provided mapping)
        private readonly Dictionary<string,string> special;   // none (all source units are single chars)
        private readonly Dictionary<string,string> toCyrillic;
        private readonly Dictionary<string,string> startToCyrillic; // not used

        public Kazakh()
        {
            startLatin = new Dictionary<char,string>();
            startToCyrillic = new Dictionary<string,string>();
            special = new Dictionary<string,string>();

            // Build Cyrillic -> Latin map
            toLatin = new Dictionary<char,string>();
            void L(char c, string v) => toLatin[c] = v; // helper

            // Variations and special characters
            L('?', "Gh"); L('?', "gh"); L('?', "Yo"); L('?', "yo"); L('?', "Zh"); L('?', "zh");
            L('?', "Ng"); L('?', "ng"); L('?', "Kh"); L('?', "kh"); L('?', "Ts"); L('?', "ts");
            L('?', "Ch"); L('?', "ch"); L('?', "Sh"); L('?', "sh"); L('?', "Shch"); L('?', "shch");
            L('?', "Yu"); L('?', "yu"); L('?', "Ya"); L('?', "ya");

            // All other letters
            L('?', "A"); L('?', "a"); L('?', "B"); L('?', "b"); L('?', "V"); L('?', "v");
            L('?', "G"); L('?', "g"); L('?', "D"); L('?', "d"); L('?', "E"); L('?', "e");
            L('?', "Z"); L('?', "z"); L('?', "?"); L('?', "?"); L('?', "Y"); L('?', "y");
            L('?', "K"); L('?', "k"); L('?', "L"); L('?', "l"); L('?', "M"); L('?', "m");
            L('?', "N"); L('?', "n"); L('?', "O"); L('?', "o"); L('?', "P"); L('?', "p");
            L('?', "R"); L('?', "r"); L('?', "S"); L('?', "s"); L('?', "T"); L('?', "t");
            L('?', "?"); L('?', "?"); L('?', "F"); L('?', "f"); L('?', "Ü"); L('?', "ü");
            L('?', "H"); L('?', "h"); L('?', "?"); L('?', "?"); L('?', "U"); L('?', "u");
            L('?', "Ö"); L('?', "ö"); L('?', "Q"); L('?', "q"); L('?', "I"); L('?', "i");
            // Signs mapped to empty string (hard / soft) – data loss by design per original mapping
            L('?', ""); L('?', ""); L('?', ""); L('?', "");

            // Build Latin -> Cyrillic reverse map (skip empty values like PHP array_filter)
            toCyrillic = new Dictionary<string,string>();
            foreach (var kv in toLatin)
            {
                if (string.IsNullOrEmpty(kv.Value)) continue; // skip empties
                if (!toCyrillic.ContainsKey(kv.Value))
                    toCyrillic[kv.Value] = kv.Key.ToString();
            }

            // Additional explicit tokens for uppercase multi-letter sequences & fallbacks
            void R(string token, char cyr) { if (!toCyrillic.ContainsKey(token)) toCyrillic[token] = cyr.ToString(); }
            R("SHCH", '?'); R("GH", '?'); R("YO", '?'); R("ZH", '?'); R("NG", '?'); R("KH", '?');
            R("SH", '?'); R("YA", '?'); R("YU", '?'); R("CH", '?'); R("TS", '?');
            
            R("J", '?'); R("j", '?'); R("I", '?'); R("i", '?');
        }

        public override Dictionary<char,string> GetToLatinDictionary() => toLatin;
        public override Dictionary<char,string> GetStartDictionary() => startLatin;
        public override Dictionary<string,string> GetStartToCyrillicDictionary() => startToCyrillic;
        public override Dictionary<string,string> GetToCyrillicDictionary() => toCyrillic;
        public override Dictionary<string,string> GetSpecialDictionary() => special;
    }
}
