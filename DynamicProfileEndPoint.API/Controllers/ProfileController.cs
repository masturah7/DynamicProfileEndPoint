using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DynamicProfileAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public ProfileController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet("/me")]


        public async Task<IActionResult> GetProfile()
        {
            try
            {

                var response = await _httpClient.GetStringAsync("https://catfact.ninja/fact");

                var json = JsonDocument.Parse(response);

                var catFact = json.RootElement.GetProperty("fact").GetString();


                var result = new
                {
                    status = "success",

                    User = new
                    {
                        Email = "oshinkoyamasturah@gmail.com",
                        Name = "Masturah Oshinkoya",

                        Stack = "C#/ASP.NET Core"
                    },
                    timestamp = DateTime.UtcNow.ToString("o"),
                    fact = catFact
                    
                };

                return new ContentResult
                {
                    Content = JsonSerializer.Serialize(result),
                    ContentType = "application/json",
                    StatusCode = 200
                };

            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    status = "error",
                    message = ex.Message
                });
            }
        }
    }
}
