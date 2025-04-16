# MySqlBulkLoader - MySqlBulkCopy helper

[![NuGet](https://img.shields.io/nuget/v/MySqlBulkLoader.svg)](https://www.nuget.org/packages/MySqlBulkLoader)

**The following libraries are recommended over this one:**
- [DataReaderAdapter](https://github.com/usausa/data-toolkit)

# Usage

```csharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MySqlBulkLoader;

public static class Program
{
    public static async Task Main()
    {
        var loader = new MySqlBulkLoader(new MySqlBulkLoaderConfig
        {
            ConnectionString = "..."
        });

        await loader.LoadAsync("TargetTable", Query());
    }

    private static IEnumerable<Data> Query()
    {
        ...
    }
}
```
