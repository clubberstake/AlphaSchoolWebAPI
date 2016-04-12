using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AlphaSchoolWeb.Model;
using AlphaSchoolWeb.Response;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AlphaSchoolWeb.Controllers
{
    [Route("api/[controller]")]
    public class HomeworkAssignmentController : Controller
    {
        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return "Wrong";
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var courseList = new List<Course>()
            {
                new Course()
                {
                    CourseName = "Math",
                    Grade = 1,
                    ID = "101"
                },
                new Course()
                {
                    CourseName = "English",
                    Grade = 2,
                    ID = "201"
                },
                new Course()
                {
                    CourseName = "Science",
                    Grade = 3,
                    ID = "303"
                }
            };

            var homeworkList = new List<Homework>()
            {
                new Homework()
                {
                    ID = "1",
                    DateTime = new DateTime (2007, 3, 10, 0, 0, 0),
                    Title = "Algebra HW 1",
                    Description = "DO IT!!!!",
                    AttachmentPath = "http//......"
                },
                new Homework()
                {
                    ID = "2",
                    DateTime = new DateTime (2007, 3, 10, 0, 0, 0),
                    Title = "English",
                    Description = "Do IT Right",
                    AttachmentPath = "http//......"
                },

                new Homework()
                {
                    ID = "3",
                    DateTime = new DateTime (2007, 3, 10, 0, 0, 0),
                    Title = "Biology",
                    Description = "DO NOT DO IT!!!!",
                    AttachmentPath = "http//......"
                }

            };
            var addCourseResponse = new HomeworkResponse();
            addCourseResponse.CourseList = courseList;
            addCourseResponse.Homeworks = homeworkList;
            return JsonConvert.SerializeObject(addCourseResponse);
        }

    }
}
