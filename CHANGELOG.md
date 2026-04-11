# Changelog

All notable changes to this project will be documented in this file.
Format follows [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). Versioning follows [SemVer](https://semver.org/).

---

## [4.0.0] — 2026-04-12

### Breaking Changes
- `ConversionDictionaries` and all concrete language classes (`Serbian`, `Russian`, etc.) are now `internal`. They were never intended as part of the public API.
- The following extension methods now carry `[Obsolete]` warnings and will be **removed in v5.0**. Use the correctly-spelled replacements:
  | Deprecated | Replacement |
  |---|---|
  | `ToSerbianCyrilic()` | `ToSerbianCyrillic()` |
  | `ToRussianCyrilic()` | `ToRussianCyrillic()` |
  | `ToBulgarianCyrilic()` | `ToBulgarianCyrillic()` |
  | `ToGeorgianCyrilic()` | `ToGeorgianCyrillic()` |
  | `ToGreekCyrilic()` | `ToGreekCyrillic()` |
  | `ToArmenianCyrilic()` | `ToArmenianCyrillic()` |

### Fixed
- **Kazakh**: Encoding corruption in `Kazakh.cs` — every Cyrillic character literal was stored as `'?'`, making the Kazakh conversion completely non-functional. Now uses correct UTF-8 codepoints.
- **Belarusian**: Replaced fragile `__SOFT_S__` / `__soft_s__` string sentinel with Unicode Private Use Area characters (`U+E001` / `U+E002`), eliminating the risk of corrupted output if input contained those literal strings.
- `GetConcreteProduct` now throws `ArgumentOutOfRangeException` for unknown `Language` enum values instead of returning `null` and silently passing input through unchanged.

### Added
- GitHub Actions CI workflow (runs on every push/PR to master).
- GitHub Actions NuGet publish workflow (triggers on `v*` tags).
- Nullable reference type annotations on all public API (`string?`).
- Symbol package (`.snupkg`) published alongside the main package.
- Correctly-spelled `ToXxxCyrillic()` extension methods for all languages.

### Changed
- Shared `static readonly Conversion _default` instance in `Extensions` — avoids allocating new dictionaries on every call to an extension method.
- `GeneratePackageOnBuild` set to `false`; packing is now done by the CI pipeline only.
- Private helper names in `Conversion.cs` changed from `snake_case` to `camelCase` / `PascalCase` per C# conventions (`is_empty` → `IsWordBoundary`, `empty_chars` → `WordBoundaryChars`, etc.).
- Removed obsolete `System.Collections 4.3.0` package reference (built-in for `netstandard2.0`).
- Added `net8.0` as second target framework alongside `netstandard2.0`.
- Removed `push.cmd` and `uputstvo.txt` from repository.

---

## [3.2.1] — 2024-09-28

### Changed
- Include README in NuGet package.

---

## [3.2.0] — 2024-03-18

### Added
- Greek, Belarusian, Macedonian, Armenian, Kazakh language support.
- Refined mappings and cleanup.

---

## [3.1.0]

### Added
- Upgraded to .NET 8.
- Further mapping refinements.

---

## [3.0.0]

### Added
- Ukrainian language support.

---

## [2.0.0]

### Added
- Bulgarian language support.

---

## [1.0.0]

### Added
- Initial release: Serbian and Russian transliteration (Cyrillic ⇆ Latin).
