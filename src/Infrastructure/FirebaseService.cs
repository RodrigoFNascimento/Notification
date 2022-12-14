using Application.Services.Infrastructure;

namespace Infrastructure;
public class FirebaseService : IFirebaseService
{
    private readonly HttpClient _httpClient;

    public FirebaseService(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }

    public async Task SendPushAsync()
    {
        throw new NotImplementedException();
    }
}
