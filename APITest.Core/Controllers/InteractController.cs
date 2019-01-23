using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITest.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InteractController : ControllerBase
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            log.Info("ID Request Received: " + id);
            return id.ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            log.Info("Received POST: " + value);
        }
    }
}