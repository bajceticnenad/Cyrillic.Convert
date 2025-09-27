using System.Collections.Generic;

namespace Cyrillic.Convert.Product.ConcreteProducts
{
    public class Macedonian : ConversionDictionaries
    {
        private readonly Dictionary<char,string> toLatin;
        private readonly Dictionary<char,string> startLatin;
        private readonly Dictionary<string,string> special; // multi-char Cyrillic -> Latin (digraph/special)
        private readonly Dictionary<string,string> toCyrillic;
        private readonly Dictionary<string,string> startToCyrillic;

        public Macedonian()
        {
            // Use explicit Unicode escapes to avoid encoding degradation (which caused duplicate '?' keys).
            special = new Dictionary<string, string>
            {
                {"\u0403", "Gj"}, {"\u0453", "gj"}, // ? ?
                {"\u0405", "Dz"}, {"\u0455", "dz"}, // ? ?
                {"\u040A", "Nj"}, {"\u045A", "nj"}, // ? ?
                {"\u0409", "Lj"}, {"\u0459", "lj"}, // ? ?
                {"\u040C", "Kj"}, {"\u045C", "kj"}, // ? ?
                {"\u040F", "Dj"}, {"\u045F", "dj"}, // ? ?
                {"\u0427", "Ch"}, {"\u0447", "ch"}, // ? ?
                {"\u0416", "zh"}, {"\u0436", "zh"}, // ? ? (both map to lower zh)
                {"\u0428", "Sh"}, {"\u0448", "sh"}  // ? ?
            };

            toLatin = new Dictionary<char, string>();
            void L(char c, string v) => toLatin[c] = v;

            L('\u0410', "A"); L('\u0430', "a");
            L('\u0411', "B"); L('\u0431', "b");
            L('\u0412', "V"); L('\u0432', "v");
            L('\u0413', "G"); L('\u0433', "g");
            L('\u0414', "D"); L('\u0434', "d");
            L('\u0415', "E"); L('\u0435', "e");
            L('\u0417', "Z"); L('\u0437', "z");
            L('\u0418', "I"); L('\u0438', "i");
            L('\u0408', "J"); L('\u0458', "j"); // ? ?
            L('\u041A', "K"); L('\u043A', "k");
            L('\u041B', "L"); L('\u043B', "l");
            L('\u041C', "M"); L('\u043C', "m");
            L('\u041D', "N"); L('\u043D', "n");
            L('\u041E', "O"); L('\u043E', "o");
            L('\u041F', "P"); L('\u043F', "p");
            L('\u0420', "R"); L('\u0440', "r");
            L('\u0421', "S"); L('\u0441', "s");
            L('\u0422', "T"); L('\u0442', "t");
            L('\u0423', "U"); L('\u0443', "u");
            L('\u0424', "F"); L('\u0444', "f");
            L('\u0425', "H"); L('\u0445', "h");
            L('\u042A', "?"); L('\u044A', "?"); // ? ?

            // Reverse mapping Latin -> Cyrillic (one-to-one per token) including digraphs
            toCyrillic = new Dictionary<string, string>();
            foreach (var kv in toLatin)
                toCyrillic[kv.Value] = kv.Key.ToString();

            void R(string lat, string cyr) => toCyrillic[lat] = cyr;
            R("Gj", "\u0403"); R("gj", "\u0453");
            R("Dz", "\u0405"); R("dz", "\u0455");
            R("Nj", "\u040A"); R("nj", "\u045A");
            R("Lj", "\u0409"); R("lj", "\u0459");
            R("Kj", "\u040C"); R("kj", "\u045C");
            R("Dj", "\u040F"); R("dj", "\u045F");
            R("Ch", "\u0427"); R("ch", "\u0447");
            R("Sh", "\u0428"); R("sh", "\u0448");
            R("Zh", "\u0416"); R("zh", "\u0436"); // allow Zh variant too

            startLatin = new Dictionary<char, string>();
            startToCyrillic = new Dictionary<string, string>();
        }

        public override Dictionary<char, string> GetToLatinDictionary() => toLatin;
        public override Dictionary<char, string> GetStartDictionary() => startLatin;
        public override Dictionary<string, string> GetStartToCyrillicDictionary() => startToCyrillic;
        public override Dictionary<string, string> GetToCyrillicDictionary() => toCyrillic;
        public override Dictionary<string, string> GetSpecialDictionary() => special;
    }
}
