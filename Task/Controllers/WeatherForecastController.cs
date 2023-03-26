using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public  static IStringLocalizer<WeatherForecastController> _localizer;
        public WeatherForecastController(IStringLocalizer<WeatherForecastController> localizer)
        {
            _localizer =localizer;
        }
        [HttpGet]
        public IActionResult get()
        {
            return Ok(_localizer["welcome"]) ; 
        }
    }
}