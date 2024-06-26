# Cyrillic.Convert
Nuget (C# library) for convert Cyrillic to Latin and Latin to Cyrillic.
- Convert with forwarded string.
- Convert with extension method (ToSerbianLatin, ToSerbianCyrilic).
- Conversion for Serbian language.
- Conversion for Russian language.
- Conversion for Bulgarian language.
- Conversion for Ukrainian language.
- Conversion for Georgian language.

## Example

```csharp
var conversion = new Conversion();
string latin = "a,b,v,g,d,đ,e,ž,z,i,j,k,l,m,n,o,p,r,s,t,ć,u,f,h,c,č,š,Lj,Nj,Dž,lj,nj,dž"; 
var cyrillicExtension = latin.ToSerbianCyrilic(); //Convert with extension method
var cyrillic = conversion.SerbianLatinToCyrillic(latin); //Convert with forwarded string
var latinConvert = conversion.SerbianCyrillicToLatin(cyrillic);
var latinExtension = cyrillic.ToSerbianLatin();
```

## Installation

` Install-Package Cyrillic.Convert `
