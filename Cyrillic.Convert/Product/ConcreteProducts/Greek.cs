using System.Collections.Generic;

namespace Cyrillic.Convert.Product.ConcreteProducts
{
    public class Greek : ConversionDictionaries
    {
        private readonly Dictionary<char, string> cyrillicToLatinDictionary;
        private readonly Dictionary<char, string> cyrillicStartDictionary;
        private readonly Dictionary<string, string> cyrillicSpecialCases;
        private readonly Dictionary<string, string> latinToCyrillicDictionary;
        private readonly Dictionary<string, string> latinToCyrillicStartDictionary;

        public Greek()
        {
            // Use explicit Unicode escape sequences to avoid any encoding issues.
            latinToCyrillicDictionary = new Dictionary<string, string>
            {
                { "Ch", "\u03A7" }, { "CH", "\u03A7" }, { "ch", "\u03C7" },
                { "Ps", "\u03A8" }, { "PS", "\u03A8" }, { "ps", "\u03C8" },
                { "A", "\u0391" }, { "a", "\u03B1" }, { "V", "\u0392" }, { "v", "\u03B2" },
                { "G", "\u0393" }, { "g", "\u03B3" }, { "D", "\u0394" }, { "d", "\u03B4" },
                { "E", "\u0395" }, { "e", "\u03B5" }, { "Z", "\u0396" }, { "z", "\u03B6" },
                { "I", "\u0399" }, { "i", "\u03B9" }, { "H", "\u0397" }, { "h", "\u03B7" },
                { "T", "\u03A4" }, { "t", "\u03C4" }, { "Y", "\u03A5" }, { "y", "\u03C5" },
                { "K", "\u039A" }, { "k", "\u03BA" }, { "L", "\u039B" }, { "l", "\u03BB" },
                { "M", "\u039C" }, { "m", "\u03BC" }, { "N", "\u039D" }, { "n", "\u03BD" },
                { "X", "\u039E" }, { "x", "\u03BE" }, { "O", "\u039F" }, { "o", "\u03BF" },
                { "P", "\u03A0" }, { "p", "\u03C0" }, { "R", "\u03A1" }, { "r", "\u03C1" },
                { "S", "\u03A3" }, { "s", "\u03C3" }, { "F", "\u03A6" }, { "f", "\u03C6" },
                { "Q", "\u0398" }, { "q", "\u03B8" }, { "W", "\u03A9" }, { "w", "\u03C9" }
            };

            cyrillicToLatinDictionary = new Dictionary<char, string>
            {
                { '\u03A7', "Ch" }, { '\u03C7', "ch" }, { '\u03A8', "Ps" }, { '\u03C8', "ps" },
                { '\u0391', "A" }, { '\u03B1', "a" }, { '\u0392', "V" }, { '\u03B2', "v" },
                { '\u0393', "G" }, { '\u03B3', "g" }, { '\u0394', "D" }, { '\u03B4', "d" },
                { '\u0395', "E" }, { '\u03B5', "e" }, { '\u0396', "Z" }, { '\u03B6', "z" },
                { '\u0397', "I" }, { '\u03B7', "i" }, { '\u0398', "T" }, { '\u03B8', "t" },
                { '\u0399', "I" }, { '\u03B9', "i" }, { '\u039A', "K" }, { '\u03BA', "k" },
                { '\u039B', "L" }, { '\u03BB', "l" }, { '\u039C', "M" }, { '\u03BC', "m" },
                { '\u039D', "N" }, { '\u03BD', "n" }, { '\u039E', "X" }, { '\u03BE', "x" },
                { '\u039F', "O" }, { '\u03BF', "o" }, { '\u03A0', "P" }, { '\u03C0', "p" },
                { '\u03A1', "R" }, { '\u03C1', "r" }, { '\u03A3', "S" }, { '\u03C3', "s" }, { '\u03C2', "s" },
                { '\u03A4', "T" }, { '\u03C4', "t" }, { '\u03A5', "Y" }, { '\u03C5', "y" },
                { '\u03A6', "F" }, { '\u03C6', "f" }, { '\u03A9', "O" }, { '\u03C9', "o" }
            };

            cyrillicSpecialCases = new Dictionary<string, string>();
            cyrillicStartDictionary = new Dictionary<char, string>();
            latinToCyrillicStartDictionary = new Dictionary<string, string>();
        }

        public override Dictionary<char, string> GetToLatinDictionary() => cyrillicToLatinDictionary;
        public override Dictionary<char, string> GetStartDictionary() => cyrillicStartDictionary;
        public override Dictionary<string, string> GetStartToCyrillicDictionary() => latinToCyrillicStartDictionary;
        public override Dictionary<string, string> GetToCyrillicDictionary() => latinToCyrillicDictionary;
        public override Dictionary<string, string> GetSpecialDictionary() => cyrillicSpecialCases;
    }
}
