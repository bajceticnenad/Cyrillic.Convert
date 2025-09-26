# .NET 8.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that an .NET 8.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 8.0 upgrade.
3. Upgrade Cyrillic.Convert\Cyrillic.Convert.csproj
4. Upgrade Cyrillic.Convert.UnitTests\Cyrillic.Convert.UnitTests.csproj

## Settings

This section contains settings and data used by execution steps.

### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name         | Current Version | New Version | Description                                                 |
|:---------------------|:---------------:|:-----------:|:------------------------------------------------------------|
| System.Collections   |   4.3.0         |  Removed    | Package functionality is included with framework reference. |

### Project upgrade details
This section contains details about each project upgrade and modifications that need to be done in the project.

#### Cyrillic.Convert\Cyrillic.Convert.csproj modifications

NuGet packages changes:
  - System.Collections should be removed (*Package functionality is included with framework reference.*)

#### Cyrillic.Convert.UnitTests\Cyrillic.Convert.UnitTests.csproj modifications

Project properties changes:
  - Target framework should be changed from `net6.0` to `net8.0`
