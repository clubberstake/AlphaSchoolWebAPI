using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using AlphaSchoolWeb.Model;
using System.Text;
using AlphaSchoolWeb.Request;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AlphaSchoolWeb.Controllers
{
    [Route("api/[controller]")]
    public class CreateCalendarEventController : Controller
    {
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var calendarList = new List<CalendarEvent>()
            {
                new CalendarEvent()
                {
                    Title = "Spaghetti Dinner",
                    DateTime = DateTimeOffset.Now,
                    Description = "Come support the girls",
                    Location = "Kerr Fitness Center",
                }
            };

            return JsonConvert.SerializeObject(calendarList);
        }


        // POST api/values
        [HttpPost]
        public string Post([FromBody]CreateCalendarEventRequest createCalendarEventRequest)
        {
            //return JsonConvert.SerializeObject(createCalendarEventRequest);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(createCalendarEventRequest.Description);
            sb.AppendLine(createCalendarEventRequest.DateTime.ToLocalTime().ToString());
            sb.AppendLine(createCalendarEventRequest.Title);
            sb.AppendLine(createCalendarEventRequest.Attachment);
            return sb.ToString();
        }
    }
}

