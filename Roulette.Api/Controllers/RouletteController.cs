using Microsoft.AspNetCore.Mvc;
using Roulette.Api.Games;

namespace Roulette.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RouletteController : Controller
    {
        private readonly IRouletteGame _rouletteGame;
        private readonly ILogger<RouletteController> _logger;

        public RouletteController(ILogger<RouletteController> logger, IRouletteGame rouletteGame)
        {
            _logger = logger;
            _rouletteGame = rouletteGame;
        }

        [HttpGet(Name = "PlayRoulette")]
        public async Task<IActionResult> PlayRoulette(string region, int betAmount, int playerSelectedNumber) 
        {
            //Note: Await will be added once Db opperations are inplace.
            return Json(_rouletteGame.PlayRoulette(region, betAmount, playerSelectedNumber));
        }
    }
}