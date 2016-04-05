using System;

namespace AlphaSchoolWeb.Model
{
    public class Announcement
    {
        public string ID { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AttachmentPath { get; set; }
        public string CourseName { get; internal set; }
        public string Date { get; internal set; }
    }
}
