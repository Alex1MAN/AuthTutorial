using AuthTutorial.Core.OtherObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthTutorial.Controllers
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
            return Ok(Summaries);
        }

        [HttpGet]
        [Route("GetUsersRole")]
        [Authorize(Roles = StaticUserRoles.USER)]
        public IActionResult GetUsersRole()
        {
            return Ok(Summaries);
        }

        [HttpGet]
        [Route("GetAdminRole")]
        [Authorize(Roles = StaticUserRoles.ADMIN)]
        public IActionResult GetAdminRole()
        {
            return Ok(Summaries);
        }

        [HttpGet]
        [Route("GetOwnerRole")]
        [Authorize(Roles = StaticUserRoles.OWNER)]
        public IActionResult GetOwnerRole()
        {
            return Ok(Summaries);
        }
    }
}
