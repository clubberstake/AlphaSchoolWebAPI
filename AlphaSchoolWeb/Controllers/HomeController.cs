using AlphaSchoolWeb.Model;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AlphaSchoolWeb.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public string ViewCourses()
        {
            var courseList = new List<Course>()
            {
                new Course()
                {
                    ID = "1",
                    CourseName = "Math",
                    Grade = 4
                },

                new Course()
                {
                    ID = "2",
                    CourseName = "Science",
                    Grade = 2
                },

                new Course()
                {
                   ID = "3",
                   CourseName = "English",
                   Grade = 3
                }
              
            };
            return JsonConvert.SerializeObject(courseList);
        }

    }
}