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
    }
}
