using Microsoft.AspNetCore.Mvc;
using Roulette.Api.Data.BasicRepository;
using Roulette.Api.Games;

namespace Roulette.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RouletteController : Controller
    {
        private readonly IRouletteGame _rouletteGame;
        private readonly ILogger<RouletteController> _logger;
        private readonly IBetRepo _betRepo;

        public RouletteController(ILogger<RouletteController> logger, IRouletteGame rouletteGame, IBetRepo betRepo)
        {
            _logger = logger;
            _rouletteGame = rouletteGame;
            _betRepo = betRepo;
        }

        [HttpPost("PlayRoulette")]
        public async Task<IActionResult> PlayRoulette(string region, int betAmount, int playerSelectedNumber) 
        {
            //Note: Await will be added once Db opperations are inplace.
            return Json(await _rouletteGame.PlayRouletteAsync(region, betAmount, playerSelectedNumber));
        }

        [HttpGet("GetAllPreviousBets")]
        public async Task<IActionResult> GetAllPreviousBets()
        {
            //Note: Await will be added once Db opperations are inplace.
            return Json(await _betRepo.GetPreviousBetsAsync());
        }

        [HttpPost("TestExceptionHandler")]
        public void TestExceptionHandler()
        {
            //Note: Await will be added once Db opperations are inplace.
            var a = 1;
            var b = 0;
            var d = a / b;
        }
    }
}