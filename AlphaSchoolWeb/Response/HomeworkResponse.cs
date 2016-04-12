using AlphaSchoolWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaSchoolWeb.Response
{
    public class HomeworkResponse
    {
        public List<Course> CourseList { get; set; }
        public List<Homework> Homeworks { get; set; }
    }
}
