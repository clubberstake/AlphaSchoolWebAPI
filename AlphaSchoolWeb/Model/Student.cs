using System.Collections.Generic;

namespace AlphaSchoolWeb.Model
{
    public class Student
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
            
        }
        public List<Course> Courses { get; set; }
    }
}
