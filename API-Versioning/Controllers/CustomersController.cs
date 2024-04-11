using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace API_Versioning.Controllers
{
    [Route("api/v{v:apiVersion}/[controller]")]
    [ApiController]

    [ApiVersion(1)]
    [ApiVersion(2)]
    [ApiVersion(3, Deprecated = true)]
    public class CustomersController : ControllerBase
    {
        [MapToApiVersion(1)]
        [HttpGet]
        public IActionResult Get_v1()
        {
            return Ok("You are using API version 1");
        }

        [MapToApiVersion(2)]
        [HttpGet]
        public IActionResult Get_v2()
        {
            return Ok("You are using API version 2");
        }

        [MapToApiVersion(3)]
        [HttpGet]
        public IActionResult Get_v3()
        {
            return Ok("You are using deprecated API version 3");
        }
    }
}
