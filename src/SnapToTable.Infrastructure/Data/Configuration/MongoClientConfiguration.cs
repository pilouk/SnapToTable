using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;

namespace SnapToTable.Infrastructure.Data.Configuration;

public static class MongoClientConfiguration
{
    public static IMongoClient CreateClient(MongoDbSettings settings)
    {
        var mongoClientSettings = MongoClientSettings.FromUrl(new MongoUrl(settings.ConnectionString));
        
        BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.Standard));
        
        // Configure TLS
        mongoClientSettings.UseTls = settings.UseTls;
        if (settings.UseTls)
        {
            mongoClientSettings.AllowInsecureTls = settings.AllowInsecureTls;
        }

        return new MongoClient(mongoClientSettings);
    }
}