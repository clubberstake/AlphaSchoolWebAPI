using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaSchoolWeb.Request
{
    public class AssignCourseRequest
    {
        public string Id { get; set; }
        public string CourseId { get; set; }
        public string Grade { get; set; }
        public string Level { get; set; }
    }
}
