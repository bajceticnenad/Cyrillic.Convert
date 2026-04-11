# Contributing to Cyrillic.Convert

Thank you for your interest in contributing!

## How to add a new language

1. **Create the product class** — add `Cyrillic.Convert/Product/ConcreteProducts/YourLanguage.cs`:
   - Inherit from `ConversionDictionaries` (keep it `internal`).
   - Implement all five dictionary methods:
     - `GetToLatinDictionary()` — `char → string`, Cyrillic-to-Latin character map.
     - `GetStartDictionary()` — `char → string`, overrides applied at the **start of a word** (e.g. Й→Jo vs Й→jo after consonants).
     - `GetToCyrillicDictionary()` — `string → string`, Latin-to-Cyrillic token map (longest-key-first matching is applied automatically).
     - `GetStartToCyrillicDictionary()` — `string → string`, word-start overrides for Latin→Cyrillic direction.
     - `GetSpecialDictionary()` — `string → string`, multi-character Cyrillic sequences that must be pre-processed as a unit (e.g. digraphs).

2. **Create the factory** — add `Cyrillic.Convert/Creator/ConcreteCreator/YourLanguageConversionFactory.cs`:
   - Inherit from `ConversionFactory` (keep it `internal`).
   - Return `new YourLanguage()` from `GetConversionDictionaries()`.

3. **Add an enum value** — add `YourLanguage` to `Cyrillic.Convert/Enums/Language.cs`.

4. **Wire up the switch** — add a `case Language.YourLanguage:` branch in `Conversion.GetConcreteProduct()` (`Conversion.cs`).

5. **Add public API methods** — add a `#region YourLanguage` block to `Conversion.cs` and `Extensions.cs` following the existing pattern.

6. **Add tests** — create `Cyrillic.Convert.UnitTests/LanguagesTests/YourLanguageTests.cs` with at least four facts: CyrToLat direct, CyrToLat extension, LatToCyr direct, LatToCyr extension. Add test string constants to `TestConst.cs`.

## Running the tests

```bash
dotnet test
```

## Coding conventions

- C# naming: `PascalCase` for types and public members, `camelCase` for local variables and private fields.
- Keep all product/factory classes `internal` — only `Conversion`, `Extensions`, and `Language` are part of the public API.
- Use `string?` for all input/output that may be null.
- Do not add `[Obsolete]` without a concrete replacement method in the same PR.

## Releasing a new version

1. Update `Version`, `AssemblyVersion`, `FileVersion` in `Cyrillic.Convert/Cyrillic.Convert.csproj`.
2. Add a new section to `CHANGELOG.md`.
3. Merge to `master`, then push a `v{version}` tag (e.g. `git tag v4.1.0 && git push origin v4.1.0`).
4. The [publish workflow](.github/workflows/publish.yml) will build, test, pack, and push to NuGet automatically.

> **Note:** Store your NuGet API key as a repository secret named `NUGET_API_KEY`.
