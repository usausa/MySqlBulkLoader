namespace MySqlBulkLoader;

using System.Reflection;

public sealed class MySqlBulkLoaderConfig
{
    public string ConnectionString { get; set; } = default!;

    public Func<Type, IEnumerable<PropertyInfo>> PropertySelector { get; set; } = static t => t.GetProperties();
}
