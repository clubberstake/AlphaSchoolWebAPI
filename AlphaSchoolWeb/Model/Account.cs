using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaSchoolWeb.Model
{
    public class Account
    {
        public string AccountID { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string EmailAddress { get; set; }
        public string LoginType { get; set; }
    }
}
