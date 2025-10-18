using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DynamicProfileAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public ProfileController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet("me")]
        [Produces("application/json")]
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

                    user = new
                    {
                       
                        email = "oshinkoyamasturah@gmail.com",
                        name = "Masturah Abiodun Oshinkoya",
                        stack = "C#/ASP.NET Core"
                    },
                    timestamp = DateTime.UtcNow.ToString("o"),
                    fact = catFact
                };

                return new JsonResult(result)
                {
                    StatusCode = 200,
                    ContentType = "application/json"
                };
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    error = "Unable to fetch cat fact",
                    message = ex.Message
                });
            }
        }
    }
}
