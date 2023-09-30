using Microsoft.AspNetCore.Mvc;

namespace Lab3
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeOfDayController : ControllerBase
    {
        private readonly ITimeOfDayService _timeOfDayService;

        public TimeOfDayController(ITimeOfDayService timeOfDayService)
        {
            _timeOfDayService = timeOfDayService;
        }

        [HttpGet]
        public IActionResult GetTimeOfDay() 
        { 
            var timeOfDay = _timeOfDayService.GetTimeOfDay();
            return Ok(timeOfDay);
        }
    }
}
