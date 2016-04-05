using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using AlphaSchoolWeb.Model;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AlphaSchoolWeb.Controllers
{
    [Route("api/[controller]")]
    public class CreateCalendarEventController : Controller
    {
            public string CreateCalendarEvent()
            {
                var teacherList = new List<Teacher>() {

                new Teacher() {

                    FirstName = "Brian ",
                    LastName = "Smith",
                    CourseName = "Grade 1: Mathematics, Grade 3: Mathematics",
                    ID = "1",
                }
            };
                return JsonConvert.SerializeObject(teacherList);
            }


            // POST api/values
            [HttpPost]
            public string Post([FromBody]CalendarEvent calendarevent)
            {
                var calendarList = new List<CalendarEvent>() {

                new CalendarEvent() {
                    AttachmentPath= "Upload",
                    Date = "April 5th 2016",
                    CourseName = "Grade 1: Mathematics",
                    Title = "Homework Sucks!",

                }
            };
                return JsonConvert.SerializeObject(calendarevent);
            }

        }
    }