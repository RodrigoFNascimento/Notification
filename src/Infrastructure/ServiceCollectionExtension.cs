using Application.Services.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;
public static class ServiceCollectionExtension
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddHttpClient("Firebase", httpClient =>
        {
            httpClient.BaseAddress = new Uri("https://someurl.com/");
        });
        services.AddSingleton<IFirebaseService, FirebaseService>();
        return services;
    }
}
