
using MC_Challenge_Two_to_Four.Services.GreaterOrLessThan;
using Microsoft.AspNetCore.Mvc;


namespace MC_Challenge_Two_to_Four.Controllers;
[ApiController]

    [Route("[controller]")]
    public class GreaterOrLessThanController : Controller
    {
        private readonly IGreaterOrLessThanService _GreaterOrLessThanService;

        public GreaterOrLessThanController(IGreaterOrLessThanService GreaterOrLessThanService)
        {
            _GreaterOrLessThanService = GreaterOrLessThanService;
        }

        [HttpPost]
        [Route("{num1}/{num2}")]

        public List<string> GreaterOrLessThan(int num1, int num2)
        {
            return _GreaterOrLessThanService.GreaterOrLessThan(num1, num2);
        }
    }

