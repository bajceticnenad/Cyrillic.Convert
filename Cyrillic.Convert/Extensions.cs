namespace Cyrillic.Convert
{
    public static class Extensions
    {
        #region Serbian
        public static string ToSerbianCyrilic(this string text)
        {
            var conversion = new Conversion();
            return conversion.SerbianLatinToCyrillic(text);
        }

        public static string ToSerbianLatin(this string text)
        {
            var conversion = new Conversion();
            return conversion.SerbianCyrillicToLatin(text);
        }
        #endregion Serbian

        #region Russian
        public static string ToRussianLatin(this string text)
        {
            var conversion = new Conversion();
            return conversion.RussianCyrillicToLatin(text);
        }

        public static string ToRussianCyrilic(this string text)
        {
            var conversion = new Conversion();
            return conversion.RussianLatinToCyrillic(text);
        }
        #endregion Russian

        #region Bulgarian
        public static string ToBulgarianLatin(this string text)
        {
            var conversion = new Conversion();
            return conversion.BulgarianCyrillicToLatin(text);
        }

        public static string ToBulgarianCyrilic(this string text)
        {
            var conversion = new Conversion();
            return conversion.BulgarianLatinToCyrillic(text);
        }
        #endregion Bulgarian

        #region Ukrainian

        public static string ToUkrainianLatin(this string text)
        {
            var conversion = new Conversion();
            return conversion.UkrainianCyrillicToLatin(text);
        }

        public static string ToUkrainianCyrillic(this string text)
        {
            var conversion = new Conversion();
            return conversion.UkrainianLatinToCyrillic(text);
        }

        #endregion

        #region Georgian
        public static string ToGeorgianCyrilic(this string text)
        {
            var conversion = new Conversion();
            return conversion.GeorgianLatinToCyrillic(text);
        }

        public static string ToGeorgianLatin(this string text)
        {
            var conversion = new Conversion();
            return conversion.GeorgianCyrillicToLatin(text);
        }
        #endregion Georgian

        #region Greek
        public static string ToGreekCyrilic(this string text)
        {
            var conversion = new Conversion();
            return conversion.GreekLatinToCyrillic(text);
        }

        public static string ToGreekLatin(this string text)
        {
            var conversion = new Conversion();
            return conversion.GreekCyrillicToLatin(text);
        }
        #endregion Greek

        #region Belarusian
        public static string ToBelarusianCyrillic(this string text)
        {
            var conversion = new Conversion();
            return conversion.BelarusianLatinToCyrillic(text);
        }

        public static string ToBelarusianLatin(this string text)
        {
            var conversion = new Conversion();
            return conversion.BelarusianCyrillicToLatin(text);
        }
        #endregion Belarusian

        #region Macedonian
        public static string ToMacedonianCyrillic(this string text)
        {
            var conversion = new Conversion();
            return conversion.MacedonianLatinToCyrillic(text);
        }

        public static string ToMacedonianLatin(this string text)
        {
            var conversion = new Conversion();
            return conversion.MacedonianCyrillicToLatin(text);
        }
        #endregion Macedonian

        #region Armenian
        public static string ToArmenianCyrilic(this string text)
        {
            var conversion = new Conversion();
            return conversion.ArmenianLatinToCyrillic(text);
        }

        public static string ToArmenianLatin(this string text)
        {
            var conversion = new Conversion();
            return conversion.ArmenianCyrillicToLatin(text);
        }
        #endregion Armenian

        #region Kazakh
        public static string ToKazakhLatin(this string text)
        {
            var conversion = new Conversion();
            return conversion.KazakhCyrillicToLatin(text);
        }
        public static string ToKazakhCyrillic(this string text)
        {
            var conversion = new Conversion();
            return conversion.KazakhLatinToCyrillic(text);
        }
        #endregion Kazakh
    }
}
