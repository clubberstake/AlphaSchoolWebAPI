using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AlphaSchoolWeb.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        // POST api/values
        [HttpPost]
        public string Post([FromBody]Contact contact)
        {
            var contactList = new List<Contact>() {

                new Contact() {
                   ContactName = "Teacher",
                   SubjectName = "subject name",
                   Message = "My kid is a troublemaker",
                   
                }
            };
            return JsonConvert.SerializeObject(contact);
        }

    }
}
