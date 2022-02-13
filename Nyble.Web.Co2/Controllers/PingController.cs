using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Nyble.Web.Co2.Controllers
{
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet("ping")]
        public async Task<IActionResult> Get()
        {
            return Content("pong");
        }
    }
}