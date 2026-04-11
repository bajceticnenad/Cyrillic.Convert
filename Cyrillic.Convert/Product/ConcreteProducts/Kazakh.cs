using System.Collections.Generic;

namespace Cyrillic.Convert.Product.ConcreteProducts
{
    internal class Kazakh : ConversionDictionaries
    {
        private readonly Dictionary<char, string> toLatin;
        private readonly Dictionary<char, string> startLatin;
        private readonly Dictionary<string, string> special;
        private readonly Dictionary<string, string> toCyrillic;
        private readonly Dictionary<string, string> startToCyrillic;

        public Kazakh()
        {
            startLatin      = new Dictionary<char, string>();
            startToCyrillic = new Dictionary<string, string>();
            special         = new Dictionary<string, string>();

            toLatin = new Dictionary<char, string>
            {
                // ── Digraphs and letters with multi-character Latin equivalents ──
                { 'Ғ', "Gh"   }, { 'ғ', "gh"   },
                { 'Ё', "Yo"   }, { 'ё', "yo"   },
                { 'Ж', "Zh"   }, { 'ж', "zh"   },
                { 'Ң', "Ng"   }, { 'ң', "ng"   },
                { 'Х', "Kh"   }, { 'х', "kh"   },
                { 'Ц', "Ts"   }, { 'ц', "ts"   },
                { 'Ч', "Ch"   }, { 'ч', "ch"   },
                { 'Ш', "Sh"   }, { 'ш', "sh"   },
                { 'Щ', "Shch" }, { 'щ', "shch" },
                { 'Ю', "Yu"   }, { 'ю', "yu"   },
                { 'Я', "Ya"   }, { 'я', "ya"   },

                // ── Standard letters ──
                { 'А', "A"  }, { 'а', "a"  },
                { 'Б', "B"  }, { 'б', "b"  },
                { 'В', "V"  }, { 'в', "v"  },
                { 'Г', "G"  }, { 'г', "g"  },
                { 'Д', "D"  }, { 'д', "d"  },
                { 'Е', "E"  }, { 'е', "e"  },
                { 'З', "Z"  }, { 'з', "z"  },

                // И/и → Ī/ī  (I with macron, distinct from plain І/і)
                { 'И', "Ī"  }, { 'и', "ī"  },

                { 'Й', "Y"  }, { 'й', "y"  },
                { 'К', "K"  }, { 'к', "k"  },
                { 'Л', "L"  }, { 'л', "l"  },
                { 'М', "M"  }, { 'м', "m"  },
                { 'Н', "N"  }, { 'н', "n"  },
                { 'О', "O"  }, { 'о', "o"  },
                { 'П', "P"  }, { 'п', "p"  },
                { 'Р', "R"  }, { 'р', "r"  },
                { 'С', "S"  }, { 'с', "s"  },
                { 'Т', "T"  }, { 'т', "t"  },

                // У/у → Ū/ū  (U with macron)
                { 'У', "Ū"  }, { 'у', "ū"  },

                { 'Ф', "F"  }, { 'ф', "f"  },

                // Ү/ү → Ü/ü  (U with umlaut — Kazakh-specific)
                { 'Ү', "Ü"  }, { 'ү', "ü"  },

                // Һ/һ → H/h
                { 'Һ', "H"  }, { 'һ', "h"  },

                // Э/э → Ė/ė  (E with dot above — Kazakh-specific)
                { 'Э', "Ė"  }, { 'э', "ė"  },

                // Ұ/ұ → U/u  (distinct from У/у above)
                { 'Ұ', "U"  }, { 'ұ', "u"  },

                // Ө/ө → Ö/ö
                { 'Ө', "Ö"  }, { 'ө', "ö"  },

                // Қ/қ → Q/q
                { 'Қ', "Q"  }, { 'қ', "q"  },

                // І/і → I/i  (Ukrainian І, plain ASCII I)
                { 'І', "I"  }, { 'і', "i"  },

                // Hard/soft signs → empty string (data loss by design)
                { 'Ъ', "" }, { 'ъ', "" },
                { 'Ь', "" }, { 'ь', "" },
            };

            // ── Build Latin → Cyrillic reverse map from toLatin ──
            toCyrillic = new Dictionary<string, string>();
            foreach (var kv in toLatin)
            {
                if (string.IsNullOrEmpty(kv.Value)) continue;
                if (!toCyrillic.ContainsKey(kv.Value))
                    toCyrillic[kv.Value] = kv.Key.ToString();
            }

            // ── Supplemental all-uppercase multi-letter tokens ──
            void R(string token, char cyr)
            {
                if (!toCyrillic.ContainsKey(token))
                    toCyrillic[token] = cyr.ToString();
            }

            R("SHCH", 'Щ');
            R("GH",   'Ғ'); R("YO", 'Ё'); R("ZH", 'Ж');
            R("NG",   'Ң'); R("KH", 'Х'); R("TS", 'Ц');
            R("CH",   'Ч'); R("SH", 'Ш'); R("YU", 'Ю');
            R("YA",   'Я');

            // J/j as aliases for Й/й
            R("J", 'Й'); R("j", 'й');
        }

        public override Dictionary<char, string>   GetToLatinDictionary()          => toLatin;
        public override Dictionary<char, string>   GetStartDictionary()            => startLatin;
        public override Dictionary<string, string> GetStartToCyrillicDictionary()  => startToCyrillic;
        public override Dictionary<string, string> GetToCyrillicDictionary()       => toCyrillic;
        public override Dictionary<string, string> GetSpecialDictionary()          => special;
    }
}
