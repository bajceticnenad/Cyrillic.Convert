using Cyrillic.Convert.Creator.ConcreteCreator;
using Cyrillic.Convert.Enums;
using Cyrillic.Convert.Product;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Cyrillic.Convert
{
    public class Conversion
    {
        #region Factory
        private ConversionDictionaries GetConcreteProduct(Language language)
        {
            switch (language)
            {
                case Language.Serbian:   return new SerbianConversionFactory().GetConversionDictionaries();
                case Language.Russian:   return new RussianConversionFactory().GetConversionDictionaries();
                case Language.Ukrainian: return new UkrainianConversionFactory().GetConversionDictionaries();
                case Language.Bulgarian: return new BulgarianConversionFactory().GetConversionDictionaries();
                case Language.Georgian:  return new GeorgianConversionFactory().GetConversionDictionaries();
                case Language.Greek:     return new GreekConversionFactory().GetConversionDictionaries();
                case Language.Belarusian:return new BelarusianConversionFactory().GetConversionDictionaries();
                case Language.Macedonian:return new MacedonianConversionFactory().GetConversionDictionaries();
                case Language.Armenian:  return new ArmenianConversionFactory().GetConversionDictionaries();
                default: return null;
            }
        }
        #endregion Factory

        #region Conversion

        private string ConvertCyrillicToLatin(Language language, string text)
        {
            var letters = GetConcreteProduct(language);
            if (string.IsNullOrEmpty(text) || letters == null) return text;

            if (language == Language.Belarusian)
            {
                text = text.Replace("СЬ", "__SOFT_S__").Replace("сь", "__soft_s__");
            }

            var specialPairs = letters.GetSpecialDictionary();
            if (specialPairs.Count > 0)
            {
                foreach (var pair in specialPairs.OrderByDescending(p => p.Key.Length))
                    text = text.Replace(pair.Key, pair.Value);
            }

            var start_dict = letters.GetStartDictionary();
            var dict = letters.GetToLatinDictionary();
            StringBuilder builder = new StringBuilder(text.Length * 2);
            bool empty_prev = true; // treat beginning as start-of-word
            for (int i = 0; i < text.Length; ++i)
            {
                char c = text[i];
                if ((empty_prev) && start_dict.TryGetValue(c, out string start_tmp_str))
                {
                    builder.Append(start_tmp_str);
                    empty_prev = false;
                    continue;
                }
                if (dict.TryGetValue(c, out string rep))
                {
                    builder.Append(rep);
                    empty_prev = false;
                }
                else
                {
                    builder.Append(c);
                    empty_prev = is_empty(c);
                }
            }
            var result = builder.ToString();
            if (language == Language.Belarusian)
            {
                result = result.Replace("__SOFT_S__", "Ś").Replace("__soft_s__", "ś");
            }
            return result.Normalize(NormalizationForm.FormC);
        }

        private string ConvertLatinToCyrillic(Language language, string text)
        {
            var letters = GetConcreteProduct(language);
            if (string.IsNullOrEmpty(text) || letters == null) return text;

            if (language != Language.Macedonian)
            {
                var specialPairs = letters.GetSpecialDictionary();
                if (specialPairs.Count > 0)
                {
                    foreach (var pair in specialPairs.OrderByDescending(p => p.Value.Length))
                        text = text.Replace(pair.Value, pair.Key);
                }
            }

            var start_dict = letters.GetStartToCyrillicDictionary();
            var empties = empty_chars();

            int previous_empty_index = -1;
            do
            {
                int length = text.Length;
                int i = previous_empty_index + 1;
                for (; i < length; ++i)
                {
                    char c = text[i];
                    if (is_empty(c)) continue;
                    foreach (var pr in start_dict)
                    {
                        if (pr.Key.Length > length - i) continue;
                        if (text.IndexOf(pr.Key, i, pr.Key.Length) != i) continue;
                        text = text.Substring(0, i) + pr.Value + text.Substring(i + pr.Key.Length);
                        break;
                    }
                    break;
                }
                previous_empty_index = i;
                previous_empty_index = text.IndexOfAny(empties, previous_empty_index);
            } while (previous_empty_index != -1);

            var toCyr = letters.GetToCyrillicDictionary();
            if (toCyr.Count > 0)
            {
                foreach (var pair in toCyr.OrderByDescending(p => p.Key.Length))
                {
                    text = text.Replace(pair.Key, pair.Value);
                    if (pair.Key.Length == 1)
                    {
                        var upperKey = pair.Key.ToUpper();
                        if (upperKey != pair.Key)
                            text = text.Replace(upperKey, pair.Value.ToUpper());
                    }
                }
            }
            return text.Normalize(NormalizationForm.FormC);
        }
        #endregion Conversion

        #region Serbian
        public string SerbianCyrillicToLatin(string text) => ConvertCyrillicToLatin(Language.Serbian, text);
        public string SerbianLatinToCyrillic(string text) => ConvertLatinToCyrillic(Language.Serbian, text);
        #endregion Serbian

        #region Russian
        public string RussianCyrillicToLatin(string text) => ConvertCyrillicToLatin(Language.Russian, text);
        public string RussianLatinToCyrillic(string text) => ConvertLatinToCyrillic(Language.Russian, text);
        #endregion Russian

        #region Bulgarian
        public string BulgarianCyrillicToLatin(string text) => ConvertCyrillicToLatin(Language.Bulgarian, text);
        public string BulgarianLatinToCyrillic(string text) => ConvertLatinToCyrillic(Language.Bulgarian, text);
        #endregion Bulgarian

        #region Ukrainian
        public string UkrainianCyrillicToLatin(string text) => ConvertCyrillicToLatin(Language.Ukrainian, text);
        public string UkrainianLatinToCyrillic(string text) => ConvertLatinToCyrillic(Language.Ukrainian, text);
        #endregion Ukrainian

        #region Georgian
        public string GeorgianCyrillicToLatin(string text) => ConvertCyrillicToLatin(Language.Georgian, text);
        public string GeorgianLatinToCyrillic(string text) => ConvertLatinToCyrillic(Language.Georgian, text);
        #endregion Georgian

        #region Greek
        public string GreekCyrillicToLatin(string text) => ConvertCyrillicToLatin(Language.Greek, text);
        public string GreekLatinToCyrillic(string text) => ConvertLatinToCyrillic(Language.Greek, text);
        #endregion Greek

        #region Belarusian
        public string BelarusianCyrillicToLatin(string text) => ConvertCyrillicToLatin(Language.Belarusian, text);
        public string BelarusianLatinToCyrillic(string text) => ConvertLatinToCyrillic(Language.Belarusian, text);
        #endregion Belarusian

        #region Macedonian
        public string MacedonianCyrillicToLatin(string text) => ConvertCyrillicToLatin(Language.Macedonian, text);
        public string MacedonianLatinToCyrillic(string text) => ConvertLatinToCyrillic(Language.Macedonian, text);
        #endregion Macedonian

        #region Armenian
        public string ArmenianCyrillicToLatin(string text) => ConvertCyrillicToLatin(Language.Armenian, text);
        public string ArmenianLatinToCyrillic(string text) => ConvertLatinToCyrillic(Language.Armenian, text);
        #endregion Armenian

        private bool is_empty(char c) => c == ' ' || c == '\t' || c == '\n' || c == '\r';
        private char[] empty_chars() => new[] { ' ', '\t', '\n', '\r' };
    }
}
