using AlphaSchoolWeb.Model;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Cors;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AlphaSchoolWeb.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Student student = new Student()
            {
                FirstName = "Frank",
                LastName = "The Tank",
                ID = "12345"
            };
            return JsonConvert.SerializeObject(student);
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]Student student)
        {
            return JsonConvert.SerializeObject(student);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
