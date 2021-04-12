using Cyrillic.Convert.Dictionaries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cyrillic.Convert
{
    public class Conversion
    {
        #region "Srpski"
        public string SerbianCyrillicToLatin(string rec)
        {
            Srpski slova = new Srpski();

            foreach (KeyValuePair<string, string> pair in slova.getDictionary())
            {
                rec = rec.Replace(pair.Key, pair.Value);
                // For upper case
                rec = rec.Replace(pair.Key.ToUpper(), pair.Value.ToUpper());
            }

            return rec;
        }

        public string SerbianLatinToCyrillic(string rec)
        {
            Srpski slova = new Srpski();

            foreach (KeyValuePair<string, string> pair in slova.getDictionary())
            {
                rec = rec.Replace(pair.Value, pair.Key);
                // For upper case
                rec = rec.Replace(pair.Value.ToUpper(), pair.Key.ToUpper());
            }

            return rec;
        }
        #endregion "Srpski"

        #region "Ruski"
        public string RussianCyrillicToLatin(string rec)
        {
            Ruski slova = new Ruski();

            foreach (KeyValuePair<string, string> pair in slova.getDictionary())
            {
                rec = rec.Replace(pair.Key, pair.Value);
                // For upper case
                rec = rec.Replace(pair.Key.ToUpper(), pair.Value.ToUpper());
            }

            return rec;
        }

        public string RussianLatinToCyrillic(string rec)
        {
            Ruski slova = new Ruski();

            foreach (KeyValuePair<string, string> pair in slova.getDictionary())
            {
                rec = rec.Replace(pair.Value, pair.Key);
                // For upper case
                rec = rec.Replace(pair.Value.ToUpper(), pair.Key.ToUpper());
            }

            return rec;
        }
        #endregion "Ruski"

        #region "Bugarski"
        public string BulgarianCyrillicToLatin(string rec)
        {
            Bugarski slova = new Bugarski();

            foreach (KeyValuePair<string, string> pair in slova.getDictionary())
            {
                rec = rec.Replace(pair.Key, pair.Value);
                // For upper case
                rec = rec.Replace(pair.Key.ToUpper(), pair.Value.ToUpper());
            }

            return rec;
        }

        public string BulgarianLatinToCyrillic(string rec)
        {
            Bugarski slova = new Bugarski();

            foreach (KeyValuePair<string, string> pair in slova.getDictionary())
            {
                rec = rec.Replace(pair.Value, pair.Key);
                // For upper case
                rec = rec.Replace(pair.Value.ToUpper(), pair.Key.ToUpper());
            }

            return rec;
        }
        #endregion "Bugarski"

        #region Ukrainian

        public string UkrainianCyrillicToLatin(string rec)
        {
            var slova = new Ukrainian();

            StringBuilder builder = new StringBuilder(rec.Length * 2); //approximately

            var special_dict = slova.getSpecialDictionary();

            foreach (var pair in special_dict)
            {
                rec = rec.Replace(pair.Key, pair.Value);
            }

            var start_dict = slova.getStartDictionary();

            var c = rec[0];
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


            var dict = slova.getDictionary();

            int length = rec.Length;

            for (int i = 1; i < length; ++i)
            {
                c = rec[i];
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

        public string UkrainianLatinToCyrillic(string rec)
        {
            var slova = new Ukrainian();
            var empties = empty_chars();

            foreach (var pair in slova.getSpecialDictionary())
            {
                rec = rec.Replace(pair.Value, pair.Key);
            }

            var start_dict = slova.getStartToUkrDictionary();

            //first replace start characters
            int previous_empty_index = -1;
            do
            {
                int length = rec.Length;
                int i = previous_empty_index + 1;
                for (; i < length; ++i)
                {
                    char c = rec[i];
                    if (is_empty(c)) continue;

                    foreach (var pr in start_dict)
                    {
                        if (rec.IndexOf(pr.Key, i, pr.Key.Length) != i) continue;
                        rec = rec.Substring(0, i) + pr.Value + rec.Substring(i + pr.Key.Length);
                        break;
                    }
                    break;
                }
                previous_empty_index = i;

                previous_empty_index = rec.IndexOfAny(empties, previous_empty_index);
            } while (previous_empty_index != -1);



            foreach (KeyValuePair<string, string> pair in slova.getToUkrDictionary())
            {
                rec = rec.Replace(pair.Key, pair.Value);
                // For upper case
                rec = rec.Replace(pair.Key.ToUpper(), pair.Value.ToUpper());
            }

            return rec;

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
