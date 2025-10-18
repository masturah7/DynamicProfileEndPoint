namespace DynamicProfileEndpoint.API.Services;

public class CatFactService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<CatFactService> _logger;

    public CatFactService(HttpClient httpClient, ILogger<CatFactService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<string> GetRandomCatFactAsync()
    {
        try
        {

            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));


            var response = await _httpClient.GetFromJsonAsync<CatFactResponse>("https://catfact.ninja/fact", cts.Token);


            return response?.Fact ?? "No cat fact available at the moment.";

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching cat fact from API.");
            return "Could not fetch a cat fact at this time.";
        }
    }

    private class CatFactResponse
    {
        public string Fact { get; set; } = string.Empty;
    }
}