using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaSchoolWeb.Request
{
    public class CreateAnnouncementRequest
    {
        public string AnnouncementText { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public string Attachment { get; set; }
        public string CourseId { get; set; }
    }
}
