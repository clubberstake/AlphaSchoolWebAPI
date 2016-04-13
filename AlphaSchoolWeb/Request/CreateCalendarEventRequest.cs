using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaSchoolWeb.Request
{
    public class CreateCalendarEventRequest
    {
        public string Description { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public string Attachment { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }
    }
}
