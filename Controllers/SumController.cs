
using MC_Challenge_Two_to_Four.Services.Sum;
using Microsoft.AspNetCore.Mvc;


namespace MC_Challenge_Two_to_Four.Controllers;
[ApiController]

    [Route("[controller]")]
    public class SumController : Controller
    {
        private readonly ISumService _sumService;

        public SumController(ISumService sumService)
        {
            _sumService = sumService;
        }

        [HttpPost]
        [Route("of/{num1}/{num2}")]

        public string Sum(int num1, int num2)
        {
            return _sumService.Sum(num1, num2);
        }
    }
