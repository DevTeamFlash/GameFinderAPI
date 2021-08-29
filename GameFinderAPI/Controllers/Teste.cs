using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinderAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Teste : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "irmãJuneck", "irmãCosta", "irmãHugo" };
        }
    }
}
