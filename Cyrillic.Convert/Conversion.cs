using Cyrillic.Convert.Creator.ConcreteCreator;
using Cyrillic.Convert.Enums;
using Cyrillic.Convert.Product;
using System.Collections.Generic;
using System.Text;

namespace Cyrillic.Convert
{
    public class Conversion
    {
        #region Factory
        private ConversionDictionaries GetConcreteProduct(Language language)
        {
            switch (language)
            {
                case Language.Serbian:
                    return new SerbianConversionFactory().GetConversionDictionaries();
                case Language.Russian:
                    return new RussianConversionFactory().GetConversionDictionaries();
                case Language.Ukrainian:
                    return new UkrainianConversionFactory().GetConversionDictionaries();
                //case Language.Bulgarian:
                //    return new BulgarianConversionFactory().GetConversionDictionaries();
                default:
                    return null;
            }
        }
        #endregion Factory

        #region Conversion

        private string ConvertCyrillicToLatin(Language language, string text)
        {
            var letters = GetConcreteProduct(language);

            StringBuilder builder = new StringBuilder(text.Length * 2); //approximately

            var special_dict = letters.GetSpecialDictionary();

            foreach (var pair in special_dict)
            {
                text = text.Replace(pair.Key, pair.Value);
            }

            var start_dict = letters.GetStartDictionary();

            var c = text[0];
            bool empty_prev = false;
            if (start_dict.TryGetValue(c, out string start_str))
            {
                builder.Append(start_str);
            }
            else
            {
                builder.Append(c);
                empty_prev = is_empty(c);
            }


            var dict = letters.GetToLatinDictionary();

            int length = text.Length;

            for (int i = 1; i < length; ++i)
            {
                c = text[i];
                if (empty_prev && start_dict.TryGetValue(c, out string start_tmp_str))
                {
                    empty_prev = false;
                    builder.Append(start_tmp_str);
                }
                else if (dict.TryGetValue(c, out string rep))
                {
                    empty_prev = false;
                    builder.Append(rep);
                }
                else
                {
                    builder.Append(c);
                    empty_prev = is_empty(c);
                }
            }

            return builder.ToString();
        }

        private string ConvertLatinToCyrillic(Language language, string text)
        {
            var letters = GetConcreteProduct(language);
            var empties = empty_chars();

            foreach (var pair in letters.GetSpecialDictionary())
            {
                text = text.Replace(pair.Value, pair.Key);
            }

            var start_dict = letters.GetStartToCyrillicDictionary();

            //first replace start characters
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
                        if (pr.Key.Length > text.Length - i) continue;
                        if (text.IndexOf(pr.Key, i, pr.Key.Length) != i) continue;
                        text = text.Substring(0, i) + pr.Value + text.Substring(i + pr.Key.Length);
                        break;
                    }
                    break;
                }
                previous_empty_index = i;

                previous_empty_index = text.IndexOfAny(empties, previous_empty_index);
            } while (previous_empty_index != -1);



            foreach (KeyValuePair<string, string> pair in letters.GetToCyrillicDictionary())
            {
                text = text.Replace(pair.Key, pair.Value);
                // For upper case
                text = text.Replace(pair.Key.ToUpper(), pair.Value.ToUpper());
            }

            return text;
        }
        #endregion Conversion

        #region "Serbian"
        public string SerbianCyrillicToLatin(string text)
        {
            return ConvertCyrillicToLatin(Language.Serbian, text);
        }

        public string SerbianLatinToCyrillic(string text)
        {
            return ConvertLatinToCyrillic(Language.Serbian, text);
        }
        #endregion "Serbian"

        #region "Russian"
        public string RussianCyrillicToLatin(string text)
        {
            return ConvertCyrillicToLatin(Language.Russian, text);
        }

        public string RussianLatinToCyrillic(string text)
        {
            return ConvertLatinToCyrillic(Language.Russian, text);
        }
        #endregion "Russian"

        #region "Bulgarian"
        public string BulgarianCyrillicToLatin(string text)
        {
            return ConvertCyrillicToLatin(Language.Bulgarian, text);
        }

        public string BulgarianLatinToCyrillic(string text)
        {
            return ConvertLatinToCyrillic(Language.Bulgarian, text);
        }
        #endregion "Bulgarian"

        #region Ukrainian

        public string UkrainianCyrillicToLatin(string text)
        {
            return ConvertCyrillicToLatin(Language.Ukrainian, text);
        }

        public string UkrainianLatinToCyrillic(string text)
        {
            return ConvertLatinToCyrillic(Language.Ukrainian, text);
        }

        private bool is_empty(char c)
        {
            return c == ' '
                        || c == '\t'
                        || c == '\n'
                        || c == '\r';
        }

        private char[] empty_chars()
        {
            return new char[] { ' ', '\t', '\n', '\r' };
        }

        #endregion
    }
}
