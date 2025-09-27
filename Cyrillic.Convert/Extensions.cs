namespace Cyrillic.Convert
{
    public static class Extensions
    {
        #region Serbian
        public static string ToSerbianCyrilic(this string text) => new Conversion().SerbianLatinToCyrillic(text);
        public static string ToSerbianLatin(this string text) => new Conversion().SerbianCyrillicToLatin(text);
        #endregion Serbian

        #region Russian
        public static string ToRussianLatin(this string text) => new Conversion().RussianCyrillicToLatin(text);
        public static string ToRussianCyrilic(this string text) => new Conversion().RussianLatinToCyrillic(text);
        #endregion Russian

        #region Bulgarian
        public static string ToBulgarianLatin(this string text) => new Conversion().BulgarianCyrillicToLatin(text);
        public static string ToBulgarianCyrilic(this string text) => new Conversion().BulgarianLatinToCyrillic(text);
        #endregion Bulgarian

        #region Ukrainian
        public static string ToUkrainianLatin(this string text) => new Conversion().UkrainianCyrillicToLatin(text);
        public static string ToUkrainianCyrillic(this string text) => new Conversion().UkrainianLatinToCyrillic(text);
        #endregion Ukrainian

        #region Georgian
        public static string ToGeorgianCyrilic(this string text) => new Conversion().GeorgianLatinToCyrillic(text);
        public static string ToGeorgianLatin(this string text) => new Conversion().GeorgianCyrillicToLatin(text);
        #endregion Georgian

        #region Greek
        public static string ToGreekCyrilic(this string text) => new Conversion().GreekLatinToCyrillic(text);
        public static string ToGreekLatin(this string text) => new Conversion().GreekCyrillicToLatin(text);
        #endregion Greek

        #region Armenian
        public static string ToArmenianCyrilic(this string text) => new Conversion().ArmenianLatinToCyrillic(text);
        public static string ToArmenianLatin(this string text) => new Conversion().ArmenianCyrillicToLatin(text);
        #endregion Armenian
    }
}
