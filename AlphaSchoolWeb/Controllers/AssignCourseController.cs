using AlphaSchoolWeb.Model;
using AlphaSchoolWeb.Request;
using AlphaSchoolWeb.Response;
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
            return "wrong";           
        }

        [HttpGet("{id}")]
        public string Get(string id)
        {
            var studentList = new List<Student>()
            {
                new Student()
                {
                    FirstName = "Vicky",
                    LastName = "Danko",
                    ID = "1"
                },
                new Student()
                {
                    FirstName = "Abdul",
                    LastName = "Fall",
                    ID = "2"
                },
                new Student()
                {
                    FirstName = "Bret",
                    LastName = "Pusateri",
                    ID = "3"
                }
            };

            var assignCourseResponse = new AssignCourseResponse();
            assignCourseResponse.Students = studentList;
            assignCourseResponse.CourseNames = CourseNames.Names;
            assignCourseResponse.CourseLevels = CourseLevel.Levels;

            return JsonConvert.SerializeObject(assignCourseResponse);
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody] AssignCourseRequest assignCourseRequest)
        {
            return "Saving Id " + assignCourseRequest.Id + " course Id " + assignCourseRequest.CourseId +
                " for grade " + assignCourseRequest.Grade + " for level " +assignCourseRequest.Level;
        }
    }
}