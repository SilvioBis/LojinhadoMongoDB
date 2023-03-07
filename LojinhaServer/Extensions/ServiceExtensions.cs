using LojinhaServer.Models;
using MongoDB.Driver;

namespace LojinhaServer.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",
            Builder => Builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
        });
    }

    public static void ConfigureMongoDBSettings(this IServiceCollection services, IConfiguration config)
    {
        services.Configure<IMongoDatabase>(option =>
        {
            var settings =
    config.GetSection("MongoDBSettings").Get<MongoDatabaseSettings>();
            var client = new MongoClient(settings.ConnetionString);
            return client.GetDatabase(settings.DatabaseName);
        });
    }
}
