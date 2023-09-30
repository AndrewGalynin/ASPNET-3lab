using Microsoft.AspNetCore.Mvc;

namespace Lab3
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalcController : ControllerBase
    {
        private readonly CalcService _calcService;

        public CalcController(CalcService calcService)
        {
            _calcService = calcService;
        }

        [HttpGet("add")]
        public IActionResult Add(int x, int y) 
        {
            var result = _calcService.Add(x, y);
            return Ok(result);
        }

        [HttpGet("subtract")]
        public IActionResult Substraction(int a, int b)
        {
            var result = _calcService.Substraction(a, b);
            return Ok(result);
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(int a, int b)
        {
            var result = _calcService.Multiply(a, b);
            return Ok(result);
        }

        [HttpGet("divide")]
        public IActionResult Division(int a, int b)
        {
            try
            {
                var result = _calcService.Division(a, b);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
