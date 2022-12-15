using Application.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Persistency.Persistency;
using Persistency.Repositories;

namespace Persistency;
public static class ServiceCollectionExtension
{
    public static IServiceCollection AddPersistencyServices(this IServiceCollection services)
    {
        services.AddSingleton<IDbConnectionFactory>(_ => new SqlServerConnectionFactory(""));
        services.AddSingleton<IMessageRepository, MessageRepository>();
        return services;
    }
}
