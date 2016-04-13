using System;
using System.Collections.Generic;

namespace AlphaSchoolWeb.Model
{
    public class Course
    {
        internal static readonly List<string> NamesT;

        public string ID { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
        public string CourseName { get; set; }
        public int Grade { get; set; }
        public DateTimeOffset Year { get; set; }
        public List<Announcement> Announcments { get; set; }
        public List<CalendarEvent> CalendarEvents { get; set; }
        public List<Homework> Homeworks { get; set; }
    }
}
