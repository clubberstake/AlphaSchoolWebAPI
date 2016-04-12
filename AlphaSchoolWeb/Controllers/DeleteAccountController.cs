using AlphaSchoolWeb.Model;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AlphaSchoolWeb.Controllers
{
    [Route("api/[controller]")]
    public class DeleteAccountController : Controller
    {
        [HttpGet]
        public string DeleteAccount()
        {
            var studentList = new List<Student>()
            {
                new Student()
                {
                    FirstName = "Vicky",
                    LastName = "Danko",
                    ID = "1"
                },
                new Student()
                {
                    FirstName = "Abdul",
                    LastName = "Fall",
                    ID = "2"
                },
                new Student()
                {
                    FirstName = "Bret",
                    LastName = "Pusateri",
                    ID = "3"
                }
            };
            return JsonConvert.SerializeObject(studentList);
        }

        [HttpDelete]
        public string DeleteAccount(string id, string LastName)
        {
            return "Account Deleted Passed ->" + id + LastName;
        }
    }
}
