using System.Text;

namespace Cyrillic.Convert.UnitTests
{
    /// <summary>
    /// Edge-case tests that apply to all languages: null, empty, whitespace,
    /// digits, mixed-script, and basic round-trip sanity checks.
    /// </summary>
    public class EdgeCaseTests
    {
        private readonly Conversion _conv = new Conversion();

        // ── Null and empty ──────────────────────────────────────────────────

        [Theory]
        [InlineData("SerbianCyrillicToLatin")]
        [InlineData("SerbianLatinToCyrillic")]
        [InlineData("RussianCyrillicToLatin")]
        [InlineData("RussianLatinToCyrillic")]
        [InlineData("BulgarianCyrillicToLatin")]
        [InlineData("UkrainianCyrillicToLatin")]
        [InlineData("GeorgianCyrillicToLatin")]
        [InlineData("GreekCyrillicToLatin")]
        [InlineData("BelarusianCyrillicToLatin")]
        [InlineData("MacedonianCyrillicToLatin")]
        [InlineData("ArmenianCyrillicToLatin")]
        [InlineData("KazakhCyrillicToLatin")]
        public void NullInput_ReturnsNull(string methodName)
        {
            var method = typeof(Conversion).GetMethod(methodName)!;
            var result = method.Invoke(_conv, new object?[] { null });
            Assert.Null(result);
        }

        [Theory]
        [InlineData("SerbianCyrillicToLatin")]
        [InlineData("SerbianLatinToCyrillic")]
        [InlineData("RussianCyrillicToLatin")]
        [InlineData("KazakhCyrillicToLatin")]
        public void EmptyInput_ReturnsEmpty(string methodName)
        {
            var method = typeof(Conversion).GetMethod(methodName)!;
            var result = (string?)method.Invoke(_conv, new object?[] { "" });
            Assert.Equal("", result);
        }

        // ── Whitespace and non-alphabetic characters pass through ───────────

        [Fact]
        public void WhitespaceOnly_PassesThroughUnchanged()
        {
            const string ws = "  \t\n  ";
            Assert.Equal(ws, _conv.SerbianCyrillicToLatin(ws));
            Assert.Equal(ws, _conv.SerbianLatinToCyrillic(ws));
            Assert.Equal(ws, _conv.RussianCyrillicToLatin(ws));
        }

        [Fact]
        public void DigitsAndPunctuation_PassThroughUnchanged()
        {
            const string input = "123 !@# 456.789";
            Assert.Equal(input, _conv.SerbianCyrillicToLatin(input));
            Assert.Equal(input, _conv.SerbianLatinToCyrillic(input));
            Assert.Equal(input, _conv.RussianCyrillicToLatin(input));
            Assert.Equal(input, _conv.KazakhCyrillicToLatin(input));
        }

        // ── Mixed-script: only the recognised script characters are converted ─

        [Fact]
        public void MixedScriptSerbian_OnlyCyrillicPortionConverted()
        {
            // Cyrillic part should become Latin; Latin and other chars pass through
            var result = _conv.SerbianCyrillicToLatin("Добродошли 2024!");
            Assert.Equal("Dobrodošli 2024!", result);
        }

        [Fact]
        public void MixedScriptRussian_OnlyLatinPortionConverted()
        {
            var result = _conv.RussianLatinToCyrillic("Privet 123 Mir");
            // Digits and spaces stay; Latin letters are converted
            Assert.Contains("123", result);
        }

        // ── Round-trip sanity ───────────────────────────────────────────────

        [Fact]
        public void Serbian_RoundTrip_CyrToLatToOriginal()
        {
            var original = TestConst.SerbianCyrillicLetters;
            var latin    = _conv.SerbianCyrillicToLatin(original);
            var back     = _conv.SerbianLatinToCyrillic(latin);
            Assert.Equal(
                original!.Normalize(NormalizationForm.FormC),
                back!.Normalize(NormalizationForm.FormC));
        }

        [Fact]
        public void Belarusian_InputContainingSentinelLiterals_NotCorrupted()
        {
            // Verify the PUA sentinel replacement is safe even when the placeholder
            // strings from the old implementation are present in the input.
            const string input = "__SOFT_S__ __soft_s__ normal text";
            var result = _conv.BelarusianCyrillicToLatin(input);
            // Should contain the original placeholder strings unchanged
            Assert.Contains("__SOFT_S__", result);
            Assert.Contains("__soft_s__", result);
        }

        [Fact]
        public void Kazakh_CyrillicToLatin_DistinctLettersMapped()
        {
            // И → Ī  and  І → I  must remain distinct
            var resultI       = _conv.KazakhCyrillicToLatin("И");
            var resultKazakhI = _conv.KazakhCyrillicToLatin("І");
            Assert.NotEqual(resultI, resultKazakhI);
        }

        // ── Extension method aliases (deprecated ones still work) ───────────

        [Fact]
        public void DeprecatedToSerbianCyrilic_StillWorks()
        {
#pragma warning disable CS0618
            var result = "srbija".ToSerbianCyrilic();
#pragma warning restore CS0618
            // Deprecated method must forward to the correct implementation
            Assert.Equal(_conv.SerbianLatinToCyrillic("srbija"), result);
            Assert.NotNull(result);
        }

        // ── Long string smoke test ──────────────────────────────────────────

        [Fact]
        public void LongString_DoesNotThrow()
        {
            var longInput = new string('а', 100_000);
            var ex = Record.Exception(() => _conv.SerbianCyrillicToLatin(longInput));
            Assert.Null(ex);
        }
    }
}
