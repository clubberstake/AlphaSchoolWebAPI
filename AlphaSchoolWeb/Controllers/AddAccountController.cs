using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AlphaSchoolWeb.Model;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AlphaSchoolWeb.Controllers
{
    [Route("api/[controller]")]
    public class AddAccountController : Controller
    {
        // POST api/values
        [HttpPost]
        public string Post([FromBody] Account account)
        {
            return "This is the account created for:" + JsonConvert.SerializeObject(account);
        }
        
    }
}
