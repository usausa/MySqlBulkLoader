# MySqlBulkLoader - MySqlBulkCopy helper

## Usage example

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
