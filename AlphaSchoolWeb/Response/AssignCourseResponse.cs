using AlphaSchoolWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaSchoolWeb.Response
{
    public class AssignCourseResponse
    {
        public List<Student> Students { get; set; }
        public List<string> CourseNames { get; set; }
        public List<string> CourseLevels { get; set; }
    }
}
