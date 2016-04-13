using AlphaSchoolWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaSchoolWeb.Response
{
    public class AddCourseResponse
    {
        public List<Course> CourseList { get; set; }
        public List<string> CourseNames { get; set; }
    }
}
