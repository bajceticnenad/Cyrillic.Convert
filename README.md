# Cyrillic.Convert
NuGet (C#) library to transliterate Cyrillic ⇆ Latin.

## Features
- Convert by calling `Conversion` methods (e.g. `SerbianLatinToCyrillic`).
- Convert via extension methods (e.g. `"Ћирилица".ToSerbianLatin()`).
- Language–specific rules (start-of-word, digraphs, special letters).

## Supported languages
- Serbian
- Russian
- Bulgarian
- Ukrainian
- Georgian
- Greek
- Belarusian
- Macedonian
- Armenian
- Kazakh *(hard/soft signs omitted)*

## Example
```csharp
var conversion = new Conversion();
string latin = "a,b,v,g,d,đ,e,ž,z,i,j,k,l,m,n,o,p,r,s,t,ć,u,f,h,c,č,š,Lj,Nj,Dž,lj,nj,dž"; 
var cyrillicExtension = latin.ToSerbianCyrilic();          // extension method
var cyrillic = conversion.SerbianLatinToCyrillic(latin);   // direct API
var latinBack = conversion.SerbianCyrillicToLatin(cyrillic);
var latinExtBack = cyrillic.ToSerbianLatin();
```

Other extension method pairs follow the pattern:
- `ToRussianLatin()` / `ToRussianCyrilic()`
- `ToGreekLatin()` / `ToGreekCyrilic()`
- `ToBelarusianLatin()` / `ToBelarusianCyrillic()`
- `ToMacedonianLatin()` / `ToMacedonianCyrillic()`
- `ToArmenianLatin()` / `ToArmenianCyrilic()`
- `ToKazakhLatin()` / `ToKazakhCyrillic()`

## Installation
```
Install-Package Cyrillic.Convert
```
Or with the .NET CLI:
```
dotnet add package Cyrillic.Convert
```

## Notes
- Some mappings are lossy by design (e.g. dropped hard/soft signs in Kazakh original scheme).
- Mixed‑case multi–letter Latin tokens are handled (e.g. Nj, Lj, Shch).

## License
MIT
