using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using AlphaSchoolWeb.Model;
using AlphaSchoolWeb.Response;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AlphaSchoolWeb.Controllers
{
    [Route("api/[controller]")]
    public class AddCourseController : Controller
    {
        // GET: api/values
       [HttpGet]
        public string CourseList()
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
            var addCourseResponse = new AddCourseResponse();
            addCourseResponse.CourseList = courseList;
            addCourseResponse.CourseNames = CourseNames.Names;
            return JsonConvert.SerializeObject(addCourseResponse);
        }     

        
        


        // POST api/values
        [HttpPost]
        public string Post([FromBody] Course course)
        {

            return JsonConvert.SerializeObject(course);
            
        }


}
}
