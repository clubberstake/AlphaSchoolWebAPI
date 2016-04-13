using AlphaSchoolWeb.Model;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AlphaSchoolWeb.Controllers
{
    [Route("api/[controller]")]
    public class AssignCourseController : Controller
    {
        [HttpGet]
        public string IdList()
        {
            var IDList = new List<Course>()
            {
                new Course()
                {
                    ID = "101",
                    CourseName = "Math",
                    Grade = 1
                },
                new Course()
                {
                     ID = "201",
                    CourseName = "Science",
                    Grade = 1
                },
                new Course()
                {
                    ID = "301",
                    CourseName = "English",
                    Grade = 1
                }
            };
            return JsonConvert.SerializeObject(IDList);
        }

        [HttpGet("{id}")]
        public string Get(string id)
        {
            return "this is the ID:" + id;
        }
    }
}