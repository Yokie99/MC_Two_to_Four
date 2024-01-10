
using MC_Challenge_Two_to_Four.Services.WokeUp;
using Microsoft.AspNetCore.Mvc;

namespace MC_Challenge_Two_to_Four.Controllers;
[ApiController]
    [Route("[controller]")]
    public class WokeUpController : Controller
    {
        private readonly IWokeUpService _WokeUpService;

        public WokeUpController(IWokeUpService WokeUpService)
        {
            _WokeUpService = WokeUpService;
        }

        [HttpPost]
        [Route("{name}/{time}")]

        public string WokeUp(string name, string time)
        {
            return _WokeUpService.WokeUp(name, time);
        }
    }
