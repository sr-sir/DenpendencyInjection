using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DenpendencyInjection.Interface;
using DenpendencyInjection.Relize;
using Microsoft.AspNetCore.Mvc;

namespace DenpendencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ITest _test;
        public ValuesController(ITest test)
        {
            _test = test;
        }



        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            string str = _test.Login();
            return new string[] { "value1", "value2", str };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
