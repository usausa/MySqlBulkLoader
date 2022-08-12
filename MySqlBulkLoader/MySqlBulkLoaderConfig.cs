namespace MySqlBulkLoader;

using System.Reflection;

public class MySqlBulkLoaderConfig
{
    public string ConnectionString { get; set; } = default!;

    public Func<Type, IEnumerable<PropertyInfo>> PropertySelector { get; set; } = t => t.GetProperties();
}
