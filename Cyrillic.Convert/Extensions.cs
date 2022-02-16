using System;
using System.Collections.Generic;
using System.Text;
using Cyrillic.Convert.Dictionaries;

namespace Cyrillic.Convert
{
    public static class Extensions
    {
        #region "Srpski"
        public static string ToSerbianCyrilic(this string rec)
        {
            //Dictionary<string, string> slova = new Srpski.getDictionary();
            Srpski slova = new Srpski();

            foreach (KeyValuePair<string, string> pair in slova.getDictionary())
            {
                rec = rec.Replace(pair.Value, pair.Key);
                // For upper case
                rec = rec.Replace(pair.Value.ToUpper(), pair.Key.ToUpper());
            }

            return rec;
        }

        public static string ToSerbianLatin(this string rec)
        {
            //Dictionary<string, string> slova = new Dictionary<string, string>();
            Srpski slova = new Srpski();

            foreach (KeyValuePair<string, string> pair in slova.getDictionary())
            {
                rec = rec.Replace(pair.Key, pair.Value);
                // For upper case
                rec = rec.Replace(pair.Key.ToUpper(), pair.Value.ToUpper());
            }

            return rec;
        }
        #endregion "Srpski"

        #region "Ruski"
        public static string ToRussianLatin(this string rec)
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

        public static string ToRussianCyrilic(this string rec)
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
        public static string ToBulgarianLatin(this string rec)
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

        public static string ToBulgarianCyrilic(this string rec)
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

        #region "Ukrainian"

        public static string ToUkrainianLatin(this string rec)
        {
            var conversion = new Conversion();
            return conversion.UkrainianCyrillicToLatin(rec);
        }

        public static string ToUkrainianCyrillic(this string rec)
        {
            var conversion = new Conversion();
            return conversion.UkrainianLatinToCyrillic(rec);
        }

        #endregion
    }
}
