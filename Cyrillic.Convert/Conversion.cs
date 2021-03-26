using Cyrillic.Convert.Dictionaries;
using System;
using System.Collections.Generic;
using System.Text;

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

    }
}
