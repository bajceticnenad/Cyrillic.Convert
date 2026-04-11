# Cyrillic.Convert

[![NuGet](https://img.shields.io/nuget/v/Cyrillic.Convert.svg)](https://www.nuget.org/packages/Cyrillic.Convert)
[![CI](https://github.com/bajceticnenad/Cyrillic.Convert/actions/workflows/ci.yml/badge.svg)](https://github.com/bajceticnenad/Cyrillic.Convert/actions/workflows/ci.yml)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

Lightweight C# library for transliteration (Cyrillic ⇆ Latin).

## Features
- Convert by calling `Conversion` methods directly (e.g. `SerbianLatinToCyrillic`).
- Convert via string extension methods (e.g. `"Ћирилица".ToSerbianLatin()`).
- Language-specific rules: start-of-word variants, digraphs, special letters.
- Targets `netstandard2.0` and `net8.0` — works everywhere from .NET Framework 4.6.1 to .NET 8+.

## Supported languages

| Language | Cyrillic → Latin | Latin → Cyrillic |
|---|---|---|
| Serbian | `ToSerbianLatin()` | `ToSerbianCyrillic()` |
| Russian | `ToRussianLatin()` | `ToRussianCyrillic()` |
| Bulgarian | `ToBulgarianLatin()` | `ToBulgarianCyrillic()` |
| Ukrainian | `ToUkrainianLatin()` | `ToUkrainianCyrillic()` |
| Georgian | `ToGeorgianLatin()` | `ToGeorgianCyrillic()` |
| Greek | `ToGreekLatin()` | `ToGreekCyrillic()` |
| Belarusian | `ToBelarusianLatin()` | `ToBelarusianCyrillic()` |
| Macedonian | `ToMacedonianLatin()` | `ToMacedonianCyrillic()` |
| Armenian | `ToArmenianLatin()` | `ToArmenianCyrillic()` |
| Kazakh | `ToKazakhLatin()` | `ToKazakhCyrillic()` |

## Example

```csharp
var conversion = new Conversion();

// Serbian
string latin    = "a,b,v,g,d,đ,e,ž,z,i,j,k,l,m,n,o,p,r,s,t,ć,u,f,h,c,č,š,Lj,Nj,Dž,lj,nj,dž";
string cyrillic = latin.ToSerbianCyrillic();               // extension method
string cyrillic2 = conversion.SerbianLatinToCyrillic(latin); // direct API
string latinBack = conversion.SerbianCyrillicToLatin(cyrillic2);
string latinBack2 = cyrillic2.ToSerbianLatin();

// Other languages follow the same pattern:
string ruLatin  = "Привет мир".ToRussianLatin();
string grLatin  = "Αθήνα".ToGreekLatin();
string kazLatin = "Қазақстан".ToKazakhLatin();
```

## Installation

```
Install-Package Cyrillic.Convert
```

Or with the .NET CLI:

```
dotnet add package Cyrillic.Convert
```

## Notes
- Some mappings are **lossy by design** (e.g. hard/soft signs dropped in Kazakh).
- Mixed-case multi-letter Latin tokens are handled (e.g. `Nj`, `Lj`, `Shch`).
- All public API methods accept and return `string?` — `null` input returns `null`.

## Migration from v3.x

Six extension methods had a spelling typo (`Cyrilic` instead of `Cyrillic`). They are now `[Obsolete]` and will be removed in v5.0. Rename them in your code:

```csharp
// v3.x (deprecated)
text.ToSerbianCyrilic()
text.ToRussianCyrilic()
text.ToBulgarianCyrilic()
text.ToGeorgianCyrilic()
text.ToGreekCyrilic()
text.ToArmenianCyrilic()

// v4.x (correct)
text.ToSerbianCyrillic()
text.ToRussianCyrillic()
text.ToBulgarianCyrillic()
text.ToGeorgianCyrillic()
text.ToGreekCyrillic()
text.ToArmenianCyrillic()
```

## Contributing

See [CONTRIBUTING.md](CONTRIBUTING.md) for instructions on adding a new language.

## License

MIT
