using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TheShopCore.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TheShopCoreController : ControllerBase
    {
        private readonly ILogger<TheShopCoreController> _logger;

        public TheShopCoreController(ILogger<TheShopCoreController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return null;
        }
    }
}
