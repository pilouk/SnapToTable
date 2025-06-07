using MongoDB.Driver;

namespace SnapToTable.Infrastructure.Data.Configuration;

public static class MongoClientConfiguration
{
    public static IMongoClient CreateClient(MongoDbSettings settings)
    {
        var mongoClientSettings = MongoClientSettings.FromUrl(new MongoUrl(settings.ConnectionString));

        // Configure TLS
        mongoClientSettings.UseTls = settings.UseTls;
        if (settings.UseTls)
        {
            mongoClientSettings.AllowInsecureTls = settings.AllowInsecureTls;
        }

        return new MongoClient(mongoClientSettings);
    }
} 