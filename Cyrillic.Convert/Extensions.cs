using System;

namespace Cyrillic.Convert
{
    public static class Extensions
    {
        // Shared instance — avoids allocating dictionaries on every call.
        private static readonly Conversion _default = new Conversion();

        #region Serbian
        public static string? ToSerbianCyrillic(this string? text)
            => _default.SerbianLatinToCyrillic(text);

        public static string? ToSerbianLatin(this string? text)
            => _default.SerbianCyrillicToLatin(text);

        [Obsolete("Typo — use ToSerbianCyrillic() instead. Will be removed in v5.0.")]
        public static string? ToSerbianCyrilic(this string? text)
            => ToSerbianCyrillic(text);
        #endregion Serbian

        #region Russian
        public static string? ToRussianLatin(this string? text)
            => _default.RussianCyrillicToLatin(text);

        public static string? ToRussianCyrillic(this string? text)
            => _default.RussianLatinToCyrillic(text);

        [Obsolete("Typo — use ToRussianCyrillic() instead. Will be removed in v5.0.")]
        public static string? ToRussianCyrilic(this string? text)
            => ToRussianCyrillic(text);
        #endregion Russian

        #region Bulgarian
        public static string? ToBulgarianLatin(this string? text)
            => _default.BulgarianCyrillicToLatin(text);

        public static string? ToBulgarianCyrillic(this string? text)
            => _default.BulgarianLatinToCyrillic(text);

        [Obsolete("Typo — use ToBulgarianCyrillic() instead. Will be removed in v5.0.")]
        public static string? ToBulgarianCyrilic(this string? text)
            => ToBulgarianCyrillic(text);
        #endregion Bulgarian

        #region Ukrainian
        public static string? ToUkrainianLatin(this string? text)
            => _default.UkrainianCyrillicToLatin(text);

        public static string? ToUkrainianCyrillic(this string? text)
            => _default.UkrainianLatinToCyrillic(text);
        #endregion Ukrainian

        #region Georgian
        public static string? ToGeorgianLatin(this string? text)
            => _default.GeorgianCyrillicToLatin(text);

        public static string? ToGeorgianCyrillic(this string? text)
            => _default.GeorgianLatinToCyrillic(text);

        [Obsolete("Typo — use ToGeorgianCyrillic() instead. Will be removed in v5.0.")]
        public static string? ToGeorgianCyrilic(this string? text)
            => ToGeorgianCyrillic(text);
        #endregion Georgian

        #region Greek
        public static string? ToGreekLatin(this string? text)
            => _default.GreekCyrillicToLatin(text);

        public static string? ToGreekCyrillic(this string? text)
            => _default.GreekLatinToCyrillic(text);

        [Obsolete("Typo — use ToGreekCyrillic() instead. Will be removed in v5.0.")]
        public static string? ToGreekCyrilic(this string? text)
            => ToGreekCyrillic(text);
        #endregion Greek

        #region Belarusian
        public static string? ToBelarusianLatin(this string? text)
            => _default.BelarusianCyrillicToLatin(text);

        public static string? ToBelarusianCyrillic(this string? text)
            => _default.BelarusianLatinToCyrillic(text);
        #endregion Belarusian

        #region Macedonian
        public static string? ToMacedonianLatin(this string? text)
            => _default.MacedonianCyrillicToLatin(text);

        public static string? ToMacedonianCyrillic(this string? text)
            => _default.MacedonianLatinToCyrillic(text);
        #endregion Macedonian

        #region Armenian
        public static string? ToArmenianLatin(this string? text)
            => _default.ArmenianCyrillicToLatin(text);

        public static string? ToArmenianCyrillic(this string? text)
            => _default.ArmenianLatinToCyrillic(text);

        [Obsolete("Typo — use ToArmenianCyrillic() instead. Will be removed in v5.0.")]
        public static string? ToArmenianCyrilic(this string? text)
            => ToArmenianCyrillic(text);
        #endregion Armenian

        #region Kazakh
        public static string? ToKazakhLatin(this string? text)
            => _default.KazakhCyrillicToLatin(text);

        public static string? ToKazakhCyrillic(this string? text)
            => _default.KazakhLatinToCyrillic(text);
        #endregion Kazakh
    }
}
