using Cyrillic.Convert.Creator.ConcreteCreator;
using Cyrillic.Convert.Enums;
using Cyrillic.Convert.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Cyrillic.Convert
{
    public class Conversion
    {
        // ── Belarusian СЬ/сь sentinel characters (Unicode Private Use Area).
        // Using PUA codepoints avoids any collision with real input text.
        private const char BelarusianSentinelSUpper = '\uE001';
        private const char BelarusianSentinelSLower = '\uE002';

        // Characters that mark a word boundary (start-of-word trigger).
        private static readonly char[] WordBoundaryChars = { ' ', '\t', '\n', '\r' };

        #region Factory
        private ConversionDictionaries GetConcreteProduct(Language language)
        {
            switch (language)
            {
                case Language.Serbian:    return new SerbianConversionFactory().GetConversionDictionaries();
                case Language.Russian:    return new RussianConversionFactory().GetConversionDictionaries();
                case Language.Ukrainian:  return new UkrainianConversionFactory().GetConversionDictionaries();
                case Language.Bulgarian:  return new BulgarianConversionFactory().GetConversionDictionaries();
                case Language.Georgian:   return new GeorgianConversionFactory().GetConversionDictionaries();
                case Language.Greek:      return new GreekConversionFactory().GetConversionDictionaries();
                case Language.Belarusian: return new BelarusianConversionFactory().GetConversionDictionaries();
                case Language.Macedonian: return new MacedonianConversionFactory().GetConversionDictionaries();
                case Language.Armenian:   return new ArmenianConversionFactory().GetConversionDictionaries();
                case Language.Kazakh:     return new KazakhConversionFactory().GetConversionDictionaries();
                default:
                    throw new ArgumentOutOfRangeException(nameof(language), language,
                        "Unsupported language. Add a new ConcreteCreator and update this switch.");
            }
        }
        #endregion Factory

        #region Conversion

        private string? ConvertCyrillicToLatin(Language language, string? text)
        {
            if (string.IsNullOrEmpty(text)) return text;

            var letters = GetConcreteProduct(language);

            // After the null guard above, text is non-null for the rest of this method.
            // The local 't' avoids CS8602 false positives: netstandard2.0 reference
            // assemblies lack [NotNullWhen(false)] on IsNullOrEmpty and
            // [MaybeNullWhen(false)] on Dictionary.TryGetValue.
            string t = text!;

            if (language == Language.Belarusian)
            {
                // Replace the two-char sequences СЬ/сь with PUA sentinels so the
                // character-by-character loop below does not split them incorrectly.
                t = t.Replace("СЬ", BelarusianSentinelSUpper.ToString())
                     .Replace("сь", BelarusianSentinelSLower.ToString());
            }

            var specialPairs = letters.GetSpecialDictionary();
            if (specialPairs.Count > 0)
            {
                foreach (var pair in specialPairs.OrderByDescending(p => p.Key.Length))
                    t = t.Replace(pair.Key, pair.Value);
            }

            var startDict = letters.GetStartDictionary();
            var latinDict = letters.GetToLatinDictionary();
            var builder   = new StringBuilder(t.Length * 2);
            bool isWordStart = true; // treat beginning of string as start-of-word

            for (int i = 0; i < t.Length; ++i)
            {
                char c = t[i];

                if (isWordStart && startDict.TryGetValue(c, out string? startReplacement))
                {
                    builder.Append(startReplacement!);
                    isWordStart = false;
                    continue;
                }

                if (latinDict.TryGetValue(c, out string? replacement))
                {
                    builder.Append(replacement!);
                    isWordStart = false;
                }
                else
                {
                    builder.Append(c);
                    isWordStart = IsWordBoundary(c);
                }
            }

            var result = builder.ToString();

            if (language == Language.Belarusian)
            {
                result = result
                    .Replace(BelarusianSentinelSUpper.ToString(), "Ś")
                    .Replace(BelarusianSentinelSLower.ToString(), "ś");
            }

            return result.Normalize(NormalizationForm.FormC);
        }

        private string? ConvertLatinToCyrillic(Language language, string? text)
        {
            if (string.IsNullOrEmpty(text)) return text;

            var letters = GetConcreteProduct(language);

            // Same null-safety approach — use non-nullable local after null guard.
            string t = text!;

            if (language != Language.Macedonian)
            {
                var specialPairs = letters.GetSpecialDictionary();
                if (specialPairs.Count > 0)
                {
                    foreach (var pair in specialPairs.OrderByDescending(p => p.Value.Length))
                        t = t.Replace(pair.Value, pair.Key);
                }
            }

            var startDict = letters.GetStartToCyrillicDictionary();

            int previousEmptyIndex = -1;
            do
            {
                int length = t.Length;
                int i = previousEmptyIndex + 1;
                for (; i < length; ++i)
                {
                    char c = t[i];
                    if (IsWordBoundary(c)) continue;
                    foreach (var pr in startDict)
                    {
                        if (pr.Key.Length > length - i) continue;
                        if (t.IndexOf(pr.Key, i, pr.Key.Length) != i) continue;
                        t = t.Substring(0, i) + pr.Value + t.Substring(i + pr.Key.Length);
                        break;
                    }
                    break;
                }
                previousEmptyIndex = i;
                previousEmptyIndex = t.IndexOfAny(WordBoundaryChars, previousEmptyIndex);
            } while (previousEmptyIndex != -1);

            var toCyr = letters.GetToCyrillicDictionary();
            if (toCyr.Count > 0)
            {
                foreach (var pair in toCyr.OrderByDescending(p => p.Key.Length))
                {
                    t = t.Replace(pair.Key, pair.Value);
                    if (pair.Key.Length == 1)
                    {
                        var upperKey = pair.Key.ToUpper();
                        if (upperKey != pair.Key)
                            t = t.Replace(upperKey, pair.Value.ToUpper());
                    }
                }
            }

            return t.Normalize(NormalizationForm.FormC);
        }

        #endregion Conversion

        #region Serbian
        public string? SerbianCyrillicToLatin(string? text)   => ConvertCyrillicToLatin(Language.Serbian, text);
        public string? SerbianLatinToCyrillic(string? text)   => ConvertLatinToCyrillic(Language.Serbian, text);
        #endregion Serbian

        #region Russian
        public string? RussianCyrillicToLatin(string? text)   => ConvertCyrillicToLatin(Language.Russian, text);
        public string? RussianLatinToCyrillic(string? text)   => ConvertLatinToCyrillic(Language.Russian, text);
        #endregion Russian

        #region Bulgarian
        public string? BulgarianCyrillicToLatin(string? text) => ConvertCyrillicToLatin(Language.Bulgarian, text);
        public string? BulgarianLatinToCyrillic(string? text) => ConvertLatinToCyrillic(Language.Bulgarian, text);
        #endregion Bulgarian

        #region Ukrainian
        public string? UkrainianCyrillicToLatin(string? text) => ConvertCyrillicToLatin(Language.Ukrainian, text);
        public string? UkrainianLatinToCyrillic(string? text) => ConvertLatinToCyrillic(Language.Ukrainian, text);
        #endregion Ukrainian

        #region Georgian
        public string? GeorgianCyrillicToLatin(string? text)  => ConvertCyrillicToLatin(Language.Georgian, text);
        public string? GeorgianLatinToCyrillic(string? text)  => ConvertLatinToCyrillic(Language.Georgian, text);
        #endregion Georgian

        #region Greek
        public string? GreekCyrillicToLatin(string? text)     => ConvertCyrillicToLatin(Language.Greek, text);
        public string? GreekLatinToCyrillic(string? text)     => ConvertLatinToCyrillic(Language.Greek, text);
        #endregion Greek

        #region Belarusian
        public string? BelarusianCyrillicToLatin(string? text) => ConvertCyrillicToLatin(Language.Belarusian, text);
        public string? BelarusianLatinToCyrillic(string? text) => ConvertLatinToCyrillic(Language.Belarusian, text);
        #endregion Belarusian

        #region Macedonian
        public string? MacedonianCyrillicToLatin(string? text) => ConvertCyrillicToLatin(Language.Macedonian, text);
        public string? MacedonianLatinToCyrillic(string? text) => ConvertLatinToCyrillic(Language.Macedonian, text);
        #endregion Macedonian

        #region Armenian
        public string? ArmenianCyrillicToLatin(string? text)  => ConvertCyrillicToLatin(Language.Armenian, text);
        public string? ArmenianLatinToCyrillic(string? text)  => ConvertLatinToCyrillic(Language.Armenian, text);
        #endregion Armenian

        #region Kazakh
        public string? KazakhCyrillicToLatin(string? text)    => ConvertCyrillicToLatin(Language.Kazakh, text);
        public string? KazakhLatinToCyrillic(string? text)    => ConvertLatinToCyrillic(Language.Kazakh, text);
        #endregion Kazakh

        private static bool IsWordBoundary(char c) =>
            c == ' ' || c == '\t' || c == '\n' || c == '\r';
    }
}
