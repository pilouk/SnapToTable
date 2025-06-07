namespace SnapToTable.Infrastructure.Data.Configuration;

public class MongoDbSettings
{
    public string ConnectionString { get; init; } = string.Empty;
    public string DatabaseName { get; init; } = string.Empty;
    public bool UseTls { get; init; } = true;
    public bool AllowInsecureTls { get; init; }
} 