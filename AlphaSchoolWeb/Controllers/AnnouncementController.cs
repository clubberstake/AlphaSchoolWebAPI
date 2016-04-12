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
    public class AnnouncementController : Controller
    {
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return "wrong";
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var AnnouncementsList = new List<Announcement>()
            {
                new Announcement()
                {
                    ID = "1",
                    DateTime = new DateTime (2007, 3, 10, 0, 0, 0),
                    Title = "Dinner with the Sisters",
                    Description = "Come on over to assist the sisters in hosting...",
                    AttachmentPath = "http//......"
                },
                new Announcement()
                {
                     ID = "2",
                    DateTime = new DateTime (2007, 3, 10, 0, 0, 0),
                    Title = "Dinner with the Sisters",
                    Description = "Come on over to assist the sisters in hosting...",
                    AttachmentPath = "http//......"
                },
                new Announcement()
                {
                     ID = "3",
                    DateTime = new DateTime (2007, 3, 10, 0, 0, 0),
                    Title = "Dinner with the Sisters",
                    Description = "Come on over to assist the sisters in hosting...",
                    AttachmentPath = "http//......"
                }
            };
            return JsonConvert.SerializeObject(AnnouncementsList);
        }
    }
}
