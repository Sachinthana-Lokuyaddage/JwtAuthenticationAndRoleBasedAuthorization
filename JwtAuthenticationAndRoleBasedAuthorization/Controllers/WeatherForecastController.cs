using Microsoft.AspNetCore.Mvc;

namespace JwtAuthenticationAndRoleBasedAuthorization.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

      

        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            return Get();
           
        }
    }
}
